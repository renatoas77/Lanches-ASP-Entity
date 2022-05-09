using System.ComponentModel.DataAnnotations;

namespace SiteLanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Nome da categoria obrigatório")]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "O tamamho maximo é de 100 caracteres")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamamho maximo é de 200 caracteres")]
        [Required(ErrorMessage = "Descrição obrigatória")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
