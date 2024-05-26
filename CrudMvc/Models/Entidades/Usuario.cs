using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvc.Models.Entidades
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome do Usuário")]
        [Column("Nome")]
        public string NomeUsuario { get; set; }
        [Display(Name = "Idade")]
        [Column("Idade")]
        public int Idade { get; set; }
        [Display(Name = "Tipo de Usuário")]
        [Column("Tipo")]
        public int TipoUsuario { get; set; }
    }
}
