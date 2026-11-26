namespace PetLimeira.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            tutoresToolStripMenuItem = new ToolStripMenuItem();
            animaisToolStripMenuItem = new ToolStripMenuItem();
            veterináriosToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem1 = new ToolStripMenuItem();
            cRMVToolStripMenuItem = new ToolStripMenuItem();
            especialidadeToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            dataEHoraToolStripMenuItem = new ToolStripMenuItem();
            motivoToolStripMenuItem = new ToolStripMenuItem();
            oBSToolStripMenuItem = new ToolStripMenuItem();
            procedimentosToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem2 = new ToolStripMenuItem();
            preçoDeTabelaToolStripMenuItem = new ToolStripMenuItem();
            quantidadeAplicadaToolStripMenuItem = new ToolStripMenuItem();
            vToolStripMenuItem = new ToolStripMenuItem();
            carteiraDeVacinaçãoÚnicaToolStripMenuItem = new ToolStripMenuItem();
            numeroDeRegistroToolStripMenuItem = new ToolStripMenuItem();
            dataDeEmissãoToolStripMenuItem = new ToolStripMenuItem();
            utilitáriosToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            dadosExternosToolStripMenuItem = new ToolStripMenuItem();
            listaDeCidadesToolStripMenuItem = new ToolStripMenuItem();
            preçoDosCombustíveisToolStripMenuItem = new ToolStripMenuItem();
            todosOsCampeõsMundiaisToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            tutoriaisToolStripMenuItem = new ToolStripMenuItem();
            hlepDeskToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sobreOSistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            status2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, utilitáriosToolStripMenuItem, dadosExternosToolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tutoresToolStripMenuItem, animaisToolStripMenuItem, veterináriosToolStripMenuItem, consultasToolStripMenuItem, procedimentosToolStripMenuItem, carteiraDeVacinaçãoÚnicaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // tutoresToolStripMenuItem
            // 
            tutoresToolStripMenuItem.Name = "tutoresToolStripMenuItem";
            tutoresToolStripMenuItem.Size = new Size(220, 22);
            tutoresToolStripMenuItem.Text = "Tutores";
            tutoresToolStripMenuItem.Click += tutoresToolStripMenuItem_Click;
            // 
            // animaisToolStripMenuItem
            // 
            animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            animaisToolStripMenuItem.Size = new Size(220, 22);
            animaisToolStripMenuItem.Text = "Animais";
            animaisToolStripMenuItem.Click += animaisToolStripMenuItem_Click;
            // 
            // veterináriosToolStripMenuItem
            // 
            veterináriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nomeToolStripMenuItem1, cRMVToolStripMenuItem, especialidadeToolStripMenuItem });
            veterináriosToolStripMenuItem.Name = "veterináriosToolStripMenuItem";
            veterináriosToolStripMenuItem.Size = new Size(220, 22);
            veterináriosToolStripMenuItem.Text = "Veterinários";
            // 
            // nomeToolStripMenuItem1
            // 
            nomeToolStripMenuItem1.Name = "nomeToolStripMenuItem1";
            nomeToolStripMenuItem1.Size = new Size(145, 22);
            nomeToolStripMenuItem1.Text = "Nome ";
            // 
            // cRMVToolStripMenuItem
            // 
            cRMVToolStripMenuItem.Name = "cRMVToolStripMenuItem";
            cRMVToolStripMenuItem.Size = new Size(145, 22);
            cRMVToolStripMenuItem.Text = "CRMV";
            // 
            // especialidadeToolStripMenuItem
            // 
            especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
            especialidadeToolStripMenuItem.Size = new Size(145, 22);
            especialidadeToolStripMenuItem.Text = "Especialidade";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataEHoraToolStripMenuItem, motivoToolStripMenuItem, oBSToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(220, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // dataEHoraToolStripMenuItem
            // 
            dataEHoraToolStripMenuItem.Name = "dataEHoraToolStripMenuItem";
            dataEHoraToolStripMenuItem.Size = new Size(136, 22);
            dataEHoraToolStripMenuItem.Text = "Data e Hora";
            // 
            // motivoToolStripMenuItem
            // 
            motivoToolStripMenuItem.Name = "motivoToolStripMenuItem";
            motivoToolStripMenuItem.Size = new Size(136, 22);
            motivoToolStripMenuItem.Text = "Motivo";
            // 
            // oBSToolStripMenuItem
            // 
            oBSToolStripMenuItem.Name = "oBSToolStripMenuItem";
            oBSToolStripMenuItem.Size = new Size(136, 22);
            oBSToolStripMenuItem.Text = "OBS";
            // 
            // procedimentosToolStripMenuItem
            // 
            procedimentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nomeToolStripMenuItem2, preçoDeTabelaToolStripMenuItem, quantidadeAplicadaToolStripMenuItem, vToolStripMenuItem });
            procedimentosToolStripMenuItem.Name = "procedimentosToolStripMenuItem";
            procedimentosToolStripMenuItem.Size = new Size(220, 22);
            procedimentosToolStripMenuItem.Text = "Procedimentos";
            // 
            // nomeToolStripMenuItem2
            // 
            nomeToolStripMenuItem2.Name = "nomeToolStripMenuItem2";
            nomeToolStripMenuItem2.Size = new Size(185, 22);
            nomeToolStripMenuItem2.Text = "Nome";
            // 
            // preçoDeTabelaToolStripMenuItem
            // 
            preçoDeTabelaToolStripMenuItem.Name = "preçoDeTabelaToolStripMenuItem";
            preçoDeTabelaToolStripMenuItem.Size = new Size(185, 22);
            preçoDeTabelaToolStripMenuItem.Text = "Preço de Tabela";
            // 
            // quantidadeAplicadaToolStripMenuItem
            // 
            quantidadeAplicadaToolStripMenuItem.Name = "quantidadeAplicadaToolStripMenuItem";
            quantidadeAplicadaToolStripMenuItem.Size = new Size(185, 22);
            quantidadeAplicadaToolStripMenuItem.Text = "Quantidade Aplicada";
            // 
            // vToolStripMenuItem
            // 
            vToolStripMenuItem.Name = "vToolStripMenuItem";
            vToolStripMenuItem.Size = new Size(185, 22);
            vToolStripMenuItem.Text = "Valor Final";
            vToolStripMenuItem.Click += vToolStripMenuItem_Click;
            // 
            // carteiraDeVacinaçãoÚnicaToolStripMenuItem
            // 
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { numeroDeRegistroToolStripMenuItem, dataDeEmissãoToolStripMenuItem });
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.Name = "carteiraDeVacinaçãoÚnicaToolStripMenuItem";
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.Size = new Size(220, 22);
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.Text = "Carteira de vacinação Única";
            // 
            // numeroDeRegistroToolStripMenuItem
            // 
            numeroDeRegistroToolStripMenuItem.Name = "numeroDeRegistroToolStripMenuItem";
            numeroDeRegistroToolStripMenuItem.Size = new Size(180, 22);
            numeroDeRegistroToolStripMenuItem.Text = "Numero de Registro";
            // 
            // dataDeEmissãoToolStripMenuItem
            // 
            dataDeEmissãoToolStripMenuItem.Name = "dataDeEmissãoToolStripMenuItem";
            dataDeEmissãoToolStripMenuItem.Size = new Size(180, 22);
            dataDeEmissãoToolStripMenuItem.Text = "Data de Emissão";
            // 
            // utilitáriosToolStripMenuItem
            // 
            utilitáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, blocoDeNotasToolStripMenuItem });
            utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            utilitáriosToolStripMenuItem.Size = new Size(69, 20);
            utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(154, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new Size(154, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            blocoDeNotasToolStripMenuItem.Click += blocoDeNotasToolStripMenuItem_Click;
            // 
            // dadosExternosToolStripMenuItem
            // 
            dadosExternosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeCidadesToolStripMenuItem, preçoDosCombustíveisToolStripMenuItem, todosOsCampeõsMundiaisToolStripMenuItem });
            dadosExternosToolStripMenuItem.Name = "dadosExternosToolStripMenuItem";
            dadosExternosToolStripMenuItem.Size = new Size(99, 20);
            dadosExternosToolStripMenuItem.Text = "Dados Externos";
            // 
            // listaDeCidadesToolStripMenuItem
            // 
            listaDeCidadesToolStripMenuItem.Name = "listaDeCidadesToolStripMenuItem";
            listaDeCidadesToolStripMenuItem.Size = new Size(222, 22);
            listaDeCidadesToolStripMenuItem.Text = "Lista de Cidades";
            listaDeCidadesToolStripMenuItem.Click += listaDeCidadesToolStripMenuItem_Click;
            // 
            // preçoDosCombustíveisToolStripMenuItem
            // 
            preçoDosCombustíveisToolStripMenuItem.Name = "preçoDosCombustíveisToolStripMenuItem";
            preçoDosCombustíveisToolStripMenuItem.Size = new Size(222, 22);
            preçoDosCombustíveisToolStripMenuItem.Text = "Preço dos combustíveis";
            preçoDosCombustíveisToolStripMenuItem.Click += preçoDosCombustíveisToolStripMenuItem_Click;
            // 
            // todosOsCampeõsMundiaisToolStripMenuItem
            // 
            todosOsCampeõsMundiaisToolStripMenuItem.Name = "todosOsCampeõsMundiaisToolStripMenuItem";
            todosOsCampeõsMundiaisToolStripMenuItem.Size = new Size(222, 22);
            todosOsCampeõsMundiaisToolStripMenuItem.Text = "todos os campeõs mundiais";
            todosOsCampeõsMundiaisToolStripMenuItem.Click += todosOsCampeõsMundiaisToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tutoriaisToolStripMenuItem, hlepDeskToolStripMenuItem, youtubeToolStripMenuItem, toolStripSeparator1, sobreOSistemaToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // tutoriaisToolStripMenuItem
            // 
            tutoriaisToolStripMenuItem.Name = "tutoriaisToolStripMenuItem";
            tutoriaisToolStripMenuItem.Size = new Size(158, 22);
            tutoriaisToolStripMenuItem.Text = "Tutoriais";
            // 
            // hlepDeskToolStripMenuItem
            // 
            hlepDeskToolStripMenuItem.Name = "hlepDeskToolStripMenuItem";
            hlepDeskToolStripMenuItem.Size = new Size(158, 22);
            hlepDeskToolStripMenuItem.Text = "Help Desk";
            // 
            // youtubeToolStripMenuItem
            // 
            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(158, 22);
            youtubeToolStripMenuItem.Text = "Youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            sobreOSistemaToolStripMenuItem.Size = new Size(158, 22);
            sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, status2 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(116, 17);
            toolStripStatusLabel1.Text = "Sistema Pet Limeira |";
            // 
            // status2
            // 
            status2.Name = "status2";
            status2.Size = new Size(118, 17);
            status2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Limeira - Sistema de Gestão";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem tutoresToolStripMenuItem;
        private ToolStripMenuItem animaisToolStripMenuItem;
        private ToolStripMenuItem veterináriosToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem1;
        private ToolStripMenuItem cRMVToolStripMenuItem;
        private ToolStripMenuItem especialidadeToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem dataEHoraToolStripMenuItem;
        private ToolStripMenuItem motivoToolStripMenuItem;
        private ToolStripMenuItem oBSToolStripMenuItem;
        private ToolStripMenuItem procedimentosToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem2;
        private ToolStripMenuItem preçoDeTabelaToolStripMenuItem;
        private ToolStripMenuItem quantidadeAplicadaToolStripMenuItem;
        private ToolStripMenuItem carteiraDeVacinaçãoÚnicaToolStripMenuItem;
        private ToolStripMenuItem vToolStripMenuItem;
        private ToolStripMenuItem numeroDeRegistroToolStripMenuItem;
        private ToolStripMenuItem dataDeEmissãoToolStripMenuItem;
        private ToolStripMenuItem utilitáriosToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem dadosExternosToolStripMenuItem;
        private ToolStripMenuItem listaDeCidadesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem tutoriaisToolStripMenuItem;
        private ToolStripMenuItem hlepDeskToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel status2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem preçoDosCombustíveisToolStripMenuItem;
        private ToolStripMenuItem todosOsCampeõsMundiaisToolStripMenuItem;
    }
}