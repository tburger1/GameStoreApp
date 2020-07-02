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
    public partial class UndeleteForm : Form
    {
        OleDbConnection connection = new OleDbConnection();

        OrderForm orderForm;
        public UndeleteForm(OrderForm order)
        {
            InitializeComponent();
            orderForm = order;

            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=Game Store Inventory.accdb;
                Persist Security Info=False;";
        }

        private void UndeleteForm_Load(object sender, EventArgs e)
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

        private void itemGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void orderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            undeleteItemLabel.Text = "Order Number:";
            undeleteComboBox.Text = "";
            undeleteComboBox.Items.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [TempOrder] ORDER BY OrderID ASC";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    undeleteComboBox.Items.Add(reader["OrderID"].ToString());
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
            undeleteItemLabel.Text = "Customer Number:";
            undeleteComboBox.Text = "";
            undeleteComboBox.Items.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [TempCustomer] ORDER BY CustomerID ASC";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    undeleteComboBox.Items.Add(reader["CustomerID"].ToString());
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
            undeleteItemLabel.Text = "Game Number:";
            undeleteComboBox.Text = "";
            undeleteComboBox.Items.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [TempGame] ORDER BY GameID ASC";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    undeleteComboBox.Items.Add(reader["GameID"].ToString());
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void undeleteItemLabel_Click(object sender, EventArgs e)
        {

        }

        private void undeleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                OleDbCommand command2 = new OleDbCommand();
                command1.Connection = connection;
                command2.Connection = connection;

                if (undeleteComboBox.Text == "")
                {
                    MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (orderRadioButton.Checked)
                    {
                        command1.CommandText = "INSERT INTO [Order] (OrderID, OrderDate, OrderQuantity, OrderPrice," +
                            "CustomerID, GameID) SELECT OrderID, OrderDate, OrderQuantity, OrderPrice, CustomerID, GameID " +
                            "FROM [TempOrder] WHERE OrderID = @orderID";

                        command2.CommandText = "DELETE FROM [TempOrder] WHERE OrderID = @orderID";

                        command1.Parameters.AddWithValue("@orderID", Convert.ToInt32(undeleteComboBox.Text));
                        command2.Parameters.AddWithValue("@orderID", Convert.ToInt32(undeleteComboBox.Text));
                    }

                    else if (customerRadioButton.Checked)
                    {
                        command1.CommandText = "INSERT INTO [Customer] (CustomerID, FirstName, LastName, Address, City," +
                            "State, Zip, Phone, Email) SELECT CustomerID, FirstName, LastName, Address, City, State, Zip," +
                            "Phone, Email FROM [TempCustomer] WHERE CustomerID = @customerID";

                        command2.CommandText = "DELETE FROM [TempCustomer] WHERE CustomerID = @customerID";

                        command1.Parameters.AddWithValue("@customerID", Convert.ToInt32(undeleteComboBox.Text));
                        command2.Parameters.AddWithValue("@customerID", Convert.ToInt32(undeleteComboBox.Text));
                    }

                    else if (gameRadioButton.Checked)
                    {
                        command1.CommandText = "INSERT INTO [Game] (GameID, GameName, Developer, Genre," +
                            "Platform, ReleaseDate, GamePrice, GameQuantity) SELECT GameID, GameName, Developer, Genre, " +
                            "Platform, ReleaseDate, GamePrice, GameQuantity FROM [TempGame] WHERE GameID = @gameID";

                        command2.CommandText = "DELETE FROM [TempGame] WHERE GameID = @gameID";

                        command1.Parameters.AddWithValue("@gameID", Convert.ToInt32(undeleteComboBox.Text));
                        command2.Parameters.AddWithValue("@gameID", Convert.ToInt32(undeleteComboBox.Text));
                    }

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    this.Close();
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
