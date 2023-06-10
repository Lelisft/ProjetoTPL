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
    public partial class AutorForm : Form
    {
        public AutorForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarAutorButton_Click(object sender, EventArgs e)
        {
            try
            {
                AutorDAO dao = new AutorDAO();

                dao.Adicionar(nomeTextBox.Text);

                MessageBox.Show("Autor cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
