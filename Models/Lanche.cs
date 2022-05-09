using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name ="Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O nome deve ter entre 10 e 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Descrição do lanche")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "A descrição deve ter entre 20 e 200 caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Descrição detalhada do lanche")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "A descrição deve ter entre 20 e 200 caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe um preço")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,99.99, ErrorMessage = "O preço deve estar entre R$ 1,00 e R$ 99,00")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho da imagem normal")]
        [StringLength(200,ErrorMessage = "Tamamho maximo de 200 caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da imagem miniatura")]
        [StringLength(200, ErrorMessage = "Tamamho maximo de 200 caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="É preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
