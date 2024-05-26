using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvc.Models.Entidades
{
    [Table("Escola")]
    public class Escola
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Nome da Escola")]
        public string Nome { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name ="Tipo")]
        [Column("Tipo")]
        public int TipoEscola { get; set; }
        public List<Foto> Fotos { get; set; } = new List<Foto>();
    }

    [Table("Foto")]
    public class Foto
    {
        [Key]
        public int Id { get; set; }
        public byte[] ImageData { get; set; }
        public int EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
