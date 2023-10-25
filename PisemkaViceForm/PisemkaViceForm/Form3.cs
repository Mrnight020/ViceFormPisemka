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
    public partial class Form3 : Form
    {
        public FontDialog font1;
        public ColorDialog colordialog;
        public bool fullstream;
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter zapis = new StreamWriter("settings.txt");
            if (checkBox1.Checked)
            {
                fullstream = true;
            }else fullstream = false;

            if(colordialog != null)
            {
                zapis.WriteLine(colordialog.Color.ToString());
                this.BackColor = colordialog.Color;
            }
            if  (font1 != null)
            {
                zapis.WriteLine(font1.Font.ToString());
                this.Font = font1.Font;
            }
            this.fullstream = fullstream;

            
            
            
            zapis.WriteLine(fullstream);
            zapis.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();          
            dlg.ShowDialog();
            colordialog = dlg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();        
            fnt.ShowDialog();
            font1 = fnt;
        }
    }
}
