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
    public partial class DisplayForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public DisplayForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=Game Store Inventory.accdb;
                Persist Security Info=False;";
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void selectItemGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void orderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [Order] ORDER BY OrderID ASC";
                command.CommandText = query;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                itemDataGridView.DataSource = table;

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
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [Customer] ORDER BY CustomerID ASC";
                command.CommandText = query;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                itemDataGridView.DataSource = table;

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
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM [Game] ORDER BY GameID ASC";
                command.CommandText = query;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                itemDataGridView.DataSource = table;

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void itemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
