namespace HamburgueriaApp.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Name { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }



        //Essas abaixo são propriedades de navegação, não serão criadas na tabela. Usadas para definir o relacionamento em lanche e categoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}