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
    public partial class OdbiorcaDesign : Form
    {

        private bool _editMode = false;
        private bool msngAuto = false;
        private int _id;
        DatabaseAdministration DB = new DatabaseAdministration();

        public OdbiorcaDesign()
        {
            InitializeComponent();
        }
         public OdbiorcaDesign(int id, string name, string surname)
        {
            _editMode = true;
            _id = id;
            InitializeComponent();

            nazwiskoBox.Text = surname;
            imieBox.Text = name;

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_editMode)
                {
                    DB.insertDataToOdbiorca(imieBox.Text, nazwiskoBox.Text);
                }

                else
                {
                    DB.editDataInOdbiorca(_id, imieBox.Text, nazwiskoBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
