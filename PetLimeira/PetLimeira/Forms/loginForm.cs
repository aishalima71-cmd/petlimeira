using PetLimeira.Data;
using PetLimeira.Models;
using PetLimeira.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            CriarHashParaObanco();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // validar os campos vazios 
            if (txtLogin.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Login");
                txtLogin.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Senha");
                txtSenha.Focus();
                return;
            }
            //autenticação com os dados digitados
            var banco = new BancoContext();

            // busca no banco o primeiro registro de ususario que seja igual ao login informado 
            var usuario = banco.ControleUsuario
                .FirstOrDefault(userDoBanco => 
                userDoBanco.Login == txtLogin.Text.Trim());
            
            if (
                usuario == null ||
                !HashSenha.Verificar(txtSenha.Text, usuario.Senha)
            )
            {

                Messagem.Aviso("Usuário ou senha inválidos");
                return;
            }

            if (usuario == null)
            {
                Messagem.Aviso("Usuário não encontrado");
                return; 
            }
              DialogResult = DialogResult.OK;
              Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();

        }
        private void CriarHashParaObanco()
        {
            var minhaHash = HashSenha.Gerar("123");

            var banco = new BancoContext();
            var admin = new Usuario
     {
         Login = "dono",
         Senha = minhaHash
     };
            banco.ControleUsuario.Add(admin);
            banco.SaveChanges();

        }



    }
}
