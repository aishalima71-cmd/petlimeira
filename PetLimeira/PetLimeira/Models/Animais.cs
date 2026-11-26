using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    // Anotação para indicar qual tabla esta classe representa.

    [Table("animais")]

    public class Animais
    {
        [Key]
        [Column("id_animal")] // procura por Id
        public int IdAnimal { get; set; }

        [Column("nome")]
        public required string Nome { get; set; } 


        [Column("especie")]
        public required string Especie { get; set; } 

        [Column("raca")]
        public required string Raca { get; set; }

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("peso")]
        public decimal Peso { get; set; }

        [Column("situacao")]
        public required string Situacao{ get; set; }
    }
}
