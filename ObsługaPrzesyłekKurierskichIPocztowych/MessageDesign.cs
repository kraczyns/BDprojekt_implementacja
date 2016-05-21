using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObsługaPrzesyłekKurierskichIPocztowych
{
    public partial class MessageDesign : Form
    {
        public MessageDesign()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DatabaseAdministration DB = new DatabaseAdministration();
            string sendDate = dateSend.Value.ToString("yyyy-MM-dd");
            string receiveDate = dateReceive.Value.ToString("yyyy-MM-dd");
            DB.insertDataToMessage("kurier", recipientName.Text, recipientSurname.Text, address.Text, city.Text, size.SelectedIndex, status.SelectedIndex, priority.Checked, paymentLater.Checked, Int32.Parse(cost.Text), sendDate, receiveDate);
        }
    }
}
