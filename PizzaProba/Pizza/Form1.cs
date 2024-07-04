using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizza
{
    public partial class Form1 : Form
    {

        //konstruktor
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private int meretKicsi = 32, meretNagy = 45;
        private List<Pizza> pizzak = new List<Pizza>();




        

        class Pizza
        {
            public string Nev { get; private set; }
            public int ArKicsi { get; set; }
            public int ArNagy { get; set; }

            public Pizza(string nev, int arkicsi, int arNagy)
            {
                this.Nev = nev;
                this.ArKicsi = arkicsi;
                this.ArNagy = arNagy;
            }

            public override string ToString()
            {
                return this.Nev;
            }
        }

       

        private void Adatbevitel()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    AdatBeolvasas(fajlNev);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }
        
        private void AdatBeolvasas(string fajlNev)
        {
            string adat;
            StreamReader olvasoCsatorna = new StreamReader(fajlNev);

            while (!olvasoCsatorna.EndOfStream)
            {
                adat = olvasoCsatorna.ReadLine();
                Feldolgoz(adat);
            }
            olvasoCsatorna.Close();

        }
        
        private void AdatBevitel()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader olvasoCsatorna = null;
                try
                {
                    String fajlNev = openFileDialog1.FileName;
                    olvasoCsatorna = new StreamReader(fajlNev);
                    AdatBeolvasas(olvasoCsatorna);
                }
                catch (Exception e) {
                    MessageBox.Show("Adatbeviteli hiba", "Hiba");
                }
                finally
                {
                    if( olvasoCsatorna != null)
                    {
                        olvasoCsatorna.Close();
                    }
                }
            }
        }

        private void AdatBeolvasas(StreamReader olvasoCsatorna)
        {
            string adat;

            while (!olvasoCsatorna.EndOfStream)
            {
                adat = olvasoCsatorna.ReadLine();
                Feldolgoz(adat);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LathatosagBeallitasa(false);
        }

        private void LathatosagBeallitasa(bool lathatoE) {
        foreach(Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
        btnAdatBe.Visible = !lathatoE;
        }

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            pizzak.Add(new Pizza(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2])));


        }

        private void ElemekMegjelenitese()
        {
            lblKicsi.Text = meretKicsi + " cm";
            lblNagy.Text = meretNagy + " cm";

            checkBox1.Text = pizzak[0].Nev;
            rdBtn1Kicsi.Text = pizzak[0].ArKicsi + " Ft";
            rdBtn1Nagy.Text = pizzak[0].ArNagy + " Ft";

            checkBox2.Text = pizzak[1].Nev;
            rdBtn2Kicsi.Text = pizzak[1].ArKicsi + " Ft";
            rdBtn2Nagy.Text = pizzak[1].ArNagy + " Ft";

        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                int osszeg = 0, ar = 0, db = 0;
                if (checkBox1.Checked)
                {
                    if (rdBtn1Kicsi.Checked) ar = pizzak[0].ArKicsi;
                    else if (rdBtn1Nagy.Checked) ar = pizzak[0].ArNagy;
                    else throw new MissingFieldException("Válasszon méretet");

                    db = int.Parse(txtDb1.Text);

                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;

                }
                if (checkBox2.Checked)
                {
                    if (rdBtn2Kicsi.Checked) ar = pizzak[1].ArKicsi;
                    else if (rdBtn2Nagy.Checked) ar = pizzak[1].ArNagy;
                    else throw new MissingFieldException("Válasszon méretet");
                    db = int.Parse(txtDb2.Text);
                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;
                    
                }
                if (!checkBox1.Checked && !checkBox2.Checked) throw new MissingFieldException();
                txtFizetendo.Text = osszeg + " Ft";

            }
            catch(FormatException) {
                MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");
            }
            catch (ArgumentOutOfRangeException aox)
            {
                MessageBox.Show(aox.Message, "Hiba");
            }
            catch(MissingFieldException mex)
            {
                MessageBox.Show(mex.Message,  "Hiba");
            }
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            try
            {
                Adatbevitel();
                ElemekMegjelenitese();
                LathatosagBeallitasa(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox) (item as CheckBox).Checked = false;
                if (item is TextBox) ((TextBox)item).Clear();
                if (item.HasChildren)
                {
                    foreach (Control gyerek in item.Controls)
                    {
                        if (gyerek is RadioButton) (gyerek as RadioButton).Checked = false;
                    }
                }
            }
        
        }
        

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
