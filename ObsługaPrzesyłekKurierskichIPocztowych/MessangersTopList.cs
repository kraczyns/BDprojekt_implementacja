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
    public partial class MessangersTopList : Form
    {
        public MessangersTopList()
        {
            InitializeComponent();
            DB.showTheBestMessangers(messangersTopListTable);
        }

        DatabaseAdministration DB = new DatabaseAdministration();

    }
}
