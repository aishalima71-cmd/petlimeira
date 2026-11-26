namespace PetLimeira
{
    partial class PrecosGasolinaEtanol
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
            bntCarregar = new Button();
            label1 = new Label();
            cmbUf = new ComboBox();
            btnFiltrar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bntCarregar
            // 
            bntCarregar.Location = new Point(12, 12);
            bntCarregar.Name = "bntCarregar";
            bntCarregar.Size = new Size(96, 23);
            bntCarregar.TabIndex = 0;
            bntCarregar.Text = "carregar dados";
            bntCarregar.UseVisualStyleBackColor = true;
            bntCarregar.Click += bntCarregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Filtrar por:";
            // 
            // cmbUf
            // 
            cmbUf.FormattingEnabled = true;
            cmbUf.Items.AddRange(new object[] { "TODOS", "SP", "MG", "PR", "RJ", "BA", "RS", "GO" });
            cmbUf.Location = new Point(183, 13);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(121, 23);
            cmbUf.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(310, 13);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(96, 23);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar dados";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 397);
            dataGridView1.TabIndex = 4;
            // 
            // PrecosGasolinaEtanol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbUf);
            Controls.Add(label1);
            Controls.Add(bntCarregar);
            Name = "PrecosGasolinaEtanol";
            Text = "PrecosGasolinaEtanol";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntCarregar;
        private Label label1;
        private ComboBox cmbUf;
        private Button btnFiltrar;
        private DataGridView dataGridView1;
    }
}