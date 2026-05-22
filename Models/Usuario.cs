using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilotec_MVC_DEV.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Matricula { get; set; } = null!;

        public bool Ativo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Senha { get; set; }

        [Required]
        [StringLength(11)]
        public string NumCel { get; set; } = null!;

        public bool TipoBib { get; set; } // 0 ou false = aluno, 1 = bibliotecaria

        public ICollection <Reserva> Reservas { get; set; } = new List<Reserva>();

    }
}