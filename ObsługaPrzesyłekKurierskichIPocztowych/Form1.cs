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
            DB.showDataFromMessage(messageTableView, "");
            DB.showData("kurier", messangerTableView);
            DB.showDataFromMessage(messageTableView, "");
            DB.showDataFromMessenger(messangerTableView);
            DB.showData("pojazd", vehicleTableView);
            DB.showData("grafik", graphicTableView);
            DB.showDataFromOdbiorca(odbiorcaTableView);


        }

        DatabaseAdministration DB = new DatabaseAdministration();

        private void addButton_message_Click(object sender, EventArgs e)
        {
            MessageDesign msgForm = new MessageDesign();
            msgForm.ShowDialog();
            DB.showDataFromMessage(messageTableView, "");
            DB.showDataFromOdbiorca(odbiorcaTableView);

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DB.showDataFromMessage(messageTableView, "");
        }

        public void refresh()
        {
            DB.showDataFromMessage(messageTableView, "");
        }

        private void deleteButton_message_Click(object sender, EventArgs e)
        {
            DB.deleteDataFromMessage(messageTableView);
            DB.showDataFromMessage(messageTableView, "");
        }

        private void deleteAllButton_message_Click(object sender, EventArgs e)
        {
            DB.deleteAllDataFromMessage();
            DB.showDataFromMessage(messageTableView, "");
        }

        private void deleteReceivedButton_Click(object sender, EventArgs e)
        {
            DB.deleteReceivedMessages();
            DB.showDataFromMessage(messageTableView, "");
        }

        private void editButton_message_Click(object sender, EventArgs e)
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
            string statusIn = messageTableView.Rows[row].Cells[11].Value.ToString();
            int statusInInt;
            if (statusIn == "gotowa")
                statusInInt = 1;
            else if (statusIn == "u kuriera")
                statusInInt = 2;
            else
            {
                statusInInt = 3;
                receiveDate = "";
            }

            int id = (int)messageTableView.Rows[row].Cells[0].Value;

            MessageDesign msgForm = new MessageDesign(id, messanger, recipient_name, recipient_surname, addressIn, city_name, sizeIn, statusInInt, priorityIn, paymentAfter, costIn, sendDate, receiveDate);
            msgForm.ShowDialog();
            DB.showDataFromOdbiorca(odbiorcaTableView);
            DB.showDataFromMessage(messageTableView, "");
        }

        private void messangerListButton_Click(object sender, EventArgs e)
        {
            MessangersTopList msgTopList = new MessangersTopList();
            msgTopList.Show();
        }

        private void searchMessangerButton_Click(object sender, EventArgs e)
        {
            string search = messangerPattern.Text;
            DB.showFoundMessagesByMessangers(messageTableView, search);
        }

        private void receivedMessagesButton_Click(object sender, EventArgs e)
        {
            DB.showMessagesByStatus(messageTableView, "dostarczona", string.IsNullOrWhiteSpace(messangerPattern.Text), messangerPattern.Text);
        }

        private void readyMessagesButton_Click(object sender, EventArgs e)
        {
            DB.showMessagesByStatus(messageTableView, "gotowa", string.IsNullOrWhiteSpace(messangerPattern.Text), messangerPattern.Text);
        }

        private void addButton_messanger_Click(object sender, EventArgs e)
        {
            MessengerDesign msgrForm = new MessengerDesign();
            msgrForm.ShowDialog();
            DB.showDataFromMessenger(messangerTableView);
        }

        private void editButton_messanger_Click(object sender, EventArgs e)
        {
            int row = messangerTableView.CurrentCellAddress.Y;

            string name = messangerTableView.Rows[row].Cells[1].Value.ToString();
            string surname = messangerTableView.Rows[row].Cells[2].Value.ToString();
            string city_name = messangerTableView.Rows[row].Cells[3].Value.ToString();
            int id = (int)messangerTableView.Rows[row].Cells[0].Value;
            MessengerDesign msgForm = new MessengerDesign(id, name, surname, city_name);
            msgForm.ShowDialog();
            DB.showDataFromMessenger(messangerTableView);

        }

        private void deleteButton_messanger_Click(object sender, EventArgs e)
        {
            DB.deleteDataFromMessenger(messangerTableView);
            DB.showDataFromMessenger(messangerTableView);
        }

        private void deleteAllButton_messanger_Click(object sender, EventArgs e)
        {
            DB.deleteAllDataFromMessenger();
            DB.showDataFromMessenger(messangerTableView);
        }


        private void addButton_odbiorca_Click(object sender, EventArgs e)
        {
            OdbiorcaDesign obrForm = new OdbiorcaDesign();
            obrForm.ShowDialog();
            DB.showDataFromOdbiorca(odbiorcaTableView);

        }

        private void editButton_odbiorca_Click(object sender, EventArgs e)
        {
            int row = odbiorcaTableView.CurrentCellAddress.Y;

            string name = odbiorcaTableView.Rows[row].Cells[1].Value.ToString();
            string surname = odbiorcaTableView.Rows[row].Cells[2].Value.ToString();
            int id = (int)odbiorcaTableView.Rows[row].Cells[0].Value;
            OdbiorcaDesign msgForm = new OdbiorcaDesign(id, name, surname);
            msgForm.ShowDialog();
            DB.showDataFromOdbiorca(odbiorcaTableView);
        }

        private void deleteButton_odbiorca_Click(object sender, EventArgs e)
        {
            DB.deleteDataFromOdbiorca(odbiorcaTableView);
            DB.showDataFromOdbiorca(odbiorcaTableView);
        }

        private void deleteAllButton_odbiorca_Click(object sender, EventArgs e)
        {
            DB.deleteAllDataFromOdbiorca();
            DB.showDataFromOdbiorca(odbiorcaTableView);
        }

    }
}
