using AirSystem.Models;
using AirSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class Login_AirSystem : Form
    {
        public Login_AirSystem()
        {
            InitializeComponent();
        }

        UsuarioRepository _usuarioRepository = new UsuarioRepository();

        private void Login_AirSystem_Load(object sender, EventArgs e)
        {

        }

        private void loginUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginbtnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = _usuarioRepository.LoginUsuario(loginUsuario.Text, loginSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado!");
            }
            else if (usuario.TipoUsuario == true)
            {
                new TelaAdministrativo().ShowDialog();
            }
            else
            {
                new TelaUsuarioComum().ShowDialog();
            }
        }

        private void loginbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtnNU_Click(object sender, EventArgs e)
        {
            new Novo_Usuario___AirSystem().ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             
        }
    }
}
