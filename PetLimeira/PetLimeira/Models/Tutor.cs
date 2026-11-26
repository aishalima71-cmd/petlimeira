using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    // Anotação para indicar qual tabela esta classe representa
    [Table("tutores")]
    public class Tutores
    {
        // propriedade da classe
        // get pegar ou ler
        // definir ou alterar

        [Key]
        [Column("id_tutor")]
        public int idTutor { get; set; }

        [Column("nome")]
        public required string nome { get; set; }


        [Column("cpf")]
        public required string cpf { get; set; }


        [Column("rua")]
        public required string rua { get; set; }


        [Column("numero")]
        public required string numero { get; set; }


        [Column("bairro")]
        public required string bairro { get; set; }


        [Column("cidade")]
        public required string cidade { get; set; }


        [Column("cep")]
        public required string cep { get; set; }

        [Column("celular")]
        public required string celular { get; set; }

        [Column("telefone")]
        public string? telefone { get; set; }

    }
}

