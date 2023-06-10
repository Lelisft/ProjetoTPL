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
    public partial class CadastroUsuarioForm : Form
    {
        public CadastroUsuarioForm()
        {
            InitializeComponent();
        }

       public bool alterar;
       public int ID;

        private void salvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAO user = new UsuarioDAO();

                if (alterar)
                {
                    user.Atualizar(ID, nomeTextBox.Text, senhaTextBox.Text, Convert.ToInt32(Convert.ToBoolean(ativoComboBox.Text)));
                    MessageBox.Show("Cadastro alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    user.Adicionar(nomeTextBox.Text, senhaTextBox.Text, Convert.ToInt32(Convert.ToBoolean(ativoComboBox.Text)));
                    MessageBox.Show("Cadastro efetuado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            finally
            {
                alterar = false;    
                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            alterar = false;
            this.Close();
        }
    }
}
