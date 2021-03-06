﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace ObsługaPrzesyłekKurierskichIPocztowych
{
    public partial class MessageDesign : Form
    {
        private bool _editMode = false;
        private bool msngAuto = false;
        private int _id;
        public MessageDesign()
        {
            InitializeComponent();
            DB.fillComboBoxWithMessangers(messangersBox);
            DB.fillComboBoxWithPlaces(city);
        }

        public MessageDesign(int id, string messanger, string recipient_name, string recipient_surname, string addressIn, string city_name, int sizeIn, int statusIn, bool priorityIn, bool paymentAfter, int costIn, string sendDate, string receiveDate)
        {
            _editMode = true;
            _id = id;
            InitializeComponent();
            Console.WriteLine(dateSend);
            dateSend.Value = DateTime.ParseExact(sendDate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            if (receiveDate != "")
            {
                dateReceive.Value = DateTime.ParseExact(receiveDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            }
            status.SelectedIndex = statusIn - 1;
            messangersBox.SelectedItem = messangersBox.FindStringExact(messanger);//messanger;
            messangersBox.Text= messanger;
            messangersBox.SelectedIndex = messangersBox.FindStringExact(messanger);

            recipientName.Text = recipient_name;
            recipientSurname.Text = recipient_surname;
            address.Text = addressIn;
            city.Text = city_name;
            size.SelectedIndex = sizeIn-1;
            priority.Checked = priorityIn;
            paymentLater.Checked = paymentAfter;
            cost.Text = costIn.ToString();
            DB.fillComboBoxWithMessangers(messangersBox);
            DB.fillComboBoxWithPlaces(city);
        }

        DatabaseAdministration DB = new DatabaseAdministration();

        private void saveButton_Click(object sender, EventArgs e)
        {

            string sendDate = dateSend.Value.ToString("yyyy-MM-dd");
            string receiveDate = dateReceive.Value.ToString("yyyy-MM-dd");
            string payCost = cost.Text;
            bool payLater = false;
            if (paymentLater.Checked)
            {
                payLater = true;
                payCost = cost.Text;
            }
            Console.WriteLine(payLater);

            try
            {
                if (!_editMode)
                {
                    string msng = "";
                    if (!msngAuto)
                        msng = messangersBox.Text;
                    else
                        msng = messangersBox.Text;
                    DB.insertDataToMessage(msng, recipientName.Text, recipientSurname.Text, address.Text, city.Text, size.SelectedIndex, status.SelectedIndex, priority.Checked, payLater, Int32.Parse(payCost), sendDate, receiveDate);
                }

                else
                {
                    DB.editDataInMessage(_id, messangersBox.Text.ToString(), recipientName.Text, recipientSurname.Text, address.Text, city.Text, size.SelectedIndex, status.SelectedIndex, priority.Checked, payLater, Int32.Parse(payCost), sendDate, receiveDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MessageDesign_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.refresh();
        }

        private void messangerWithFewerJobButton_Click(object sender, EventArgs e)
        {
            messangersBox.Text = DB.findTheMostAvailableMessanger();
            msngAuto = true;
        }
    }
}
