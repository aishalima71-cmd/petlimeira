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
    public partial class AnimalForm : Form
    {
        public AnimalForm()
        {
            InitializeComponent();
            CarregarCombos();
            ListarAnimais();
        }

        // carrega a lista de sedes e seleções nos combos
        private void CarregarCombos()
        {
            var banco = new BancoContext();

            // combobox de sedes 
            cmbTutor.DisplayMember = "nome";
            cmbTutor.ValueMember = "idTutor";
            cmbTutor.DataSource = banco.ControleTutor.ToList();
        }

        private void ListarAnimais()
        {
            var banco = new BancoContext();
            var animais = banco.ControleAnimal.ToList();
            dataGridView1.DataSource = animais;
        }



        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var banco = new BancoContext();

            // criar o objeto animais que sera salvo no banco
            var animal = new Animais
            {
                Nome = txtNome.Text,
                Especie = txtEspecie.Text,
                Raca = txtRaca.Text,
                DataNascimento = dtpNascimento.Value.Date,
                Peso = nudPeso.Value,
                Situacao= txtSituacao.Text,
            };

            // Adicionar o objeto no banco
            banco.ControleAnimal.Add(animal);
            banco.SaveChanges();

            ListarAnimais();

            Messagem.Aviso("dados gravados com sucesso");

        }
    }
}
