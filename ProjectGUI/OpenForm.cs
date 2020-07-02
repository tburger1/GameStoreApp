using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjectGUI
{
    public partial class OpenForm : Form
    {
        OleDbConnection connection = new OleDbConnection();

        OrderForm orderForm;
        public OpenForm(OrderForm order)
        {
            InitializeComponent();
            orderForm = order;

            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=Game Store Inventory.accdb;
                Persist Security Info=False;";
        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            orderForm.item4Label.Enabled = true;
            orderForm.item4TextBox.Enabled = true;
            orderForm.item5Label.Enabled = true;
            orderForm.item5TextBox.Enabled = true;
            orderForm.item6Label.Enabled = true;
            orderForm.item6TextBox.Enabled = true;
            orderForm.item7Label.Enabled = true;
            orderForm.item7TextBox.Enabled = true;
            orderForm.item8Label.Enabled = true;
            orderForm.item8TextBox.Enabled = true;
            orderForm.customerIDLabel.Enabled = true;
            orderForm.customerIDComboBox.Enabled = true;
            orderForm.gameIDLabel.Enabled = true;
            orderForm.gameIDComboBox.Enabled = true;

            orderForm.idNumberTextBox.Clear();
            orderForm.item1TextBox.Clear();
            orderForm.item2TextBox.Clear();
            orderForm.item3TextBox.Clear();
            orderForm.item4TextBox.Clear();
            orderForm.item5TextBox.Clear();
            orderForm.item6TextBox.Clear();
            orderForm.item7TextBox.Clear();
            orderForm.item8TextBox.Clear();
            orderForm.customerIDComboBox.SelectedIndex = -1;
            orderForm.gameIDComboBox.SelectedIndex = -1;
        }

        private void selectItemGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void orderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            openItemLabel.Text = "Order Number:";
            openItemComboBox.Text = "";
            openItemComboBox.Items.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [Order] ORDER BY OrderID ASC";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    openItemComboBox.Items.Add(reader["OrderID"].ToString());
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void customerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            openItemLabel.Text = "Customer Number:";
            openItemComboBox.Text = "";
            openItemComboBox.Items.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [Customer] ORDER BY CustomerID ASC";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    openItemComboBox.Items.Add(reader["CustomerID"].ToString());
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void gameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            openItemLabel.Text = "Game Number:";
            openItemComboBox.Text = "";
            openItemComboBox.Items.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [Game] ORDER BY GameID ASC";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    openItemComboBox.Items.Add(reader["GameID"].ToString());
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void openItemLabel_Click(object sender, EventArgs e)
        {

        }

        private void openItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                if (openItemComboBox.Text == "")
                {
                    MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (orderRadioButton.Checked)
                    {
                        string query = "SELECT * FROM [Order] WHERE OrderID = @orderID";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@orderID", openItemComboBox.Text);

                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                orderForm.idNumberTextBox.Text = reader["OrderID"].ToString();
                                orderForm.item1TextBox.Text = reader["OrderDate"].ToString();
                                orderForm.item2TextBox.Text = reader["OrderQuantity"].ToString();
                                orderForm.item3TextBox.Text = reader["OrderPrice"].ToString();
                                orderForm.customerIDComboBox.Text = reader["CustomerID"].ToString();
                                orderForm.gameIDComboBox.Text = reader["GameID"].ToString();
                            }

                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        orderForm.idNumberLabel.Text = "Order Number";
                        orderForm.item1Label.Text = "Date";
                        orderForm.item2Label.Text = "Quantity";
                        orderForm.item3Label.Text = "Price";

                        orderForm.item4Label.Enabled = false;
                        orderForm.item4TextBox.Enabled = false;
                        orderForm.item5Label.Enabled = false;
                        orderForm.item5TextBox.Enabled = false;
                        orderForm.item6Label.Enabled = false;
                        orderForm.item6TextBox.Enabled = false;
                        orderForm.item7Label.Enabled = false;
                        orderForm.item7TextBox.Enabled = false;
                        orderForm.item8Label.Enabled = false;
                        orderForm.item8TextBox.Enabled = false;
                    }

                    else if (customerRadioButton.Checked)
                    {
                        string query = "SELECT * FROM [Customer] WHERE CustomerID = @customerID";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@customerID", openItemComboBox.Text);

                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                orderForm.idNumberTextBox.Text = reader["CustomerID"].ToString();
                                orderForm.item1TextBox.Text = reader["FirstName"].ToString();
                                orderForm.item2TextBox.Text = reader["LastName"].ToString();
                                orderForm.item3TextBox.Text = reader["Address"].ToString();
                                orderForm.item4TextBox.Text = reader["City"].ToString();
                                orderForm.item5TextBox.Text = reader["State"].ToString();
                                orderForm.item6TextBox.Text = reader["Zip"].ToString();
                                orderForm.item7TextBox.Text = reader["Phone"].ToString();
                                orderForm.item8TextBox.Text = reader["Email"].ToString();
                            }

                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        orderForm.idNumberLabel.Text = "Customer Number";
                        orderForm.item1Label.Text = "First Name";
                        orderForm.item2Label.Text = "Last Name";
                        orderForm.item3Label.Text = "Address";
                        orderForm.item4Label.Text = "City";
                        orderForm.item5Label.Text = "State";
                        orderForm.item6Label.Text = "Zip";
                        orderForm.item7Label.Text = "Phone";
                        orderForm.item8Label.Text = "Email";

                        orderForm.customerIDLabel.Enabled = false;
                        orderForm.customerIDComboBox.Enabled = false;
                        orderForm.gameIDLabel.Enabled = false;
                        orderForm.gameIDComboBox.Enabled = false;
                    }

                    else if (gameRadioButton.Checked)
                    {
                        string query = "SELECT * FROM [Game] WHERE GameID = @gameID";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@gameID", openItemComboBox.Text);

                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                orderForm.idNumberTextBox.Text = reader["GameID"].ToString();
                                orderForm.item1TextBox.Text = reader["GameName"].ToString();
                                orderForm.item2TextBox.Text = reader["Developer"].ToString();
                                orderForm.item3TextBox.Text = reader["Genre"].ToString();
                                orderForm.item4TextBox.Text = reader["Platform"].ToString();
                                orderForm.item5TextBox.Text = reader["ReleaseDate"].ToString();
                                orderForm.item6TextBox.Text = reader["GamePrice"].ToString();
                                orderForm.item7TextBox.Text = reader["GameQuantity"].ToString();
                            }

                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        orderForm.idNumberLabel.Text = "Game Number";
                        orderForm.item1Label.Text = "Title";
                        orderForm.item2Label.Text = "Developer";
                        orderForm.item3Label.Text = "Genre";
                        orderForm.item4Label.Text = "System";
                        orderForm.item5Label.Text = "Release Date";
                        orderForm.item6Label.Text = "Price";
                        orderForm.item7Label.Text = "Quantity";

                        orderForm.item8Label.Enabled = false;
                        orderForm.item8TextBox.Enabled = false;
                        orderForm.customerIDLabel.Enabled = false;
                        orderForm.customerIDComboBox.Enabled = false;
                        orderForm.gameIDLabel.Enabled = false;
                        orderForm.gameIDComboBox.Enabled = false;
                    }
                }
                            
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
