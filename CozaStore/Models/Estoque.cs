
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Estoque")]
public class Estoque {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Geração identidade (id)
    public int Id { get; set; }
    
    [Required(ErrorMessage         = "Por favor, Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve posuir no Máximo 30 Caracteres.")]
    public string Nome { get; set; }

    [Display(Name          = "Produto")]
    [Required(ErrorMessage = "Por favor, informe o Produto")]
    public int ProdutoId { get; set; }
    
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Display(Name          = "Tamanho")]
    [Required(ErrorMessage = "Por favor, informe o Tamanho")]
    public int TamanhoId { get; set; }
    
    [ForeignKey("TamanhoId")]
    public Tamanho Tamanho { get; set; }

    [Display(Name          = "Cor")]
    [Required(ErrorMessage = "Por favor, informe o Cor")]
    public int CorId { get; set; }
    
    [ForeignKey("CorId")]
    public Cor Cor { get; set; }

    [Display(Name          = "Preço de Venda")]
    [Column(TypeName       = "decimal(12,2)")]
    public decimal? Preco { get; set; } // ? => Aceita nulo

    [Display(Name          = "Preço com Desconto")]
    [Column(TypeName       = "decimal(8,2)")]
    public decimal? PrecoDesconto { get; set; }

    [Display(Name          = "Quantidade Estoque")]
    [Required(ErrorMessage = "Por favor, informe a quantidade em Estoque")]
    public int QuantidadeEstoque { get; set; }
}
