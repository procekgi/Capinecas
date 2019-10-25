using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capinecas.Models
{
    [Table("Compra")]
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        public Cliente Cliente { get; set; }
        public Caneca Caneca { get; set; }
        public int Quantidade { get; set; }
        public double PrecoTotal { get; set; }
        public DateTime CompradoEm { get; set; }
        public DateTime EntregueEm { get; set; }
    }
}
