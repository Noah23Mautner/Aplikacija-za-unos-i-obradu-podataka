using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacija_za_unos_i_obradu_podataka
{
    public partial class Form1 : Form



    {


        List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Avion");
            comboBox1.Items.Add("Automobil");
            comboBox1.Items.Add("Brod");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";

            foreach (Vozilo vozilo in vozila)
            {
                message += $"Marka: {vozilo.Marka}, Model: {vozilo.Model}, " +
                    $"Vrsta: {vozilo.Vrsta}, Vozi po: {vozilo.VoziPo}";
            }
            richTextBox1.Text = message;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupid_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string vrsta = comboBox1.SelectedItem.ToString();

            Vozilo novoVozilo = new Vozilo(marka, model, vrsta);
            vozila.Add(novoVozilo);

            foreach (Vozilo vozilo in vozila)
            {
                if (vozilo.Vrsta == "Avion")
                {
                    vozilo.VoziPo = "Zrak";
                }
                else if (vozilo.Vrsta == "Automobil")
                {
                    vozilo.VoziPo = "Cesta";
                }
                else if (vozilo.Vrsta == "Brod")
                {
                    vozilo.VoziPo = "Voda";
                }
            }
        }

        public class Vozilo
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Vrsta { get; set; }
            public string VoziPo { get; set; }

            public Vozilo(string marka, string model, string vrsta)
            {
                Marka = marka;
                Model = model;
                Vrsta = vrsta;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
