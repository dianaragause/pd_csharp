using System;
using System.Windows.Forms;

namespace ieskaites_uzdevums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Sākt aptauju.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 jautajumi = new Form2();
            jautajumi.Show();
        }
    }
}
