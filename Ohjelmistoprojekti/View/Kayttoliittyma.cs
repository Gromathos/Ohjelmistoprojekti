using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ohjelmistoprojekti.Controller;

namespace Ohjelmistoprojekti.View
{
    public class Kayttoliittyma
    {

        public Kayttoliittyma()
        {
            
        }

        public void naytaKayttoliittyma()
        {
            Form kayttis = new Kayttis();
            Application.Run(kayttis);
        }


        public void tulostaOnnistuikoPoisto(bool onnistui)
        {
            if (onnistui)
            {
                MessageBox.Show("Tietojen poisto onnistui tietokannasta", "Poisto", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tietojen poisto epäonnistui tietokannasta", "Poisto", MessageBoxButtons.OK);
            }
        }

        public void tulostaOnnistuikoLisays(bool onnistui)
        {
            if (onnistui)
            {
                MessageBox.Show("Tietojen lisäys onnistui tietokantaan", "Lisäys", MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("Tietojen lisäys ei onnistunut tietokantaan", "Lisäys", MessageBoxButtons.OK);
            }
        }



        public void tulostaOnnistuikoPaivitys(bool onnistui)
        {
            if (onnistui)
            {
                MessageBox.Show("Tietojen päivitys onnistui tietokantaan", "Päivitys", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Tietojen päivitys ei onnistunut tietokantaan", "Päivitys", MessageBoxButtons.OK);
            }
        }
    }
}
