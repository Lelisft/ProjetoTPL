using ProjetoTPL.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTPL
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        public string ID;
        public string User;

        private void PrincipalForm_Activated(object sender, EventArgs e)
        {
            LivroDAO livroDAO = new LivroDAO();

            var registros = livroDAO.BuscarTodos();
            livrosDataGridView.DataSource = registros;

            userIDToolStripLabel.Text = userIDToolStripLabel.Text +' '+ID;
            usuarioToolStripLabel.Text = usuarioToolStripLabel.Text + ' ' + User;
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            LivroForm form = new LivroForm();

            form.alterar = false;

            form.Show();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (livrosDataGridView.CurrentCell != null)
            {
                LivroForm form = new LivroForm();

                form.alterar = true;
                form.ID = Convert.ToInt32(livrosDataGridView.CurrentRow.Cells["ID"].Value.ToString());

                form.Show();
            }
            else
            {
                MessageBox.Show("Selecione um registro para Alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (livrosDataGridView.CurrentCell != null)
            {
                LivroDAO livro = new LivroDAO();
                try
                {
                    livro.Excluir(Convert.ToInt32(livrosDataGridView.CurrentRow.Cells["ID"].Value.ToString()));
                }
                finally
                {
                    var registros = livro.BuscarTodos();
                    livrosDataGridView.DataSource = registros;
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para Excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            LivroDAO livro = new LivroDAO();
            List<Livro> lvList = new List<Livro>();
            try
            {
                lvList.Add(livro.BuscarById(Convert.ToInt32(buscarLivroTextBox.Text)));
                livrosDataGridView.DataSource = lvList;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Nenhum Registro Encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuarioForm cadastroUser = new CadastroUsuarioForm();
            Usuario usuario = new Usuario();
            cadastroUser.ID = usuario.ID;
            cadastroUser.alterar = false;

            cadastroUser.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorForm autorForm = new AutorForm();

            autorForm.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inserirButton_Click(sender, e);
        }
    }
}
