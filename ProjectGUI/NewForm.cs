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
    public partial class NewForm : Form
    {
        OleDbConnection connection = new OleDbConnection();

        OrderForm orderForm;
        public NewForm(OrderForm order)
        {
            InitializeComponent();
            orderForm = order;

            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=Game Store Inventory.accdb;
                Persist Security Info=False;";
        }

        private void NewForm_Load(object sender, EventArgs e)
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
            newItemlabel.Text = "Order Number:";
            itemListBox.Items.Clear();
            itemListBox.Items.Add("OrderID\tCustID\tGameID");

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
                    itemListBox.Items.Add(reader["OrderID"].ToString() + "\t" + reader["CustomerID"].ToString() + "\t" + reader["GameID"].ToString());
                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void customerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newItemlabel.Text = "Customer Number:";
            itemListBox.Items.Clear();
            itemListBox.Items.Add("ID\tName");

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
                    itemListBox.Items.Add(reader["CustomerID"].ToString() + "\t" + reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
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
            newItemlabel.Text = "Game Number:";
            itemListBox.Items.Clear();
            itemListBox.Items.Add("ID\tTitle & System");

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
                    itemListBox.Items.Add(reader["GameID"].ToString() + "\t" + reader["GameName"].ToString() + " " + reader["Platform"].ToString());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void newItemlabel_Click(object sender, EventArgs e)
        {

        }

        private void newItemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                if (newItemTextBox.Text == "")
                {
                    MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (orderRadioButton.Checked)
                    {
                        command.CommandText = "INSERT INTO [Order] (OrderID) VALUES (@orderID)";

                        command.Parameters.AddWithValue("@orderID", newItemTextBox.Text);
                        command.ExecuteNonQuery();

                        orderForm.idNumberTextBox.Text = newItemTextBox.Text;

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
                        this.Close();
                    }

                    else if (customerRadioButton.Checked)
                    {
                        command.CommandText = "INSERT INTO [Customer] (CustomerID) VALUES (@customerID)";

                        command.Parameters.AddWithValue("@customerID", newItemTextBox.Text);
                        command.ExecuteNonQuery();

                        orderForm.idNumberTextBox.Text = newItemTextBox.Text;

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
                        this.Close();
                    }

                    else if (gameRadioButton.Checked)
                    {
                        command.CommandText = "INSERT INTO [Game] (GameID) VALUES (@gameID)";

                        command.Parameters.AddWithValue("@gameID", newItemTextBox.Text);
                        command.ExecuteNonQuery();

                        orderForm.idNumberTextBox.Text = newItemTextBox.Text;

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
                        this.Close();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
