using Microsoft.EntityFrameworkCore;
using PetLimeira.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PetLimeira.Data
{

    // o DbContext é a classe base do EF core que gerencia 
    // a conexão com o banco de dados 
    // aqui ela é obtida por herança
    public class BancoContext : DbContext 
    {    // criar uma propriedade que funcionara como um controle remoto
         // ela sEra usada para executar ações do CRUD
        public DbSet<Tutores> ControleTutor { get; set; }

        public DbSet<Usuario> ControleUsuario { get; set; }

        public DbSet<Animais> ControleAnimal { get; set; }



        // metodo para informações do banco
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conexao = "Server=localhost;Port=3306;Database=pet_limeira;User=root;";
            // var versao = new MySqlServerVersion(new Version(8, 0, 0));
            options.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            //  base.OnConfiguring(options);
        }

    }
}

