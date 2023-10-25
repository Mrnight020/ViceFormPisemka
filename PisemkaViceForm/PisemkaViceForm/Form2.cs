using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PisemkaViceForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form formulozeni = new Form();

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter zapis = new StreamWriter("hra.txt",true);
            zapis.WriteLine(textBox1.Text);
            zapis.WriteLine(DateTime.Now);
            zapis.Close();

            Label label2 = new Label();

            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label2.Location = new System.Drawing.Point(279, 184);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(208, 55);
            label2.TabIndex = 3;
            label2.Text = "Uloženo";
            formulozeni.Controls.Add(label2);
            formulozeni.ShowIcon = false;
            formulozeni.Text = "Ulozeni";
            formulozeni.Show();

            formulozeni.Close();

            this.Close();
        }
    }
}
