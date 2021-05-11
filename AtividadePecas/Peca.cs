using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePecas
{
    class Peca
    {
        public string marca, nome, modelo;
        public decimal valor;

        public Peca(string marca, string nome,
            string modelo, decimal valor)
        {
            this.marca = marca;
            this.nome = nome;
            this.modelo = modelo;
            this.valor = valor;
        }
    }
}
