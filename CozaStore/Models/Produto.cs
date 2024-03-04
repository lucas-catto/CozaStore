
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Produto")]
public class Produto {
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Geração identidade (id)
    public int Id { get; set; }

    [Required(ErrorMessage          = "Por favor, Informe o Nome.")]
    [StringLength(100, ErrorMessage = "O Nome do Produto deve posuir no Máximo 100 Caracteres.")]
    public string Nome { get; set; }

    [Display(Name                    = "Descriçao Resumida")]
    [StringLength(1000, ErrorMessage = "A descriçaõ deve posuir no Máximo 1000 Caracteres.")]
    public string DescricaoResumida { get; set; }

    [Display(Name                    = "Descriçao")]
    [StringLength(8000, ErrorMessage = "A descriçaõ deve posuir no Máximo 8000 Caracteres.")]
    public string Descricao { get; set; }

    [Display(Name = "SKU")]
    [StringLength(10, ErrorMessage = "O SKU deve possuir no máximo 10 caracteres.")]
    public string SKU { get; set; }

    [Display(Name          = "Preço de Venda")]
    [Column(TypeName       = "decimal(12,2)")] // OU Range(0, 999)
    [Required(ErrorMessage = "Por favor, Informe o Preço de Venda")]
    public decimal Preco { get; set; }

    [Display(Name          = "Preço com Desconto")]
    [Column(TypeName       = "decimal(8,2)")] // OU Range(0, 999)
    [Required(ErrorMessage = "Por favor, Informe o Preço com Desconto")]
    public decimal PrecoDesconto { get; set; }

    [Display(Name = "Produto em Destaque?")]
    public bool Destaque { get; set; } = false;

    [Column(TypeName = "descimal(8,3)")]
    public double Peso { get; set; } = 0;

    [StringLength(50, ErrorMessage = "O Material deve possuir no Máximo 50 Caracteres.")]
    public string Material { get; set; }

    [Display(Name                  = "Dimensões")]
    [StringLength(20, ErrorMessage = "As dimensões devem possuir no máximo 20 caracteres.")]
    public string Dimensoes { get; set; }

    [Display(Name          = "Categoria")]
    [Required(ErrorMessage = "Por favor, Informe a Categoria.")]
    public int CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    public ICollection<Estoque> Estoque { get; set; }
    public ICollection<ProdutoFoto> Fotos { get; set; }
}
