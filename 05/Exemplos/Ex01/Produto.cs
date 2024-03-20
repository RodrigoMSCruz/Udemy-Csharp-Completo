using System;
using System.Globalization;

namespace 05.Exemplos.Ex01
{
    public class Produto
    {
        public string _nome;
        public double _preco{ get; private set }
        public int -quantidade{ get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco): this()
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
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
        public double Preco
        {
            get
            {
                return _preco;
            }
        }
        public int Quantidade
        {
            get
                {
                    return _quantidade;
                }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * -quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            _quantidade += _quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }  
    }
}