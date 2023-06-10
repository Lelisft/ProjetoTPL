namespace ProjetoTPL
{
    partial class AutorForm
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
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.autorPanel = new System.Windows.Forms.Panel();
            this.salvarAutorButton = new System.Windows.Forms.Button();
            this.autorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(79, 115);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(259, 20);
            this.senhaTextBox.TabIndex = 7;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(79, 64);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(259, 20);
            this.nomeTextBox.TabIndex = 6;
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarButton.Location = new System.Drawing.Point(193, 139);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(86, 31);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // autorPanel
            // 
            this.autorPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.autorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autorPanel.Controls.Add(this.salvarAutorButton);
            this.autorPanel.Controls.Add(this.cancelarButton);
            this.autorPanel.Location = new System.Drawing.Point(57, 26);
            this.autorPanel.Name = "autorPanel";
            this.autorPanel.Size = new System.Drawing.Size(305, 191);
            this.autorPanel.TabIndex = 9;
            this.autorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // salvarAutorButton
            // 
            this.salvarAutorButton.BackColor = System.Drawing.Color.SeaGreen;
            this.salvarAutorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarAutorButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarAutorButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salvarAutorButton.Location = new System.Drawing.Point(20, 139);
            this.salvarAutorButton.Name = "salvarAutorButton";
            this.salvarAutorButton.Size = new System.Drawing.Size(86, 31);
            this.salvarAutorButton.TabIndex = 6;
            this.salvarAutorButton.Text = "Salvar";
            this.salvarAutorButton.UseVisualStyleBackColor = false;
            this.salvarAutorButton.Click += new System.EventHandler(this.salvarAutorButton_Click);
            // 
            // AutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 235);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.autorPanel);
            this.Name = "AutorForm";
            this.Text = "AutorForm";
            this.autorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Panel autorPanel;
        private System.Windows.Forms.Button salvarAutorButton;
    }
}