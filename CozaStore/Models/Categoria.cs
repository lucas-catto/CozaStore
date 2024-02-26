
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Categoria")]
public class Categoria {
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Geração identidade (id)
    public int Id { get; set; }

    [Required(ErrorMessage         = "Por favor, Informe a Categoria.")]
    [StringLength(30, ErrorMessage = "A categoria deve posuir no Máximo 30 Caracteres.")]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
    
    [Display(Name = "Exibir como Filtro?")]
    public bool Filtrar { get; set; } = false;

    [Display(Name = "Exibir como Banner?")]
    public bool Banner { get; set; } = false;
    
    [Display(Name = "Categoria Pai")]
    public int? CategoriaPaiId { get; set; }

    [ForeignKey("CategoriaPaiId")]    
    public Categoria CategoriaPai { get; set; } // Propriedade de Navegação
}
