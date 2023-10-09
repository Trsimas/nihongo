using System.ComponentModel.DataAnnotations;

namespace nihongo.Models
{
    public class Item
    {
       public int ItemId{get; set;}
       public string Nome{get; set;}
       public int CategoriaId{get; set;}
       public string DescricaoCurta{get; set;}
       public string DescricaoDetalhada{get; set;}
       public double Preco{get; set;}
       public string ImagemProdutoUrl{get; set;}
       public Boolean Ativo {get; set;}
       public Boolean Destaque {get; set;}
       public virtual Categoria Categoria {get; set;}
    }
}