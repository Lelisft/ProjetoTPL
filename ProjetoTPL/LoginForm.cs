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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logarButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            UsuarioDAO user = new UsuarioDAO();

            usuario = user.ValidarLogin(nomeTextBox.Text, senhaTextBox.Text);

            try
            {
                if (usuario.Nome == nomeTextBox.Text && usuario.Senha == senhaTextBox.Text && usuario.ativo == 1)
                {
                    PrincipalForm principalForm = new PrincipalForm();

                    principalForm.ID = Convert.ToString(usuario.ID);
                    principalForm.User = usuario.Nome;

                    principalForm.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha Inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Usuário ou senha Inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cadastrolabel_Click(object sender, EventArgs e)
        {
            CadastroUsuarioForm cadastroUser = new CadastroUsuarioForm();
            Usuario usuario = new Usuario();
            cadastroUser.ID = usuario.ID;
            cadastroUser.alterar = false;

            cadastroUser.Show();
        }
    }
}
