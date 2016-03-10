using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohjelmistoprojekti.Model;
using System.Windows.Forms;

namespace Ohjelmistoprojekti.Model
{
    public class Tietokantahallinta
    {

        MySqlConnection yhteys;

        public Tietokantahallinta()
        {

            //määritellään yhteys
            yhteys = new MySqlConnection("Server=localhost;Database=ohjelmistoprojekti;Uid=root;Pwd=;");

        }


        // select * from
        public ArrayList haeTietoja(int maara)
        {

            ArrayList tietoja = new ArrayList();

            try
            {
                // MySQL yhteys tietokantaan avataan
                yhteys.Open();

                // luodaan MySQL komento
                MySqlCommand komento = yhteys.CreateCommand();

                if (maara == 0)
                {
                    // sql komento
                    komento.CommandText = "Select * From Joukkueet";
                }
                else
                {
                    // sql komento
                    komento.CommandText = "Select * From Joukkueet Limit @maara";
                }

                
                komento.Parameters.Add("@maara", maara);




                // valmistellaan tietojen palautusta
                MySqlDataAdapter tietoadapteri = new MySqlDataAdapter(komento);

                // tietojoukko olio johon tiedot tallennetaan tietokannalta
                DataSet tietojoukko = new DataSet();

                // lisätään tietojoukkoon tietokannan Joukkueet-taulukon tiedot
                tietoadapteri.Fill(tietojoukko, "Joukkueet");

                //otetaan taulun tiedot taulukkorakenteeseen
                DataTable taulun_tiedot = tietojoukko.Tables["Joukkueet"]; // sql-haun tauluista valitaan "Joukkueet"

                // käydään läpi Console-tulostuksena
                foreach (DataRow rivi in taulun_tiedot.Rows)
                {
                    // luodaan yksiJoukkue olio
                    Model.Joukkueet yksiJoukkue = new Model.Joukkueet();

                    // otetaan tietokannasta tiedot ja asetetaan ne yksiJoukkue-oliolle
                    yksiJoukkue.JoukkueID = (int)rivi["joukkueID"];
                    yksiJoukkue.JoukkueNimi = (string)rivi["joukkueNimi"];
                    yksiJoukkue.JoukkuePisteet = (int)rivi["joukkuePisteet"];

                    //olio lisätään listaukseen
                    tietoja.Add(yksiJoukkue);

                }

                

            }
            catch (Exception e)
            {
                
            }

            yhteys.Close();
            return tietoja;
        }

        // insert into
        public bool lisaaJoukkue(string joukkuenimi, int joukkuepisteet)
        {
            try
            {
                // MySQL yhteys tietokantaan avataan
                yhteys.Open();

                // luodaan MySQL komento
                MySqlCommand komento = yhteys.CreateCommand();

                // sql komento
                komento.CommandText = "Insert Into Joukkueet (joukkueNimi, joukkuePisteet) Values (@joukkuenimi, @joukkuepisteet)";

                komento.Parameters.Add("@joukkuenimi", joukkuenimi);
                komento.Parameters.Add("@joukkuepisteet", joukkuepisteet);

                // rivien vaikutus
                int kuinkaMoneenRiviinVaikutti = komento.ExecuteNonQuery();

                yhteys.Close();

                if (kuinkaMoneenRiviinVaikutti <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch
            {
                
                return false;
            }
        }


        public bool poistaJoukkue(string joukkuenimi){
            try
            {
                yhteys.Open();

                MySqlCommand komento = yhteys.CreateCommand();

                komento.CommandText = "Delete From Joukkueet Where joukkueNimi=@joukkuenimi";

                komento.Parameters.Add("@joukkuenimi", joukkuenimi);

                int kuinkaMoneenRiviinVaikutti = komento.ExecuteNonQuery();

                yhteys.Close();

                if (kuinkaMoneenRiviinVaikutti <= 0)
                {      
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool paivitaJoukkue(string joukkuenimi, int joukkuepisteet, string vanhajoukkue)
        {
            try
            {
                // avataan yhteys tietokantaan
                yhteys.Open();

                MySqlCommand komento = yhteys.CreateCommand();

                komento.CommandText = "UPDATE joukkueet SET joukkueNimi=@joukkuenimi, joukkuePisteet=@joukkuepisteet WHERE joukkueNimi=@vanhajoukkue";

                komento.Parameters.Add("@joukkuenimi", joukkuenimi);
                komento.Parameters.Add("@vanhajoukkue", vanhajoukkue);
                komento.Parameters.Add("@joukkuepisteet", joukkuepisteet);

                int kuinkaMoneenRiviinVaikutti = komento.ExecuteNonQuery();

                yhteys.Close();

                if (kuinkaMoneenRiviinVaikutti <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch
            {
                yhteys.Close();
                return false;
            }

        }



    }
}
