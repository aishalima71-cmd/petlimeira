namespace PetLimeira.Forms
{
    partial class tutorForm
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
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            txtCelular = new TextBox();
            txtTelefone = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCidade = new TextBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtBairro = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            dataGridView1 = new DataGridView();
            txtCampoBusca = new TextBox();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(txtCep);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 429);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Tutor";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(218, 323);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(63, 23);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(143, 323);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(69, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(71, 323);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(66, 23);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(9, 323);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(56, 23);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(12, 280);
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Celular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(11, 249);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 231);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "Telefone para Contato";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 74);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 7;
            label1.Text = "Endereço";
            label1.Click += label1_Click;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(7, 179);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 6;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(7, 150);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "Cep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(113, 121);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Size = new Size(42, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(7, 121);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(100, 23);
            txtRua.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(6, 92);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Bairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(112, 22);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "CPF";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 22);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 407);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtCampoBusca
            // 
            txtCampoBusca.Location = new Point(380, 2);
            txtCampoBusca.Name = "txtCampoBusca";
            txtCampoBusca.PlaceholderText = "Buscar por Tutores";
            txtCampoBusca.Size = new Size(100, 23);
            txtCampoBusca.TabIndex = 2;
            txtCampoBusca.TextChanged += txtCampoBusca_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(486, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtCampoBusca);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "tutorForm";
            Text = "tutorForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBairro;
        private TextBox txtCpf;
        private TextBox txtNome;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private TextBox txtCelular;
        private TextBox txtTelefone;
        private Label label2;
        private Label label1;
        private TextBox txtCidade;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtRua;
        private DataGridView dataGridView1;
        private TextBox txtCampoBusca;
        private Button btnBuscar;
    }
}