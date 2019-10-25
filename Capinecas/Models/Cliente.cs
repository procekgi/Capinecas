using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capinecas.Models
{
    [Table("Cliente")]
    public class Cliente
    {        
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
