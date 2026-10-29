using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    internal class Carro
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        int Ano { get; set; }
        string Cor { get; set; }
        public bool Novo { get; set; }

        public Carro(string marca, string modelo, int ano, string cor, bool novo)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Novo = novo;
        }

        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }

        public string ExibirDados()
        {
            string estado;
            string idade;

            if (Novo == true)
            {
                estado = "Novo";
                idade = "0 anos";
            }
            else
            {
                estado = "Usado";
                idade = $"{CalcularIdade()} anos";
            }


            string texto = $"Marca: {Marca}\nModelo: {Modelo}\nAno: {Ano}\nCor: {Cor}\nEstado: {estado}\nIdade do Veículo: {idade}";

            return texto;
        }
    }
}
