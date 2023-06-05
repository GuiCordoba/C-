using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
          
        }

        public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()      /* Métedo para obter nome do produto */
        {  
            return _nome; 
        }

        public void SetNome(string nome)      /* Métedo para alterar nome do produto, é void porque não retorna nada, só muda o nome */
        {
            if (nome != null && nome.Length > 1) /* Só vai aceitar se o nome não for nulo e tiver mais que um caracter*/
            {
                _nome = nome;
            }
        }

        public double GetPreco()   /*Não sera possivel alterar o preço, somenter obter o valor */
        { 
            return _preco;
        }

        public int GetQuantidade()   /*Não sera possivel alterar a quantidade, somenter obter o valor */
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
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
