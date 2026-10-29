using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Media
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double NotaMedia { get; private set; }
        public bool Aprovado { get; private set; }

        public Media(string nome, int idade, double nota1, double nota2)
        {
            Nome = nome;
            Idade = idade;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public bool CalcularMedia()
        {
            if (Nota1 >= 0 && Nota1 <= 20 && Nota2 >= 0 && Nota2 <= 20)
            {
                NotaMedia = (Nota1 + Nota2) / 2;
                if (NotaMedia >= 10)
                {
                    Aprovado = true;
                }
                else
                {
                    Aprovado = false;
                }
                return true;
            }
            else
            {
                return false;
            }

            if (Idade != Nota1)
            {
                return false;
            }
        }

        public string ExibirDados(string estado)
        {
            return $"Nome: {Nome}\nIdade: {Idade}\nNota 1: {Nota1}\nNota 2: {Nota2}\nMédia: {NotaMedia:F1}\nEstado: {estado}";
        }
    }
}
