using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ObsługaPrzesyłekKurierskichIPocztowych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showData("przesylka",  messageTableView);
            showData("kurier", messangerTableView);
            showData("pojazd", vehicleTableView);
            showData("grafik", graphicTableView);
        }
 
        MySqlConnection con = new MySqlConnection("datasource = localhost;port = 3306; Initial Catalog = 'poczta'; username = root; password=Stokrotka1");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public void showData(string _table_name, DataGridView view)
        {
            string searchQuery = "SELECT * FROM `" + _table_name + "`";
            command = new MySqlCommand(searchQuery, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            view.DataSource = table;
        }

        public void insertData(string value, string _table_name)
        {
            string searchQuery = "INSERT INTO `" + _table_name + "` (adres) VALUES ('" + value + "')";
            command = new MySqlCommand(searchQuery, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            MessageBox.Show("Dodano");
        }
 
        private void insertButton_Click(object sender, EventArgs e)
        {
            //string value = textBox_Value.Text.ToString();
            //insertData(value, table_name);
        }

    }
}
