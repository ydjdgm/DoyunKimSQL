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
                    klasse.Bezeichnung = reader["bezeichnung"].ToString();
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
                MySqlDataReader reader = mycommand.ExecuteReader();
                while (reader.Read())
                {
                    Schueler schueler1 = new Schueler();
                    schueler1.SchuelerID = Int32.Parse(reader["schuelerID"].ToString());
                    schueler1.Vorname = reader["vorname"].ToString();
                    schueler1.Nachname = reader["nachname"].ToString();
                    schueler1.Email = reader["Email"].ToString();
                    schueler1.KlasseID = Int32.Parse(reader["klasseID"].ToString());
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
                MySqlDataReader reader = mycommand.ExecuteReader();
                while (reader.Read())
                {
                    Workshop workshop = new Workshop();
                    workshop.WorkshopID = Int32.Parse(reader["workshopID"].ToString());
                    workshop.Nr = Int32.Parse(reader["nr"].ToString());
                    workshop.Titel = reader["titel"].ToString();
                    workshop.Kosten = Int32.Parse(reader["kosten"].ToString());
                    workshop.Beschreibung = reader["beschreibung"].ToString();
                    workshop.Voraussetzungen = reader["voraussetzungen"].ToString();
                    workshop.TeilnehmerMin = Int32.Parse(reader["teilnehmerMin"].ToString());
                    workshop.TeilnehmerMax = Int32.Parse(reader["teilnehmerMax"].ToString());
                    workshop.Schwerpunkt = reader["schwerpunkt"].ToString();
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
