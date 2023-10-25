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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader precti = new StreamReader("hra.txt");

            while (!precti.EndOfStream)
            {
                Form formik = new Form();                  
                string jmeno = precti.ReadLine();
                string cas = precti.ReadLine();
                formik.Text = jmeno + " " + cas;
                formik.Show();
            }
            precti.Close();
        }
    }
}
