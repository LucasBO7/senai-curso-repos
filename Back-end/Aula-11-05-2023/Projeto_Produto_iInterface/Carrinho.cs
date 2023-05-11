using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_iInterface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        // criar uma lista para manipular os nossos objetos (Adicionar, Atualizar, Ver, Excluir etc)
        List<Produto> carrinhos = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinhos.Add(_produto);
        }

        public void Listar()
        {
            // Se houver algo dentro de "carrinhos"
            if (carrinhos.Count > 0)
            {
                foreach (Produto obj in carrinhos)
                {
                    Console.WriteLine(@$"

| Código: {obj.Codigo} 
| Nome: {obj.Nome}     
| Preço: {obj.Preco:C} 
|______________________");

                }
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinhos.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
        }

        public void Remover(Produto _produto)
        {
            carrinhos.Remove(_produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinhos.Count > 0)
            {
                carrinhos.ForEach(x => Valor += x.Preco);

                Console.WriteLine($"O total do seu carrinho é: {Valor:C}");
            }
            else
            {
                Console.WriteLine($"Carrinho vazio!");

            }
        }
    }
}