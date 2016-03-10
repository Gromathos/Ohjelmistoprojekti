using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohjelmistoprojekti.Model;
using Ohjelmistoprojekti.View;
using System.Collections;

namespace Ohjelmistoprojekti.Controller
{
    public class Rekisteri
    {

        public Rekisteri()
        {

            tietokanta = new Tietokantahallinta();
            kayttoliittyma = new Kayttoliittyma();

        }

        public void aloitus()
        {
            kayttoliittyma.naytaKayttoliittyma();
        }


        Tietokantahallinta tietokanta;
        Kayttoliittyma kayttoliittyma;


        public ArrayList haetaanTietoja(int maara)
        {
            return tietokanta.haeTietoja(maara);
        }

        public void lisataanTietoja(string joukkuenimi, int joukkuepisteet)
        {
            bool onnistui = tietokanta.lisaaJoukkue(joukkuenimi, joukkuepisteet);
            kayttoliittyma.tulostaOnnistuikoLisays(onnistui);
        }

        public void poistetaanTietoja(string joukkuenimi)
        {
            bool onnistui = tietokanta.poistaJoukkue(joukkuenimi);
            kayttoliittyma.tulostaOnnistuikoPoisto(onnistui);
        }

        public void paivitetaanTietoja(string joukkuenimi, int joukkuepisteet, string vanhajoukkue)
        {
            bool onnistui = tietokanta.paivitaJoukkue(joukkuenimi, joukkuepisteet, vanhajoukkue);
            kayttoliittyma.tulostaOnnistuikoPaivitys(onnistui);
        }

    }
}
