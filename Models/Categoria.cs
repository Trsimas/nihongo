using System.ComponentModel.DataAnnotations;

namespace nihongo.Models
{
    public class Categoria
    {
       public int CategoriaId {get; set;}
       public string Nome {get; set;}
       public List<Item> Items {get; set;}
    }
}