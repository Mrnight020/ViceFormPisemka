using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PisemkaViceForm
{
    public partial class Konec : Form
    {
        public Konec()
        {
            InitializeComponent();
        }
        bool ano = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.DialogResult = DialogResult.Cancel;
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            if (ano == false)
            {
                button1.Location = new Point(rnd.Next(10,100), rnd.Next(10,100));
                ano = true;
            }
            
        }
    }
}
