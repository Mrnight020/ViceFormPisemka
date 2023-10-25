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

namespace PisemkaViceForm
{
    public partial class Form1 : Form
    {
        FontDialog font1;
        ColorDialog colordialog;
        bool fullstream;
        public Form1()
        {
            InitializeComponent();
            /*StreamReader precti = new StreamReader("settings.txt");

            precti.Close();*/
        }


        private void button1_Click(object sender, EventArgs e) // nova hra
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // načíst hru
        {
            Form4 form4 = new Form4();
            form4.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)// nastavení
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)// ukončit hru
        {
            this.Hide();
            Konec konec = new Konec();
            konec.ShowDialog();
        }
    }
}
