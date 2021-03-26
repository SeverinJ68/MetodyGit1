using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime nejstarsi(DateTime prvni, DateTime druhy, DateTime treti)
        {
            TimeSpan prvniVek = DateTime.Today - prvni;
            TimeSpan druhyVek = DateTime.Today - druhy;
            TimeSpan tretiVek = DateTime.Today - treti;
            if(prvniVek > druhyVek && prvniVek > tretiVek)
            {
                return prvni;
            }
            else if(druhyVek > prvniVek && druhyVek > tretiVek)
            {
                return druhy;
            }
            else
            {
                return treti;
            }
        }
        //Metoda Nejstarsi funguje spravne
        private DateTime nejmladsi(DateTime prvni, DateTime druhy, DateTime treti)
        {
            TimeSpan prvniVek = DateTime.Today - prvni;
            TimeSpan druhyVek = DateTime.Today - druhy;
            TimeSpan tretiVek = DateTime.Today - treti;
            if (prvniVek < druhyVek && prvniVek < tretiVek)
            {
                return prvni;
            }
            else if (druhyVek < prvniVek && druhyVek < tretiVek)
            {
                return druhy;
            }
            else
            {
                return treti;
            }
        }
        //Metoda nejmladsi vyhleda nejmladsiho cloveka a vypise do messageboxu
        //Metoda nejmladsi pekne doplnuje program a funguje
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime prvni = DateTime.Parse(textBox1.Text);
            DateTime druhy = DateTime.Parse(textBox2.Text);
            DateTime treti = DateTime.Parse(textBox3.Text);
            MessageBox.Show("Nejstarsi datum je " + nejstarsi(prvni, druhy, treti).ToShortDateString()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime prvni = DateTime.Parse(textBox1.Text);
            DateTime druhy = DateTime.Parse(textBox2.Text);
            DateTime treti = DateTime.Parse(textBox3.Text);
            MessageBox.Show("Nejmladsi datum je " + nejmladsi(prvni, druhy, treti).ToShortDateString());
        }
    }
}
