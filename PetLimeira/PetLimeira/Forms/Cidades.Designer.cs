namespace PetLimeira.Forms
{
    partial class Cidades
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
            btnCarregar = new Button();
            label1 = new Label();
            cmbUf = new ComboBox();
            bntFiltrar = new Button();
            dataGridView1 = new DataGridView();
            txtMinimo = new TextBox();
            txtMaximo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(12, 12);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(109, 23);
            btnCarregar.TabIndex = 0;
            btnCarregar.Text = "carregar dados";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Filtrar por:";
            // 
            // cmbUf
            // 
            cmbUf.FormattingEnabled = true;
            cmbUf.Items.AddRange(new object[] { "TODOS", "SP", "MG", "PR", "RJ", "BA", "RS", "GO" });
            cmbUf.Location = new Point(203, 13);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(121, 23);
            cmbUf.TabIndex = 2;
            cmbUf.SelectedIndexChanged += cmbUf_SelectedIndexChanged;
            // 
            // bntFiltrar
            // 
            bntFiltrar.Location = new Point(546, 12);
            bntFiltrar.Name = "bntFiltrar";
            bntFiltrar.Size = new Size(75, 23);
            bntFiltrar.TabIndex = 3;
            bntFiltrar.Text = "Filtrar Dados";
            bntFiltrar.UseVisualStyleBackColor = true;
            bntFiltrar.Click += bntFiltrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(679, 396);
            dataGridView1.TabIndex = 4;
            // 
            // txtMinimo
            // 
            txtMinimo.Location = new Point(330, 12);
            txtMinimo.Name = "txtMinimo";
            txtMinimo.PlaceholderText = "População de...";
            txtMinimo.Size = new Size(89, 23);
            txtMinimo.TabIndex = 5;
            // 
            // txtMaximo
            // 
            txtMaximo.Location = new Point(425, 12);
            txtMaximo.Name = "txtMaximo";
            txtMaximo.PlaceholderText = "população até...";
            txtMaximo.Size = new Size(100, 23);
            txtMaximo.TabIndex = 6;
            // 
            // Cidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaximo);
            Controls.Add(txtMinimo);
            Controls.Add(dataGridView1);
            Controls.Add(bntFiltrar);
            Controls.Add(cmbUf);
            Controls.Add(label1);
            Controls.Add(btnCarregar);
            Name = "Cidades";
            Text = "Cidades";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarregar;
        private Label label1;
        private ComboBox cmbUf;
        private Button bntFiltrar;
        private DataGridView dataGridView1;
        private TextBox txtMinimo;
        private TextBox txtMaximo;
    }
}