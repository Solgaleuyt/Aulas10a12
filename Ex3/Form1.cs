using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro carro1 = new Carro("Porsche", "Carrera", 2026, "Cinzento Crayon", true);

            if (checkBox1.Checked == false && carro1.Novo == false)
            {
                pictureBox1.Image = Image.FromFile($@"C:\Users\{Environment.UserName}\Desktop\Trabalhos\Aulas10a12\Ex3\IMGS\Carro_Sucata.jpg");
            }
            else if (checkBox1.Checked == true && carro1.Novo == true)
            {
                pictureBox1.Image = Image.FromFile($@"C:\Users\{Environment.UserName}\Desktop\Trabalhos\Aulas10a12\Ex3\IMGS\Carro_Novo.jpg");
            }
            else
            {
                pictureBox1.Image = null;
            }

            lbl_output.Text = carro1.ExibirDados();
        }
    }
}
