namespace PetLimeira.Forms
{
    partial class loginForm
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
            lbTitulo = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lbLogin = new Label();
            lbSenha = new Label();
            btnEntrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(60, 22);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(192, 30);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Acesso ao Sistema";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(58, 101);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(192, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(60, 167);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(192, 23);
            txtSenha.TabIndex = 2;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(58, 83);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(37, 15);
            lbLogin.TabIndex = 3;
            lbLogin.Text = "Login";
            lbLogin.Click += label1_Click;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(58, 149);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 5;
            lbSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(60, 230);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(163, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 316);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(lbSenha);
            Controls.Add(lbLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lbTitulo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - acesso ao sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lbLogin;
        private Label lbSenha;
        private Button btnEntrar;
        private Button btnCancelar;
    }
}