using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capinecas.Models
{
    [Table("Caneca")]
    public class Caneca
    {
        public Caneca() { CriadoEm = DateTime.Now; }
        [Key]
        public int IdCaneca { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
       
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string Imagem { get; set; }
    }
}
