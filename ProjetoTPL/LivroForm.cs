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
    public partial class LivroForm : Form
    {
        public LivroForm()
        {
            InitializeComponent();
        }

        public int ID;
        public bool alterar;

        private void salvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LivroDAO livro = new LivroDAO();

                if (alterar)
                {
                    livro.Atualizar(ID, autorComboBox.Text, nomeTextBox.Text, generoComboBox.Text);
                    MessageBox.Show("Cadastro alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    livro.Adicionar(Convert.ToInt32(autorComboBox.Text), nomeTextBox.Text, generoComboBox.Text);
                    MessageBox.Show("Cadastro efetuado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            finally
            {
                alterar = false;
                this.Close();
            }
        }

        private void LivroForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LivroForm_Activated(object sender, EventArgs e)
        {
            LivroDAO livros = new LivroDAO();
            Livro lv = new Livro();

            if (alterar)
            {
                lv = livros.BuscarById(ID);

                nomeTextBox.Text = lv.NomeLivro;
                autorComboBox.Text = Convert.ToString(lv.IDAutor);
                generoComboBox.Text = lv.Genero;
            }
            
            List<Autor> autorLsit = new List<Autor>();

            AutorDAO listar = new AutorDAO();

            autorLsit = listar.BuscarTodos();

            foreach (Autor autor in autorLsit) { autorComboBox.Items.Add(autor.ID); }
        }

        private void LivroForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LivroDAO livros = new LivroDAO();

            livros.BuscarTodos();
        }
    }
}
