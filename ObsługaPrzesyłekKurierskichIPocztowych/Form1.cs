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
            DB.showDataFromMessage(messageTableView);
            DB.showData("kurier", messangerTableView);
            DB.showData("pojazd", vehicleTableView);
            DB.showData("grafik", graphicTableView);
        }

        DatabaseAdministration DB = new DatabaseAdministration();

        private void addButton_message_Click(object sender, EventArgs e)
        {
            MessageDesign msgForm = new MessageDesign();
            msgForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DB.showDataFromMessage(messageTableView);
        }

        private void deleteButton_message_Click(object sender, EventArgs e)
        {
            DB.deleteDataFromMessage(messageTableView);
        }

        private void editButton_message_Click(object sender, EventArgs e)
        {
            try
            {
                int row = messageTableView.CurrentCellAddress.Y;
                string[] names = messageTableView.Rows[row].Cells[1].Value.ToString().Split(' ');
                string recipient_name = names[0];
                string recipient_surname = names[1];
                string messanger = messageTableView.Rows[row].Cells[2].Value.ToString();
                string city_name = messageTableView.Rows[row].Cells[3].Value.ToString(); ;
                int sizeIn = (int)messageTableView.Rows[row].Cells[4].Value;
                bool priorityIn = Convert.ToBoolean(messageTableView.Rows[row].Cells[5].Value);
                string sendDate = messageTableView.Rows[row].Cells[6].Value.ToString();
                string receiveDate = messageTableView.Rows[row].Cells[7].Value.ToString();
                bool paymentAfter = !Convert.IsDBNull(messageTableView.Rows[row].Cells[8].Value);
                int costIn = (int)messageTableView.Rows[row].Cells[9].Value;
                string addressIn = messageTableView.Rows[row].Cells[10].Value.ToString();
                int statusIn = 1;// (int)messageTableView.Rows[row].Cells[11].Value;
                int id = (int)messageTableView.Rows[row].Cells[0].Value;
                Console.WriteLine(id);
                MessageDesign msgForm = new MessageDesign(id, messanger, recipient_name, recipient_surname, addressIn, city_name, sizeIn, statusIn, priorityIn, paymentAfter, costIn, sendDate, receiveDate);
                msgForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
