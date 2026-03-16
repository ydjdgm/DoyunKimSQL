using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DoyunKimSQL
{
    internal class Model : IModel
    {
        public IView View { get; set; }
        public IController Controller { get; set; }

        static string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=projektwoche2026;";
        MySqlConnection conn = new MySqlConnection(myConnectionString);
        MySqlCommand mycommand = new MySqlCommand();

        public Model()
        {
            mycommand.Connection = conn;
        }

        public List<Klasse> GetKlasse()
        {
            try
            {
                conn.Open();
                List<Klasse> klassen = new List<Klasse>();
                mycommand.CommandText = "SELECT * FROM klasse;";
                MySqlDataReader reader = mycommand.ExecuteReader();
                while (reader.Read())
                {
                    Klasse klasse = new Klasse();
                    klasse.KlasseID = Int32.Parse(reader["KlasseID"].ToString());
                    klasse.Bezeichnung = reader["Bezeichnung"].ToString();
                    klassen.Add(klasse);
                }
                conn.Close();
                return klassen;
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return new List<Klasse>();
            }
        }
        public List<Schueler> GetSchueler()
        {
            try
            {
                conn.Open();
                List<Schueler> schueler = new List<Schueler>();
                mycommand.CommandText = "SELECT * FROM schueler;";
                while (mycommand.ExecuteReader().Read())
                {
                    Schueler schueler1 = new Schueler();
                    schueler1.SchuelerID = mycommand.ExecuteReader().GetInt32(0);
                    schueler1.Vorname = mycommand.ExecuteReader().GetString(1);
                    schueler1.Nachname = mycommand.ExecuteReader().GetString(2);
                    schueler1.Email = mycommand.ExecuteReader().GetString(3);
                    schueler1.KlasseID = mycommand.ExecuteReader().GetInt32(4);
                    schueler.Add(schueler1);
                }
                conn.Close();
                return schueler;
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return new List<Schueler>();
            }
        }
        public List<Workshop> GetWorkshop()
        {
            try
            {
                conn.Open();
                List<Workshop> workshops = new List<Workshop>();
                mycommand.CommandText = "SELECT * FROM workshop;";
                while (mycommand.ExecuteReader().Read())
                {
                    Workshop workshop = new Workshop();
                    workshop.WorkshopID = mycommand.ExecuteReader().GetInt32(0);
                    workshop.Nr = mycommand.ExecuteReader().GetInt32(1);
                    workshop.Titel = mycommand.ExecuteReader().GetString(2);
                    workshop.Kosten = mycommand.ExecuteReader().GetDecimal(3);
                    workshop.Beschreibung = mycommand.ExecuteReader().GetString(4);
                    workshop.Voraussetzungen = mycommand.ExecuteReader().GetString(5);
                    workshop.TeilnehmerMin = mycommand.ExecuteReader().GetInt32(6);
                    workshop.TeilnehmerMax = mycommand.ExecuteReader().GetInt32(7);
                    workshop.Schwerpunkt = mycommand.ExecuteReader().GetString(8);
                    workshops.Add(workshop);
                }
                return workshops;
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return new List<Workshop>();
            }


        }
    }
}
