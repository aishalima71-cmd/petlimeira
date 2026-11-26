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
    public partial class Cidades : Form
    {

        // criar propriedade 
        // datatable é uma tabela em memória
        private DataTable tabelaDeDados = new DataTable();
        public Cidades()
        {
            InitializeComponent();
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // definir o caminho  e o nome do arquivo de dados
            string caminho = "C:\\Users\\aisha.aslima\\Documents\\dados\\cidades.csv";

            // ler o texto do arquivo
            var texto = new StreamReader(caminho, Encoding.GetEncoding("ISO-8859-1"));

            // percorrer a 1 linha para identificar o cabeçalho
            // coluna é a variável que receberá os nomes das colunas
            // ReadLine faz parte da classe StreamReader e lê uma linha
            //Slpit divide o texto em um determinado caracter, aqui, o ;
            foreach (string coluna in texto.ReadLine().Split(";"))
            {
                tabelaDeDados.Columns.Add(coluna);
            }

            // demais colunas
            string linha;
            while ((linha = texto.ReadLine()) != null)
            {
                // adicionar linha por linha na tabela de dados
                // dividindo a linha em colunas usando o split 
                tabelaDeDados.Rows.Add(linha.Split(";"));
            }

            // incluir a tabela de dados no gridview
            dataGridView1.DataSource = tabelaDeDados;
        }

        private void bntFiltrar_Click(object sender, EventArgs e)
        {
            // validar se o datatable ja esta carregado
            if (tabelaDeDados == null || tabelaDeDados.Rows.Count == 0)
            {
                Messagem.Aviso("primeiro, clique no botão carregar dados");
                return;  // interrompe a execução do método
            }
            // criar uma lista que será usada no filtro
            var filtro = new List<string>();

            // aplicar o filtro UF
            if (cmbUf.SelectedIndex > 0) // indica que tem UF selecionada
            {
                filtro.Add($"uf = '{cmbUf.SelectedItem}'");
            }

            // Recuperar valores dos textBox e converter para inteiros
            int.TryParse(txtMinimo.Text, out int populacaoMin);
            int.TryParse(txtMaximo.Text, out int populacaoMax);

            // verificar se a conversão para int deu certo
            if (populacaoMin > 0 && populacaoMax > 0)
            {
                filtro.Add($"pop2021 >= {populacaoMin}");
                filtro.Add($"pop2021 <= {populacaoMax}");
            }


            // incluir o filtro no dataTable 
            tabelaDeDados.DefaultView.RowFilter = string.Join(" AND ", filtro);
        }
    }
}

