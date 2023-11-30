using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FamilienPlaner3DaysProject
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        List<Planer> plaene = new List<Planer>();
        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            Datenbank.Open();
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "SELECT id, name, ueberschrift, notizen, endDate, wichtigkeit FROM Planungen;";
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt16(0);
                string name = reader.GetString(1);
                string ueberschrift = reader.GetString(2);
                string notizen = reader.GetString(3);
                DateTime endDate = reader.GetDateTime(4);
                string wichtigkeit = reader.GetString(5);

                Planer p = new Planer(id, name, ueberschrift, notizen, endDate, wichtigkeit);
                plaene.Add(p);
                listBoxToDo.Items.Add(p.ToString());
            }
            reader.Close();

            Datenbank.Close();

        }
        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if(name.Length == 0)
            {
                textBoxName.Focus();
                return;
            }
            string ueberschrift = textBoxUeberschrift.Text;
            if(ueberschrift.Length == 0)
            {
                textBoxUeberschrift.Focus();
                return;
            }
            string notizen = textBoxNotizen.Text;
            if(notizen.Length == 0)
            {
                textBoxNotizen.Focus();
                return;
            }
            DateTime endDate = dateTimePickerEndDatum.Value;
            if (endDate < DateTime.Today)
            {
                MessageBox.Show("Bitte ein Gültiges Datum angeben");
                dateTimePickerEndDatum.Focus();
                return;
            }
            string wichtigkeit = comboBoxWichtigkeit.SelectedItem as string;
            if(wichtigkeit == null || wichtigkeit.Length == 0)
            {
                comboBoxWichtigkeit.Focus();
                return;
            }
            if (planInBearbeitung == null)
            {
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "INSERT INTO planungen (id, name, ueberschrift, endDate, wichtigkeit, notizen) VALUES (NULL, @name, @ueberschrift, @endDate, @wichtigkeit, @notizen)";
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("ueberschrift", ueberschrift);
                command.Parameters.AddWithValue("endDate", endDate);
                command.Parameters.AddWithValue("wichtigkeit", wichtigkeit);
                command.Parameters.AddWithValue("notizen", notizen);
                command.ExecuteNonQuery();
                int id = (int)command.LastInsertedId;
                Datenbank.Close();

                Planer p = new Planer(id, name, ueberschrift, notizen, endDate, wichtigkeit);
                plaene.Add(p);
                listBoxToDo.Items.Add(p.ToString());
            }
            else
            {
                
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "UPDATE planungen SET name = @name, ueberschrift = @ueberschrift, endDate = @endDate, wichtigkeit = @wichtigkeit, notizen = @notizen WHERE planungen.id = @id";
                command.Parameters.AddWithValue("id", planInBearbeitung.id);
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("ueberschrift", ueberschrift);
                command.Parameters.AddWithValue("endDate", endDate);
                command.Parameters.AddWithValue("wichtigkeit", wichtigkeit);
                command.Parameters.AddWithValue("notizen", notizen);
                command.ExecuteNonQuery();
                
                /*
                int index = listBoxToDo.SelectedIndex;
                if (index < 0 || index >= plaene.Count)
                {
                    listBoxToDo.Focus();
                    return;
                }
                Planer p = plaene[index];

                Datenbank.Open();
                int zuAendernId = p.id;
                string neuerName = textBoxName.Text;
                string neueUeberschrift = textBoxUeberschrift.Text;
                string neueNotizen = textBoxNotizen.Text;
                DateTime neuesEndDate = dateTimePickerEndDatum.Value;
                string neueWichtigkeit = comboBoxWichtigkeit.Text;
                MySqlCommand cmd = Datenbank.CreateCommand();
                cmd.CommandText = "UPDATE planungen SET name = @name, ueberschrift = @ueberschrift, endDate = @endDate, wichtigkeit = @wichtigkeit, notizen = @notizen WHERE planungen.id = @id";
                cmd.Parameters.AddWithValue("name", neuerName);
                cmd.Parameters.AddWithValue("ueberschrift", neueUeberschrift);
                cmd.Parameters.AddWithValue("endDate", neuesEndDate);
                cmd.Parameters.AddWithValue("wichtigkeit", neueWichtigkeit);
                cmd.Parameters.AddWithValue("notizen", neueNotizen);
                */

                Datenbank.Close();

                planInBearbeitung.name = name;
                planInBearbeitung.ueberschrift = ueberschrift;
                planInBearbeitung.endDate = endDate;
                planInBearbeitung.wichtigkeit = wichtigkeit;
                planInBearbeitung.notizen = notizen;

                listBoxToDo.Items[indexInBearbeitung] = planInBearbeitung.ToString();

                indexInBearbeitung = -1;
                planInBearbeitung = null;
                buttonSpeichern.Text = "Hinzufügen";
            }

            textBoxName.Text = "";
            textBoxUeberschrift.Text = "";
            dateTimePickerEndDatum.Value = DateTime.Now;
            textBoxNotizen.Text = "";
            comboBoxWichtigkeit.SelectedItem = null;
        }

        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            int index = listBoxToDo.SelectedIndex;
            if (index < 0 || index >= plaene.Count)
            {
                listBoxToDo.Focus();
                return;
            }
            Planer p = plaene[index];

            Datenbank.Open();
            //int zuLoeschenId = listBoxToDo.SelectedIndex-1;
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "delete from planungen where id=" + p.id;
            cmd.ExecuteNonQuery();

            Datenbank.Close();

            listBoxToDo.Items.RemoveAt(index);

            plaene.RemoveAt(index);

            /*
            int index = listBoxToDo.SelectedIndex;
            if(index < 0 || index >= plaene.Count)
            {
                return;
            }
            Planer p = plaene[index];
            DialogResult res = MessageBox.Show(p + "Wirklich löschen?", "Sicher sicher?", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                plaene.RemoveAt(index);
                listBoxToDo.Items.RemoveAt(index);
            }
            */

        }

        private void buttonExportieren_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(new FileStream("Planungen.csv", FileMode.Create, FileAccess.Write), new UTF8Encoding());
                foreach(Planer p in plaene)
                {
                    writer.WriteLine(p.wichtigkeit + ";" + p.name + ";" + p.ueberschrift + ";" + p.endDate.ToString("yyyy-MM-dd") +";"+ p.notizen);
                }
                // foreach ersetzt == writer.WriteLine("Hier das, was zu schreiben ist");
                writer.Close();
                MessageBox.Show("Gespeichert!");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Konnte die Datei nicht schreiben: " + ex.Message);
            }
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            int index = listBoxToDo.SelectedIndex;
            if (index < 0 || index >= plaene.Count)
            {
                listBoxToDo.Focus();
                return;
            }
            Planer p = plaene[index];

            Datenbank.Open();
            int zuAendernId = p.id;
            string neuerName = textBoxName.Text;
            string neueUeberschrift = textBoxUeberschrift.Text;
            string neueNotizen = textBoxNotizen.Text;
            DateTime neuesEndDate = dateTimePickerEndDatum.Value;
            string neueWichtigkeit = comboBoxWichtigkeit.Text;
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "UPDATE planungen SET name = @name, ueberschrift = @ueberschrift, endDate = @endDate, wichtigkeit = @wichtigkeit, notizen = @notizen WHERE planungen.id = @id";
            cmd.Parameters.AddWithValue("name", neuerName);
            cmd.Parameters.AddWithValue("ueberschrift", neueUeberschrift);
            cmd.Parameters.AddWithValue("endDate", neuesEndDate);
            cmd.Parameters.AddWithValue("wichtigkeit", neueWichtigkeit);
            cmd.Parameters.AddWithValue("notizen", neueNotizen);
            /*
            cmd.CommandText = "update planungen set bezeichnung=@bezeichnung"
                     + ",preis=@preis"
                     + " where id=@id";
            cmd.Parameters.AddWithValue("bezeichnung", neuerName);
            cmd.Parameters.AddWithValue("preis", neueUeberschrift);
            cmd.Parameters.AddWithValue("preis", neueNotizen);
            cmd.Parameters.AddWithValue("id", zuAendernId);
            */
            //cmd.Prepare();
            //cmd.ExecuteNonQuery();

            Datenbank.Close();
        }

        int indexInBearbeitung = -1;
        Planer planInBearbeitung = null;
        private void listBoxToDo_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxToDo.SelectedIndex;
            if(index < 0 || index >= plaene.Count)
            {
                //Nichts markiert
                return;
            }
            Planer p = plaene[index];
            indexInBearbeitung = index;
            planInBearbeitung = p;
            textBoxName.Text = p.name;
            //NumericUpDownLaenge.Value = p.laenge;
            //NumericUpDownWassermenge
            textBoxUeberschrift.Text = p.ueberschrift;
            dateTimePickerEndDatum.Value = DateTime.Now;
            //comboBoxWichtigkeit.Items;
            //comboBoxWichtigkeit.SelectedIndex = p.wichtigkeit.SelectedIndex();
            textBoxNotizen.Text = p.notizen;
            buttonSpeichern.Text = "Speichern";
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            indexInBearbeitung = -1;
            planInBearbeitung = null;
            buttonSpeichern.Text = "Speichern";
            textBoxName.Text = "";
            //NumericUpDownLaenge.Value = p.laenge;
            //NumericUpDownWassermenge
            textBoxUeberschrift.Text = "";
            dateTimePickerEndDatum.Value = DateTime.Now;
            //comboBoxWichtigkeit.Items;
            textBoxNotizen.Text = "";
        }
    }
}
