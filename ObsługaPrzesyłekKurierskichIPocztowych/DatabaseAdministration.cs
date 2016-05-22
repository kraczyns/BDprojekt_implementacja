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
    enum status
    {
        gotowy,
        uKuriera,
        dostarczone
    }

    public class DatabaseAdministration
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public DatabaseAdministration()
        {
            connection = new MySqlConnection("datasource = localhost;port = 3306; Initial Catalog = 'poczta2'; username = root; password=lynch123");
            connection.Open();
        }

        public void showDataFromMessage(DataGridView view)
        {
            string showQuery = "SELECT id_przesylki AS Numer, CONCAT_WS (' ', odbiorca.imie, odbiorca.nazwisko) AS Odbiorca, CONCAT_WS (' ', kurier.imie, kurier.nazwisko) AS Kurier, placowka.adres AS Placówka, rozmiar AS Rozmiar, czy_priorytet AS Priorytet, data_nadania AS DataNadania, data_odbioru AS DataOdbioru, czy_za_pobraniem AS PłatnośćPrzyOdbiorze, należność AS Należność, adres_doreczenia AS AdresDoręczenia, status AS Status FROM przesylka INNER JOIN odbiorca ON przesylka.id_odbiorcy = odbiorca.id_odbiorcy INNER JOIN kurier ON przesylka.id_kuriera = kurier.id_kuriera INNER JOIN placowka ON przesylka.id_placowki_nadania = placowka.id_placowki";
            command = new MySqlCommand(showQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            view.DataSource = table;
        }

        private int addNewRecipientAndGetId(string recipient_name, string recipient_surname)
        {
            string insertQuery = "INSERT INTO odbiorca (imie, nazwisko) VALUES ('" + recipient_name + "', '" + recipient_surname + "')";
            command = new MySqlCommand(insertQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            string searchQuery = "SELECT id_odbiorcy FROM odbiorca WHERE nazwisko = '" + recipient_surname + "' AND imie = '" + recipient_name + "'";
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            int val = (int)command.ExecuteScalar();
            return val;
        }

        private int getIdFromCity(string city)
        {
            string searchQuery = "SELECT id_placowki FROM placowka WHERE adres = '"+city+"'"; 
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            int val = (int)command.ExecuteScalar();
            return val;
        }

        private int getIdFromMessanger(string messanger)
        {
            string[] words = messanger.Split(' ');
            string searchQuery = "SELECT id_kuriera FROM kurier WHERE imie= '" + words[0] + "' AND nazwisko = '" + words[1] + "'";
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            int val = (int)command.ExecuteScalar();
            return val;
        }

        private string getStatusFromNumber(int _status)
        {
            switch (_status)
            {
                case (int)status.gotowy:
                    {
                        return "gotowa";
                    }
                case (int)status.uKuriera:
                    {
                        return "u kuriera";
                    }
                case (int)status.dostarczone:
                    {
                        return "dostarczona";
                    }
            }
            return " ";
        }

        public void deleteDataFromMessage(DataGridView view)
        {
            try
            {
                int value = (int)view.SelectedCells[0].Value;
                string table_name = "przesylka";
                try
                {
                    string searchQuery = "DELETE FROM " + table_name + " WHERE id_przesylki=" + value + ";";
                    command = new MySqlCommand(searchQuery, connection);
                    adapter = new MySqlDataAdapter(command);
                    table = new DataTable();
                    adapter.Fill(table);
                    MessageBox.Show("Usunięto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void fillComboBoxWithMessangers(ComboBox msngComboBox)
        {
            string searchQuery = "SELECT CONCAT_WS (' ', imie, nazwisko) AS name from kurier";
            command = new MySqlCommand(searchQuery, connection);
            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
                msngComboBox.Items.Add(DR[0]);
            }
            DR.Close();
        }

        public void fillComboBoxWithPlaces(ComboBox placesComboBox)
        {
            string searchQuery = "SELECT adres from placowka";
            command = new MySqlCommand(searchQuery, connection);
            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
                placesComboBox.Items.Add(DR[0]);
            }
            DR.Close();
        }

        public void insertDataToMessage(string messanger, string recipient_name, string recipient_surname, string address, string city, int size, int status, bool priority, bool paymentAfter, int cost, string sendDate, string receiveDate)
        {
            int cityId = getIdFromCity(city);
            int recipientId = addNewRecipientAndGetId(recipient_name, recipient_surname);
            int _size = size + 1;
            int msngId = getIdFromMessanger(messanger);
            string _status = getStatusFromNumber(status);
            string searchQuery;
            if (status == 2) // jeżeli przesyłkę dostarczono, istnieje data dostarczenia
            {
                searchQuery = "INSERT INTO przesylka (id_odbiorcy, id_kuriera, id_placowki_nadania, rozmiar, czy_priorytet, data_nadania, data_odbioru, adres_doreczenia, status, należność) VALUES (" + recipientId + ", " + msngId + ", " + cityId + ", " + _size + ", " + priority + ", '" + sendDate + "', '" + receiveDate + "', '" + address + "', '" + _status + "'," + cost + ")";
            }
            else // jeżeli przesyłki niedostarczono, nie ma daty dostarczenia
            {
                searchQuery = "INSERT INTO przesylka (id_odbiorcy, id_kuriera, id_placowki_nadania, rozmiar, czy_priorytet, data_nadania, adres_doreczenia, status, należność) VALUES (" + recipientId + ", " + msngId + ", " + cityId + ", " + _size + ", " + priority + ", '" + sendDate + "', '" + address + "', '" + _status + "'," + cost + ")";
            }
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            MessageBox.Show("Dodano");

        }
        public void editDataInMessage(int id,string messanger, string recipient_name, string recipient_surname, string address, string city, int size, int status, bool priority, bool paymentAfter, int cost, string sendDate, string receiveDate)
        {
            int cityId = getIdFromCity(city);
            int recipientId = addNewRecipientAndGetId(recipient_name, recipient_surname);
            int _size = size + 1;
            int msngId = getIdFromMessanger(messanger);
            string _status = getStatusFromNumber(status);
            string searchQuery;

            if (status == 2) // jeżeli przesyłkę dostarczono, istnieje data dostarczenia
            {
                searchQuery = "UPDATE przesylka SET id_odbiorcy ="+
                    recipientId+", id_kuriera=" +msngId+
                ", id_placowki_nadania="+cityId+", rozmiar="+_size+
                ", czy_priorytet="+priority+", data_nadania='"+sendDate+
                "', data_odbioru='"+receiveDate+"', adres_doreczenia='"+address+
                "', status='"+status+"', należność="+cost+" WHERE id_przesylki="+id+";";
  
            }
            else // jeżeli przesyłki niedostarczono, nie ma daty dostarczenia
            {
                searchQuery = "UPDATE przesylka SET id_odbiorcy =" +
                                   recipientId + ", id_kuriera=" + msngId +
                               ", id_placowki_nadania=" + cityId + ", rozmiar=" + _size +
                               ", czy_priorytet=" + priority + ", data_nadania='" + sendDate +
                               "', adres_doreczenia='" + address +
                               "', status='" + status + "', należność=" + cost + " WHERE id_przesylki=" + id + ";";
            }


            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            MessageBox.Show("Zmieniono");
        }
        public void showData(string _table_name, DataGridView view)
        {
            string searchQuery = "SELECT * FROM `" + _table_name + "`";
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            view.DataSource = table;
        }

        public void insertData(string value, string _table_name)
        {
            string searchQuery = "INSERT INTO `" + _table_name + "` (adres) VALUES ('" + value + "')";
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            MessageBox.Show("Dodano");
        }
    }
}
