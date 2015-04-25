using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace HomeworkI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
                MessageBox.Show("This is not a digit");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        System.Globalization.CultureInfo french = new System.Globalization.CultureInfo("fr");
        System.Globalization.CultureInfo english = new System.Globalization.CultureInfo("en");
        System.Globalization.CultureInfo deutch = new System.Globalization.CultureInfo("de");
        System.Globalization.CultureInfo spanish = new System.Globalization.CultureInfo("es");

        private void button1_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura;
            int Traducere = 0;
            Int32.TryParse(textBox1.Text, out Traducere);
            switch (comboBox1.Text)
            {
                case "English": cultura = english; break;
                case "French": cultura = french; break;
                case "Deutch": cultura = deutch; break;
                case "Spanish": cultura = spanish; break;
                default: cultura = english; break;
            }
            string Rezultat = Traducere.ToWords(cultura);
            MessageBox.Show(Rezultat);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
