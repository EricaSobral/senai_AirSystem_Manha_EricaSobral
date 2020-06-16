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
    public partial class Novo_Usuario___AirSystem : Form
    {
        UsuarioRepository _usuarioRepository = new UsuarioRepository();
        public Novo_Usuario___AirSystem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void texUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Novo_Usuario___AirSystem_Load(object sender, EventArgs e)
        {

        }

        private void nubtnCadastro_Click(object sender, EventArgs e)
        {
            if (Utils.CamposVazio(this))
            {
                if (nuSenha.Text == nuConfSenha.Text) {
                    Usuario novoUser = new Usuario
                    {
                        Nome = nuNome.Text,
                        Sobrenome = nuSobrenome.Text,
                        NomeUsuario = nuUsuario.Text,
                        Endereco = nuRua.Text,
                        Numero = nuNumero.Text,
                        Nascimento = nuData.Value,
                        Senha = nuSenha.Text,
                        TipoUsuario = nuAdm.Checked
                    };

                    _usuarioRepository.CadastrarUsuario(novoUser);

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    new Login_AirSystem().ShowDialog();
                    this.Close();
                }else
                {
                    MessageBox.Show("As senhas não estão compatives. Tente novamente");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nuUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
