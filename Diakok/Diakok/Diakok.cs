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

namespace Diakok
{
    public partial class Diakok : Form
    {
        List<Diak> diakok = new List<Diak>();
        List<CheckBox> chkBoxok = new List<CheckBox>();

        private int kezdoX = 10;
        private int kezdoY = 10;
        private int chkYKoz = 30;
        public Diakok()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }
        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
            btnKivalaszt.Enabled = aktiv;
        }
        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    Adatbeolvasas(fajlNev);
                    FelrakDiakok();
                    GombBeallitas(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor!", "Hiba");
                }
            }
        }
        private void Adatbeolvasas(string fajlNev)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fajlNev);

                while (!sr.EndOfStream)
                {
                    string adat = sr.ReadLine();
                    Feldolgoz(adat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');

            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
        }

        private void FelrakDiakok()
        {
            CheckBox chkBox;

            for (int i = 0; i < diakok.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdoX, kezdoY + i * chkYKoz);
                chkBox.Text = diakok[i].ToString();

                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            Adatbevitel();
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }
        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }
            if (!vanValasztott)
            {            
                MessageBox.Show("Senkit sem választott", "Hiba");
            }
            else
            {
                MinKeres();
            }
        }

        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            int min = (lstKivalasztottak.Items[0] as Diak).Szuletesi_ev;
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.Szuletesi_ev < min) min = diak.Szuletesi_ev ;
            }
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.Szuletesi_ev == min) lstLegidosebbek.Items.Add(diak);
            }
        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstKivalasztottak.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.Szuletesi_ev;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Diak
    {
        public string Nev;
        public string Tanulmanyi_kod;
        public int Szuletesi_ev;

        public Diak(string nev, string tanulmanyi_kod, int szuletesi_ev)
        {
            this.Nev = nev;
            this.Tanulmanyi_kod = tanulmanyi_kod;
            this.Szuletesi_ev = szuletesi_ev;
        }

        public override string ToString()
        {
            return $"{this.Nev} ({ this.Tanulmanyi_kod})";
        }
    }
}
