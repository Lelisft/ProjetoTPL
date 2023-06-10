namespace ProjetoTPL
{
    partial class LoginForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.logarButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.cadastrolabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logarButton
            // 
            this.logarButton.BackColor = System.Drawing.Color.OrangeRed;
            this.logarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logarButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logarButton.Location = new System.Drawing.Point(76, 238);
            this.logarButton.Name = "logarButton";
            this.logarButton.Size = new System.Drawing.Size(259, 38);
            this.logarButton.TabIndex = 0;
            this.logarButton.Text = "Login";
            this.logarButton.UseVisualStyleBackColor = false;
            this.logarButton.Click += new System.EventHandler(this.logarButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(76, 117);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(259, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(76, 168);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(259, 20);
            this.senhaTextBox.TabIndex = 2;
            // 
            // cadastrolabel
            // 
            this.cadastrolabel.AutoSize = true;
            this.cadastrolabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cadastrolabel.Location = new System.Drawing.Point(76, 195);
            this.cadastrolabel.Name = "cadastrolabel";
            this.cadastrolabel.Size = new System.Drawing.Size(198, 13);
            this.cadastrolabel.TabIndex = 3;
            this.cadastrolabel.Text = "Ainda não possui Cadastro? Clique Aqui!";
            this.cadastrolabel.Click += new System.EventHandler(this.cadastrolabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.loginPictureBox);
            this.panel1.Location = new System.Drawing.Point(56, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 239);
            this.panel1.TabIndex = 4;
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackgroundImage = global::ProjetoTPL.Properties.Resources.livros;
            this.loginPictureBox.InitialImage = global::ProjetoTPL.Properties.Resources.livros;
            this.loginPictureBox.Location = new System.Drawing.Point(132, 13);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(34, 32);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 0;
            this.loginPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 321);
            this.Controls.Add(this.cadastrolabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.logarButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bem-Vindo (a) ao Book Online";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logarButton;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label cadastrolabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox loginPictureBox;
    }
}

