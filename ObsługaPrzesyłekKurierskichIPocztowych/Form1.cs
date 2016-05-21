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

    }
}
