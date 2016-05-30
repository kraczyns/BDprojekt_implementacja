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
    public partial class MessengerDesign : Form
    {

        private bool _editMode = false;
        private bool msngAuto = false;
        private int _id;
        DatabaseAdministration DB = new DatabaseAdministration();

        public MessengerDesign()
        {
           InitializeComponent();
            DB.fillComboBoxWithPlaces(placowkaBox);
        }

        public MessengerDesign(int id, string name, string surname,string city_name)
        {
            _editMode = true;
            _id = id;
            InitializeComponent();

            nazwiskoBox.Text = surname;
            imieBox.Text = name;
            placowkaBox.Text = city_name;

            DB.fillComboBoxWithPlaces(placowkaBox);
        }

        private void MessengerDesign_Load(object sender, EventArgs e)
        {

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_editMode)
                {
                    DB.insertDataToMessanger(imieBox.Text, nazwiskoBox.Text, placowkaBox.Text);
                }

                else
                {
                    DB.editDataInMessanger(_id, imieBox.Text, nazwiskoBox.Text, placowkaBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
