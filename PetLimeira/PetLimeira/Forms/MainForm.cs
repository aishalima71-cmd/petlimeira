using PetLimeira.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Messagem.Erro("Papum! Pirulito! Pão Doce!");
            //Messagem.Aviso("KAGE BUNSHIN NO JUTSU!");
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // obter a data e hora atual
            DateTime dataHoraAtual = DateTime.Now; // tip datetime, vai armezar data e hora, executa metodo now, e retorna a data do sistema

            // atualizar status com a data e hora
            status2.Text = dataHoraAtual.ToString();


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pedir confirmação para fechar
            DialogResult confirmacao = MessageBox.Show(
                "Deseja fechar a aplicação",
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.OK)
            {
                // fechar a aplicação
                Application.Exit();
            }
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://www.youtube.com/@soundeffects2025");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void listaDeCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar o formulario (classe) cidades
            Form formCidades = new Cidades();
            formCidades.MdiParent = this; // Abrir dentro do principal
            formCidades.WindowState = FormWindowState.Maximized;
            formCidades.Show();

        }

        private void preçoDosCombustíveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar o formulario (classe) cidades
            Form formPrecoGasolinaEtanol = new PrecosGasolinaEtanol();
            formPrecoGasolinaEtanol.MdiParent = this; // Abrir dentro do principal
            formPrecoGasolinaEtanol.WindowState = FormWindowState.Maximized;
            formPrecoGasolinaEtanol.Show();

        }

        private void todosOsCampeõsMundiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Messagem.Aviso("Todos os Campeoes Mundiais - em breve");
        }

        private void tutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTutor = new tutorForm();
            formTutor.MdiParent = this;
            formTutor.WindowState = FormWindowState.Maximized;
            formTutor.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAnimais = new AnimalForm ();
            formAnimais.MdiParent = this;
            formAnimais.WindowState = FormWindowState.Maximized;
            formAnimais.Show();
        }
    }
}
