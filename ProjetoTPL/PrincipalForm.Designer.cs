namespace ProjetoTPL
{
    partial class PrincipalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.geralMenuStrip = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.buscarLivroTextBox = new System.Windows.Forms.TextBox();
            this.buscarLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.userIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.aToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.usuarioToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.sistemaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgPanelP = new System.Windows.Forms.Panel();
            this.buscarButton = new System.Windows.Forms.Button();
            this.geralMenuStrip.SuspendLayout();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // geralMenuStrip
            // 
            this.geralMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.geralMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.geralMenuStrip.Name = "geralMenuStrip";
            this.geralMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.geralMenuStrip.TabIndex = 0;
            this.geralMenuStrip.Text = "Menu";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meuPerfilToolStripMenuItem,
            this.cadastrosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // meuPerfilToolStripMenuItem
            // 
            this.meuPerfilToolStripMenuItem.Name = "meuPerfilToolStripMenuItem";
            this.meuPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meuPerfilToolStripMenuItem.Text = "Meu Perfil";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.livroToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPanel.Controls.Add(this.excluirButton);
            this.btnPanel.Controls.Add(this.alterarButton);
            this.btnPanel.Controls.Add(this.inserirButton);
            this.btnPanel.Location = new System.Drawing.Point(12, 27);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(268, 41);
            this.btnPanel.TabIndex = 1;
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livroToolStripMenuItem.Text = "Livro";
            this.livroToolStripMenuItem.Click += new System.EventHandler(this.livroToolStripMenuItem_Click);
            // 
            // inserirButton
            // 
            this.inserirButton.BackColor = System.Drawing.Color.OrangeRed;
            this.inserirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inserirButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inserirButton.Location = new System.Drawing.Point(3, 6);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(83, 32);
            this.inserirButton.TabIndex = 0;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = false;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.BackColor = System.Drawing.Color.OrangeRed;
            this.alterarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alterarButton.Location = new System.Drawing.Point(92, 6);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(83, 32);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = false;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.BackColor = System.Drawing.Color.OrangeRed;
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.excluirButton.Location = new System.Drawing.Point(181, 6);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(83, 32);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // livrosDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.livrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosDataGridView.Location = new System.Drawing.Point(12, 74);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.livrosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.livrosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.livrosDataGridView.Size = new System.Drawing.Size(487, 289);
            this.livrosDataGridView.TabIndex = 2;
            // 
            // buscarLivroTextBox
            // 
            this.buscarLivroTextBox.Location = new System.Drawing.Point(76, 371);
            this.buscarLivroTextBox.Name = "buscarLivroTextBox";
            this.buscarLivroTextBox.Size = new System.Drawing.Size(373, 20);
            this.buscarLivroTextBox.TabIndex = 3;
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Location = new System.Drawing.Point(11, 374);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(59, 13);
            this.buscarLabel.TabIndex = 5;
            this.buscarLabel.Text = "ID do Livro";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripLabel,
            this.aToolStripSeparator,
            this.usuarioToolStripLabel,
            this.bToolStripSeparator});
            this.toolStrip.Location = new System.Drawing.Point(0, 408);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // userIDToolStripLabel
            // 
            this.userIDToolStripLabel.Name = "userIDToolStripLabel";
            this.userIDToolStripLabel.Size = new System.Drawing.Size(21, 22);
            this.userIDToolStripLabel.Text = "ID:";
            // 
            // aToolStripSeparator
            // 
            this.aToolStripSeparator.Name = "aToolStripSeparator";
            this.aToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // usuarioToolStripLabel
            // 
            this.usuarioToolStripLabel.Name = "usuarioToolStripLabel";
            this.usuarioToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.usuarioToolStripLabel.Text = "Usuário:";
            // 
            // bToolStripSeparator
            // 
            this.bToolStripSeparator.Name = "bToolStripSeparator";
            this.bToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // sistemaLabel
            // 
            this.sistemaLabel.AutoSize = true;
            this.sistemaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sistemaLabel.Location = new System.Drawing.Point(567, 30);
            this.sistemaLabel.Name = "sistemaLabel";
            this.sistemaLabel.Size = new System.Drawing.Size(170, 32);
            this.sistemaLabel.TabIndex = 7;
            this.sistemaLabel.Text = "Book Online";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(563, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gerenciador de Biblioteca";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // imgPanelP
            // 
            this.imgPanelP.BackgroundImage = global::ProjetoTPL.Properties.Resources.escritor;
            this.imgPanelP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPanelP.Location = new System.Drawing.Point(505, 106);
            this.imgPanelP.Name = "imgPanelP";
            this.imgPanelP.Size = new System.Drawing.Size(283, 257);
            this.imgPanelP.TabIndex = 9;
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarButton.BackgroundImage = global::ProjetoTPL.Properties.Resources.lupa;
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.Location = new System.Drawing.Point(455, 369);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(31, 32);
            this.buscarButton.TabIndex = 4;
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.imgPanelP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sistemaLabel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buscarLabel);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.buscarLivroTextBox);
            this.Controls.Add(this.livrosDataGridView);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.geralMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.geralMenuStrip;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inicio";
            this.Activated += new System.EventHandler(this.PrincipalForm_Activated);
            this.geralMenuStrip.ResumeLayout(false);
            this.geralMenuStrip.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip geralMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.TextBox buscarLivroTextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel userIDToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator aToolStripSeparator;
        private System.Windows.Forms.ToolStripLabel usuarioToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator bToolStripSeparator;
        private System.Windows.Forms.Label sistemaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Panel imgPanelP;
    }
}