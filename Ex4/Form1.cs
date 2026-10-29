using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CriarExibir_Click(object sender, EventArgs e)
        {
            string aluno = "aluna";


            if (!int.TryParse(txt_Idade.Text, out int idade) || !double.TryParse(txt_nota1.Text, out double nota1) || !double.TryParse(txt_nota2.Text, out double nota2))
            {
                MessageBox.Show("Erro na conversão");
                return;
            }

            Media calc = new Media(txt_Nome.Text, idade, nota1, nota2);

            if (calc.CalcularMedia())
            {
                if (calc.Aprovado == true)
                {
                    lbl_output.ForeColor = Color.Green;
                    lbl_output.Text = calc.ExibirDados("APROVADO/A");

                }
                else
                {
                    lbl_output.ForeColor = Color.Red;
                    lbl_output.Text = calc.ExibirDados("REPROVADO/A");
                }
            }
            else
            {
                lbl_output.ForeColor = Color.Orange;
                lbl_output.Text = calc.ExibirDados("Nota Invalida");
            }

            if (aluno == "aluno")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Trabalhos\Aulas10a12\Ex4\IMGS\Aluno.jpg");
            }
            if (aluno == "aluna")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Trabalhos\Aulas10a12\Ex4\IMGS\Aluna.jpg");
            }
        }
    }
}