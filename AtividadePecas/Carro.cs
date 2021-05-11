using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePecas
{
    class Carro
    {
        public string marca, nome;
        public int ano;
        public List<Peca> pecas;

        public Carro(string marca, string nome,
            int ano)
        {
            this.marca = marca;
            this.nome = nome;
            this.ano = ano;
            this.pecas = new List<Peca>();
        }
    }
}
