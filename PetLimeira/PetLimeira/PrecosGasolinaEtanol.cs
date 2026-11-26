using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira
{
    public partial class PrecosGasolinaEtanol : Form
    {// criar propriedade 
     // datatable é uma tabela em memória
        private DataTable tabelaDeDados = new DataTable();


        public PrecosGasolinaEtanol()
        {
            InitializeComponent();
        }

        private void bntCarregar_Click(object sender, EventArgs e)
        {
            // definir o caminho  e o nome do arquivo de dados
            string caminho = "C:\\Users\\aisha.aslima\\Documents\\dados\\precos-gasolina-etanol.csv";

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


    }
}

