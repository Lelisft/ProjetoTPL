namespace ProjetoTPL
{
    partial class CadastroUsuarioForm
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
            this.salvarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoComboBox = new System.Windows.Forms.ComboBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.ativoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // salvarButton
            // 
            this.salvarButton.BackColor = System.Drawing.Color.SeaGreen;
            this.salvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salvarButton.Location = new System.Drawing.Point(121, 228);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 0;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelarButton.Location = new System.Drawing.Point(214, 228);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(40, 55);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(319, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(40, 106);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(319, 20);
            this.senhaTextBox.TabIndex = 3;
            // 
            // ativoComboBox
            // 
            this.ativoComboBox.FormattingEnabled = true;
            this.ativoComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.ativoComboBox.Location = new System.Drawing.Point(40, 156);
            this.ativoComboBox.Name = "ativoComboBox";
            this.ativoComboBox.Size = new System.Drawing.Size(172, 21);
            this.ativoComboBox.TabIndex = 4;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nomeLabel.Location = new System.Drawing.Point(37, 29);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 5;
            this.nomeLabel.Text = "Nome:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.senhaLabel.Location = new System.Drawing.Point(37, 90);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(41, 13);
            this.senhaLabel.TabIndex = 6;
            this.senhaLabel.Text = "Senha:";
            // 
            // ativoLabel
            // 
            this.ativoLabel.AutoSize = true;
            this.ativoLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ativoLabel.Location = new System.Drawing.Point(37, 140);
            this.ativoLabel.Name = "ativoLabel";
            this.ativoLabel.Size = new System.Drawing.Size(34, 13);
            this.ativoLabel.TabIndex = 7;
            this.ativoLabel.Text = "Ativo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 192);
            this.panel1.TabIndex = 8;
            // 
            // CadastroUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 263);
            this.Controls.Add(this.ativoLabel);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.ativoComboBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox ativoComboBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label ativoLabel;
        private System.Windows.Forms.Panel panel1;
    }
}