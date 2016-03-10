using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmistoprojekti.Model
{
    public class Joukkueet
    {
        // muuttujia
        private string joukkueNimi;
        private int joukkuePisteet;
        private int joukkueID;


        public Joukkueet()
        {

        }


        public string JoukkueNimi
        {
            // hakee ja palauttaa joukkueNimi
            get
            {
                return this.joukkueNimi;
            }
            // asettaa joukkueNimi
            set
            {
                joukkueNimi = value;
            }
        }


        public int JoukkuePisteet
        {
            // hakee ja palauttaa joukkuePisteet
            get
            {
                return this.joukkuePisteet;
            }
            // asettaa joukkuePisteet
            set
            {
                joukkuePisteet = value;
            }
        }

        public int JoukkueID
        {
            // hakee ja palauttaa joukkueID
            get
            {
                return this.joukkueID;
            }
            // asettaa joukkueID
            set
            {
                joukkueID = value;
            }
        }


    }
}
