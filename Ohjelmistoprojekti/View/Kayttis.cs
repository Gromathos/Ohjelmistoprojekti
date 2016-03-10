using Ohjelmistoprojekti.Controller;
using Ohjelmistoprojekti.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmistoprojekti.View
{
    public partial class Kayttis : Form
    {

        Rekisteri kayttisRekisteri;
        Tietokantahallinta kayttisTietokanta;
        
        public Kayttis()
        {
            InitializeComponent();
            // luokkien määrittäminen
            kayttisRekisteri = new Rekisteri();
            piilotaKaikki();
            haeKaikki();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                // joukkueiden haku tietokannasta ja tietojen lisääminen listboxeihin
                int maara = int.Parse(textBox1.Text);

                ArrayList joukkueita = kayttisRekisteri.haetaanTietoja(maara);

                this.listBox1.DisplayMember = "JoukkueNimi";
                this.listBox1.ValueMember = "Id";
                this.listBox2.DisplayMember = "JoukkuePisteet";
                this.listBox2.ValueMember = "Id";


                foreach (Model.Joukkueet otetaanYksi in joukkueita)
                {

                    listBox1.Items.Add(otetaanYksi);
                    listBox2.Items.Add(otetaanYksi);
                }
            }
            catch
            {
                haeKaikki();
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                // joukkueen lisääminen tietokantaan
                string joukkuenimi = textBox2.Text;
                int joukkuepisteet = int.Parse(textBox3.Text);

                kayttisRekisteri.lisataanTietoja(joukkuenimi, joukkuepisteet);

                haeKaikki();
            }
            catch
            {

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // joukkueen poisto
            try
            {
                string joukkuenimi = textBox4.Text;
                kayttisRekisteri.poistetaanTietoja(joukkuenimi);

                haeKaikki();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Joukkueet valittuJoukkue = (Model.Joukkueet)this.listBox1.SelectedItem;

                // paivita haetiedot
                label9.Text = valittuJoukkue.JoukkueNimi;
                label10.Text = valittuJoukkue.JoukkuePisteet.ToString();
            }
            catch
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string vanhajoukkue = label9.Text;
                string joukkuenimi = textBox5.Text;
                int joukkuepisteet = int.Parse(textBox6.Text);

                kayttisRekisteri.paivitetaanTietoja(joukkuenimi, joukkuepisteet, vanhajoukkue);

                haeKaikki();
            }
            catch
            {

            }
        }

        /*
         * Valikko
         * */
                private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ohjelmistoprojekti on tehty Jyväskylän ammattiopistossa toteutusprojektia varten. \n Tekijä: Samuli Virtapohja", "Info", MessageBoxButtons.OK);
        }

        private void valikkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            piilotaKaikki();
            groupBox2.Location = new Point(68, 56);
            groupBox2.Visible = true;
        }

        private void lisäysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            piilotaKaikki();
            groupBox3.Location = new Point(68, 56);
            groupBox3.Visible = true;
        }

        private void poistoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            piilotaKaikki();
            groupBox4.Visible = true;
            groupBox4.Location = new Point(68, 56);
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void päivitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            piilotaKaikki();
           
            groupBox5.Location = new Point(68, 56);
            groupBox5.Visible = true;

        }

        private void lisenssiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lisenssi = new Lisenssi();
            lisenssi.Show();
        }
/*
 * Yleisiä metodeita, joita kutsutaan
 */ 

        // piilottaa haun, poiston ja lisäyksen
        private void piilotaKaikki()
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        // hakee kaikki joukkueet tietokannasta ja tulostaa ne
        private void haeKaikki(){

                listBox1.Items.Clear();
                listBox2.Items.Clear();    


                ArrayList joukkueita = kayttisRekisteri.haetaanTietoja(0);

                this.listBox1.DisplayMember = "JoukkueNimi";
                this.listBox1.ValueMember = "Id";
                this.listBox2.DisplayMember = "JoukkuePisteet";
                this.listBox2.ValueMember = "Id";


                foreach (Model.Joukkueet otetaanYksi in joukkueita)
                {

                    listBox1.Items.Add(otetaanYksi);
                    listBox2.Items.Add(otetaanYksi);
                }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }





    }
}
