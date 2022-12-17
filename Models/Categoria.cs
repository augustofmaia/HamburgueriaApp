namespace HamburgueriaApp.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //Propriedade de navegação e relacionamento entre categoria e lanche, de um para muitos
        public List<Lanche> Lanches { get; set;}
    }
}
