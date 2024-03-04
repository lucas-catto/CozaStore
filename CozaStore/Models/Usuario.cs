
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CozaStore.Models;

[Table("Usuario")]
public class Usuario {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public IdentityUser ContaUsuario { get; set; }

    [Required(ErrorMessage         = "Por favor, Informe o Nome.")]
    [StringLength(60, ErrorMessage = "O Nome deve posuir no Máximo 60 Caracteres.")]
    public string Nome { get; set; }
    
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe a data de nascimento")]
    public DateTime DataNascimento { get; set; }
    
    [StringLength(300)]
    public string Foto { get; set; }
}
