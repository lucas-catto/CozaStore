
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ProdutoFoto")]
public class ProdutoFoto {

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

    [Display(Name          = "Por favor, faça upload da Foto")]
    [StringLength(300)]
    public string ArquivoFoto { get; set; }

    [Display(Name = "Foto Destaque?")]
    public bool Destaque { get; set; }
}
