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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PetLimeira.Forms
{
    public partial class tutorForm : Form
    {
        // Propriedade da classe para guardar o id da seleção selecionada no grid
        private int idSelecionado = 0;

        public tutorForm()
        {
            InitializeComponent();
            ListarTutores();
            // Desabilitar os botoes atualizar e Excluir
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void ListarTutores(string filtro = "")
        {
            var banco = new BancoContext();

            // Executar o método To List para retornar uma lista de tutores

            var tutores = banco.ControleTutor
                .Where(p => p.nome.Contains(filtro))
                .ToList();

            // Carrega no gridview a lista de tutores
            dataGridView1.DataSource = tutores;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verfica se o formulario é valido
            if (!CamposValidos())
            {
                return; // Encerra a execução
            }

            // Cria a conecçao com o banco
            var banco = new BancoContext();

            // Criar o objeto selecao para mapear os dados para o banco
            var tutor = new Tutores
            {
                nome = txtNome.Text,
                cpf = txtCpf.Text,
                rua = txtRua.Text,
                numero = txtNumero.Text,
                bairro = txtBairro.Text,
                cidade = txtCidade.Text,
                cep = txtCep.Text,
                celular = txtCelular.Text,
                telefone = txtTelefone.Text

            };

            banco.ControleTutor.Add(tutor);
            banco.SaveChanges();
            Messagem.Aviso("Dados gravados com suceesso");

            // Atualizar o datagridview
            ListarTutores();

            // Limpar os campos do formulario
            LimparCampos();
        }
        // Método para validar campos do formulário
        private bool CamposValidos()
        {
            if (txtNome.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Nome do Tutor");
                txtNome.Focus();
                return false;
            }

            if (txtCpf.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o cpf");
                txtCpf.Focus();
                return false;
            }

            if (txtRua.Text.Trim() == "")
            {
                Messagem.Aviso("Informe a Rua");
                txtRua.Focus();
                return false;
            }

            if (txtNumero.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Numero da Rua");
                txtNumero.Focus();
                return false;
            }

            if (txtBairro.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Bairro");
                txtBairro.Focus();
                return false;
            }

            if (txtCidade.Text.Trim() == "")
            {
                Messagem.Aviso("Informe a Cidade");
                txtCidade.Focus();
                return false;
            }

            if (txtCep.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Cep");
                txtCep.Focus();
                return false;
            }

            if (txtCelular.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Celular");
                txtCelular.Focus();
                return false;
            }


            if (txtTelefone.Text.Trim() == "")
            {
                Messagem.Aviso("Informe o Telefone");
                txtTelefone.Focus();
                return false;
            }


            return true;
        }

        // Método para limpar os campos do formulario
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
            btnAdicionar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Desabilitar o botão add para evitar clique acidental
            btnAdicionar.Enabled = false;

            // Habilitar os botoes Atualizar e Excluir
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;

            if (e.RowIndex < 0)
            {
                return;
            }

            var objTutor = dataGridView1.Rows[e.RowIndex].DataBoundItem as Tutores;

            if (objTutor == null)
            {
                return;
            }

            idSelecionado = objTutor.idTutor;
            txtNome.Text = objTutor.nome;
            txtCpf.Text = objTutor.cpf;
            txtRua.Text = objTutor.rua;
            txtNumero.Text = objTutor.numero;
            txtBairro.Text = objTutor.bairro;
            txtCidade.Text = objTutor.cidade;
            txtCep.Text = objTutor.cep;
            txtCelular.Text = objTutor.celular;
            txtTelefone.Text = objTutor.telefone;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                Messagem.Aviso("Selecione uma linha no grid");
                return;
            }

            // SOLICITAR CONFIRMAÇÃO DE EXCLUSÃO
            var resposta = Messagem.Confirmação("Deseja excluir essa seleção?");
            if (resposta != DialogResult.Yes)
            {
                return;
            }
            // buscar a conexão com o banco
            var banco = new BancoContext();

            //verificar se o idSeleciona existe no banco de dados
            var objSelecao = banco.ControleTutor.Find(idSelecionado);
            if (objSelecao == null)
            {
                return;
            }

            // executa a exclusão
            banco.ControleTutor.Remove(objSelecao);
            banco.SaveChanges();

            LimparCampos();
            ListarTutores();


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                Messagem.Aviso("Selecione uma linha no grid");
                return;
            }

            if (!CamposValidos())
            {
                return; // Encerra a execução
            }

            var banco = new BancoContext();
            var objSelecao = banco.ControleTutor.Find(idSelecionado);
            if (objSelecao == null)
            {
                return;
            }

            // Obter os novos dados do formulario e atualizar no objeto que sera
            // atualizado
            objSelecao.nome = txtNome.Text;
            objSelecao.cpf = txtCpf.Text;
            objSelecao.rua = txtRua.Text;
            objSelecao.numero = txtNumero.Text;
            objSelecao.bairro = txtBairro.Text;
            objSelecao.cidade = txtCidade.Text;
            objSelecao.cep = txtCep.Text;
            objSelecao.celular = txtCelular.Text;
            objSelecao.telefone = txtTelefone.Text;
            banco.SaveChanges();

            LimparCampos();
            ListarTutores();


        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarTutores(txtCampoBusca.Text);
        }

        private void txtCampoBusca_TextChanged(object sender, EventArgs e)
        {
            ListarTutores(txtCampoBusca.Text);
        }
    }
    
}


    

