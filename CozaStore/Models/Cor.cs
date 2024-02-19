
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Cor")]
public class Cor {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Geração identidade (id)
    public int Id { get; set; }
    
    [Required(ErrorMessage         = "Por favor, Informe o Nome da Cor.")]
    [StringLength(30, ErrorMessage = "O Nome da Cor deve posuir no Máximo 30 Caracteres.")]
    public string Nome { get; set; }

    [Display(Name                  = "Código Hexa", Prompt = "Ex. #000000")]
    [Required(ErrorMessage         = "Por favor, Informe o Código Hexa.")]
    [StringLength(7, ErrorMessage  = "O Código Hexa deve possuir no Máximo 7 Caracteres.")]
    public string CodigoHexa { get; set; }
}
