namespace ProjetoTPL
{
    partial class LivroForm
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idAutorlabel = new System.Windows.Forms.Label();
            this.autorComboBox = new System.Windows.Forms.ComboBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.livroPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // salvarButton
            // 
            this.salvarButton.BackColor = System.Drawing.Color.OliveDrab;
            this.salvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salvarButton.Location = new System.Drawing.Point(120, 208);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(88, 34);
            this.salvarButton.TabIndex = 0;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelarButton.Location = new System.Drawing.Point(222, 208);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(88, 34);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(47, 44);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(335, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nomeLabel.Location = new System.Drawing.Point(47, 27);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 3;
            this.nomeLabel.Text = "Nome:";
            // 
            // idAutorlabel
            // 
            this.idAutorlabel.AutoSize = true;
            this.idAutorlabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idAutorlabel.Location = new System.Drawing.Point(47, 129);
            this.idAutorlabel.Name = "idAutorlabel";
            this.idAutorlabel.Size = new System.Drawing.Size(35, 13);
            this.idAutorlabel.TabIndex = 5;
            this.idAutorlabel.Text = "Autor:";
            // 
            // autorComboBox
            // 
            this.autorComboBox.FormattingEnabled = true;
            this.autorComboBox.Location = new System.Drawing.Point(47, 145);
            this.autorComboBox.Name = "autorComboBox";
            this.autorComboBox.Size = new System.Drawing.Size(213, 21);
            this.autorComboBox.TabIndex = 6;
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.generoLabel.Location = new System.Drawing.Point(47, 80);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(45, 13);
            this.generoLabel.TabIndex = 8;
            this.generoLabel.Text = "Genero:";
            // 
            // generoComboBox
            // 
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Comédia",
            "Romance",
            "Ação",
            "Aventura",
            "Artes Marciais",
            "Guerra",
            "Terror"});
            this.generoComboBox.Location = new System.Drawing.Point(47, 96);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(213, 21);
            this.generoComboBox.TabIndex = 9;
            // 
            // livroPanel
            // 
            this.livroPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.livroPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.livroPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.livroPanel.Location = new System.Drawing.Point(38, 12);
            this.livroPanel.Name = "livroPanel";
            this.livroPanel.Size = new System.Drawing.Size(359, 190);
            this.livroPanel.TabIndex = 10;
            // 
            // LivroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 254);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.autorComboBox);
            this.Controls.Add(this.idAutorlabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.livroPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LivroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livro";
            this.Activated += new System.EventHandler(this.LivroForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LivroForm_FormClosed);
            this.Load += new System.EventHandler(this.LivroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label idAutorlabel;
        private System.Windows.Forms.ComboBox autorComboBox;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.Panel livroPanel;
    }
}