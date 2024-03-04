
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Tamanho")]
public class Tamanho {
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Geração identidade (id)
    public int Id { get; set; }

    [Required(ErrorMessage         = "Por favor, Informe a Sigla do Tamanho.")]
    [StringLength(5, ErrorMessage  = "A Sigla deve posuir no Máximo 5 Caracteres.")]
    public string Sigla { get; set; }
    
    [Required(ErrorMessage         = "Por favor, Informe o Tamanho.")]
    [StringLength(30, ErrorMessage = "O Nome da Tamanho deve posuir no Máximo 30 Caracteres.")]
    public string Nome { get; set; }

    public ICollection<Estoque> Estoque { get; set; }
}
