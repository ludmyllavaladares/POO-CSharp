using System;
using System.Globalization;

namespace Produto_estoque_autoproperties
{
    class Produto
    {
        private string _nome;
        public Double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

    }
}
