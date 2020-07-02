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
    public partial class OrderForm : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public OrderForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=Game Store Inventory.accdb;
                Persist Security Info=False;";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                connectionLabel.Text = "Connection Successful";
                connectionLabel.ForeColor = Color.Red;

                command.Connection = connection;
                string query1 = "SELECT * FROM [Customer]";
                command.CommandText = query1;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customerIDComboBox.Items.Add(reader["CustomerID"].ToString());
                }

                connection.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionLabel.Text = "Connection Failed";
                connectionLabel.ForeColor = Color.Red;
            }

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query2 = "SELECT * FROM [Game]";
                command.CommandText = query2;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    gameIDComboBox.Items.Add(reader["GameID"].ToString());
                }

                connection.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm(this);
            newForm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm openForm = new OpenForm(this);
            openForm.ShowDialog();            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                if (idNumberTextBox.Text == "")
                {
                    MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (idNumberLabel.Text == "Order Number")
                    {
                        command.CommandText = "UPDATE [Order] SET OrderDate = @orderDate, OrderQuantity = @orderQuantity," +
                            "OrderPrice = @orderPrice, CustomerID = @customerID, GameID = @gameID WHERE OrderID = @orderID";

                        if (string.IsNullOrEmpty(item1TextBox.Text))
                        {
                            command.Parameters.AddWithValue("@orderDate", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@orderDate", item1TextBox.Text);
                        }

                        if (string.IsNullOrEmpty(item2TextBox.Text))
                        {
                            command.Parameters.AddWithValue("@orderQuantity", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@orderQuantity", item2TextBox.Text);
                        }

                        if (string.IsNullOrEmpty(item3TextBox.Text))
                        {
                            command.Parameters.AddWithValue("@orderPrice", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@orderPrice", item3TextBox.Text);
                        }

                        if (string.IsNullOrEmpty(customerIDComboBox.Text))
                        {
                            command.Parameters.AddWithValue("@customerID", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@customerID", customerIDComboBox.Text);
                        }

                        if (string.IsNullOrEmpty(gameIDComboBox.Text))
                        {
                            command.Parameters.AddWithValue("@gameID", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@gameID", gameIDComboBox.Text);
                        }

                        command.Parameters.AddWithValue("@orderID", Convert.ToInt32(idNumberTextBox.Text));
                    }

                    if (idNumberLabel.Text == "Customer Number")
                    {
                        command.CommandText = "UPDATE [Customer] SET FirstName = @firstName, LastName = @lastName," +
                            "Address = @address, City = @city, State = @state, Zip = @zip, Phone = @phone, Email = @email" +
                            " WHERE CustomerID = @customerID";

                        command.Parameters.AddWithValue("@firstName", item1TextBox.Text);
                        command.Parameters.AddWithValue("@lastName", item2TextBox.Text);
                        command.Parameters.AddWithValue("@address", item3TextBox.Text);
                        command.Parameters.AddWithValue("@city", item4TextBox.Text);
                        command.Parameters.AddWithValue("@state", item5TextBox.Text);

                        if (string.IsNullOrEmpty(item6TextBox.Text))
                        {
                            command.Parameters.AddWithValue("@zip", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@zip", item6TextBox.Text);
                        }

                        command.Parameters.AddWithValue("@phone", item7TextBox.Text);
                        command.Parameters.AddWithValue("@email", item8TextBox.Text);
                        command.Parameters.AddWithValue("@customerID", Convert.ToInt32(idNumberTextBox.Text));
                    }

                    if (idNumberLabel.Text == "Game Number")
                    {
                        command.CommandText = "UPDATE [Game] SET GameName = @gameName, Developer = @developer," +
                            "Genre = @genre, Platform = @platform, ReleaseDate = @releaseDate, GamePrice = @gamePrice, " +
                            "GameQuantity = @gameQuantity WHERE GameID = @gameID";

                        command.Parameters.AddWithValue("@gameName", item1TextBox.Text);
                        command.Parameters.AddWithValue("@developer", item2TextBox.Text);
                        command.Parameters.AddWithValue("@genre", item3TextBox.Text);
                        command.Parameters.AddWithValue("@platform", item4TextBox.Text);

                        if (string.IsNullOrEmpty(item5TextBox.Text))
                        {
                            command.Parameters.AddWithValue("@releaseDate", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@releaseDate", item5TextBox.Text);
                        }

                        if (string.IsNullOrEmpty(item6TextBox.Text))
                        {
                            command.Parameters.AddWithValue("@gamePrice", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@gamePrice", item6TextBox.Text);
                        }

                        if (string.IsNullOrEmpty(item7TextBox.Text))
                        {
                            command.Parameters.AddWithValue("@gameQuantity", DBNull.Value);
                        }

                        else
                        {
                            command.Parameters.AddWithValue("@gameQuantity", item7TextBox.Text);
                        }

                        command.Parameters.AddWithValue("@gameID", Convert.ToInt32(idNumberTextBox.Text));                     
                    }

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                OleDbCommand command2 = new OleDbCommand();
                command1.Connection = connection;
                command2.Connection = connection;

                if (idNumberTextBox.Text == "")
                {
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (idNumberLabel.Text == "Order Number")
                    {
                        command1.CommandText = "INSERT INTO [TempOrder] (OrderID, OrderDate, OrderQuantity, OrderPrice," +
                            "CustomerID, GameID) SELECT OrderID, OrderDate, OrderQuantity, OrderPrice, CustomerID, GameID " +
                            "FROM [Order] WHERE OrderID = @orderID";

                        command2.CommandText = "DELETE FROM [Order] WHERE OrderID = @orderID";

                        command1.Parameters.AddWithValue("@orderID", Convert.ToInt32(idNumberTextBox.Text));
                        command2.Parameters.AddWithValue("@orderID", Convert.ToInt32(idNumberTextBox.Text));
                    }

                    else if (idNumberLabel.Text == "Customer Number")
                    {
                        command1.CommandText = "INSERT INTO [TempCustomer] (CustomerID, FirstName, LastName, Address, City," +
                            "State, Zip, Phone, Email) SELECT CustomerID, FirstName, LastName, Address, City, State, Zip," +
                            "Phone, Email FROM [Customer] WHERE CustomerID = @customerID";

                        command2.CommandText = "DELETE FROM [Customer] WHERE CustomerID = @customerID";

                        command1.Parameters.AddWithValue("@customerID", Convert.ToInt32(idNumberTextBox.Text));
                        command2.Parameters.AddWithValue("@customerID", Convert.ToInt32(idNumberTextBox.Text));
                    }

                    else if (idNumberLabel.Text == "Game Number")
                    {
                        command1.CommandText = "INSERT INTO [TempGame] (GameID, GameName, Developer, Genre," +
                            "Platform, ReleaseDate, GamePrice, GameQuantity) SELECT GameID, GameName, Developer, Genre, " +
                            "Platform, ReleaseDate, GamePrice, GameQuantity FROM [Game] WHERE GameID = @gameID";

                        command2.CommandText = "DELETE FROM [Game] WHERE GameID = @gameID";

                        command1.Parameters.AddWithValue("@gameID", Convert.ToInt32(idNumberTextBox.Text));
                        command2.Parameters.AddWithValue("@gameID", Convert.ToInt32(idNumberTextBox.Text));
                    }

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }

                connection.Close();

                idNumberTextBox.Clear();
                item1TextBox.Clear();
                item2TextBox.Clear();
                item3TextBox.Clear();
                item4TextBox.Clear();
                item5TextBox.Clear();
                item6TextBox.Clear();
                item7TextBox.Clear();
                item8TextBox.Clear();
                customerIDComboBox.SelectedIndex = -1;
                gameIDComboBox.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }

            /*************************************************************************************************************************************************/
        }

        private void undeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndeleteForm undeleteForm = new UndeleteForm(this);
            undeleteForm.ShowDialog();
        }

        private void purgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to permanently purge all deleted records?", "Game Store Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                OleDbCommand command2 = new OleDbCommand();
                OleDbCommand command3 = new OleDbCommand();
                command1.Connection = connection;
                command2.Connection = connection;
                command3.Connection = connection;

                command1.CommandText = "DELETE FROM [TempOrder]";
                command2.CommandText = "DELETE FROM [TempCustomer]";
                command3.CommandText = "DELETE FROM [TempGame]";

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
               
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm();
            displayForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Store Inventory Project GUI\nAuthor Tyler Burger\nCSCI234 2019");
        }

        private void connectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gameIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void item2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void item3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void item4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void item5TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
