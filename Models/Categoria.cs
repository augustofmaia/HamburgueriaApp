using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamburgueriaApp.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }


        [StringLength(100, ErrorMessage = "O tamanho máximo são 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }


        [StringLength(200, ErrorMessage = "O tamanho máximo são 100 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Nome")]
        public string Descricao { get; set; }


        //Propriedade de navegação e relacionamento entre categoria e lanche, de um para muitos
        public List<Lanche> Lanches { get; set;}
    }
}
