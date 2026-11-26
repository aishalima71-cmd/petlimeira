using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("usuarios")]

    public class Usuario
    {
        [Key]
        [Column("id")]
        public int IdUsuario { get; set; }

        [Column("login")]
        public string Login { get; set; } = string.Empty;

        [Column("senha")]
        public string Senha { get; set; } = string.Empty;
    }
}
