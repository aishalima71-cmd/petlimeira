namespace PetLimeira.Forms
{
    partial class AnimalForm
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
            txtSituacao = new TextBox();
            txtRaca = new TextBox();
            txtEspecie = new TextBox();
            lbNomeAnimal = new Label();
            lbPeso = new Label();
            nudPeso = new NumericUpDown();
            lbSituacao = new Label();
            lbTutor = new Label();
            dtpNascimento = new DateTimePicker();
            cmbTutor = new ComboBox();
            lbNascimento = new Label();
            lbRaca = new Label();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            lbEspecie = new Label();
            txtNome = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSituacao);
            groupBox1.Controls.Add(txtRaca);
            groupBox1.Controls.Add(txtEspecie);
            groupBox1.Controls.Add(lbNomeAnimal);
            groupBox1.Controls.Add(lbPeso);
            groupBox1.Controls.Add(nudPeso);
            groupBox1.Controls.Add(lbSituacao);
            groupBox1.Controls.Add(lbTutor);
            groupBox1.Controls.Add(dtpNascimento);
            groupBox1.Controls.Add(cmbTutor);
            groupBox1.Controls.Add(lbNascimento);
            groupBox1.Controls.Add(lbRaca);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(lbEspecie);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 489);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Animal";
            // 
            // txtSituacao
            // 
            txtSituacao.Location = new Point(12, 340);
            txtSituacao.Name = "txtSituacao";
            txtSituacao.Size = new Size(100, 23);
            txtSituacao.TabIndex = 29;
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(10, 168);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(100, 23);
            txtRaca.TabIndex = 28;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(10, 113);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(100, 23);
            txtEspecie.TabIndex = 27;
            // 
            // lbNomeAnimal
            // 
            lbNomeAnimal.AutoSize = true;
            lbNomeAnimal.Location = new Point(10, 30);
            lbNomeAnimal.Name = "lbNomeAnimal";
            lbNomeAnimal.Size = new Size(98, 15);
            lbNomeAnimal.TabIndex = 26;
            lbNomeAnimal.Text = "Nome do Animal";
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(9, 264);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 25;
            lbPeso.Text = "Peso";
            // 
            // nudPeso
            // 
            nudPeso.DecimalPlaces = 2;
            nudPeso.Location = new Point(12, 282);
            nudPeso.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(120, 23);
            nudPeso.TabIndex = 24;
            // 
            // lbSituacao
            // 
            lbSituacao.AutoSize = true;
            lbSituacao.Location = new Point(10, 322);
            lbSituacao.Name = "lbSituacao";
            lbSituacao.Size = new Size(52, 15);
            lbSituacao.TabIndex = 23;
            lbSituacao.Text = "Situação";
            // 
            // lbTutor
            // 
            lbTutor.AutoSize = true;
            lbTutor.Location = new Point(143, 30);
            lbTutor.Name = "lbTutor";
            lbTutor.Size = new Size(36, 15);
            lbTutor.TabIndex = 22;
            lbTutor.Text = "Tutor";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(12, 229);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(119, 23);
            dtpNascimento.TabIndex = 21;
            // 
            // cmbTutor
            // 
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(143, 48);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(121, 23);
            cmbTutor.TabIndex = 19;
            // 
            // lbNascimento
            // 
            lbNascimento.AutoSize = true;
            lbNascimento.Location = new Point(10, 211);
            lbNascimento.Name = "lbNascimento";
            lbNascimento.Size = new Size(114, 15);
            lbNascimento.TabIndex = 16;
            lbNascimento.Text = "Data de Nascimento";
            // 
            // lbRaca
            // 
            lbRaca.AutoSize = true;
            lbRaca.Location = new Point(10, 150);
            lbRaca.Name = "lbRaca";
            lbRaca.Size = new Size(32, 15);
            lbRaca.TabIndex = 15;
            lbRaca.Text = "Raça";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(218, 441);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(63, 23);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(143, 441);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(69, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(71, 441);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(66, 23);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(9, 441);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(56, 23);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lbEspecie
            // 
            lbEspecie.AutoSize = true;
            lbEspecie.Location = new Point(10, 95);
            lbEspecie.Name = "lbEspecie";
            lbEspecie.Size = new Size(46, 15);
            lbEspecie.TabIndex = 7;
            lbEspecie.Text = "Espécie";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(10, 48);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(315, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(473, 480);
            dataGridView1.TabIndex = 15;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "AnimalForm";
            Text = "AnimalForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private Label lbEspecie;
        private TextBox txtNome;
        private DataGridView dataGridView1;
        private Label lbNascimento;
        private Label lbRaca;
        private ComboBox cmbTutor;
        private Label lbNomeAnimal;
        private Label lbPeso;
        private NumericUpDown nudPeso;
        private Label lbSituacao;
        private Label lbTutor;
        private DateTimePicker dtpNascimento;
        private TextBox txtSituacao;
        private TextBox txtRaca;
        private TextBox txtEspecie;
    }
}