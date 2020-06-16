using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repository
{
    class UsuarioRepository
    {
        private static List<Usuario> ListUsuario;

        public UsuarioRepository()
        {
            if(ListUsuario == null)
            {
                ListUsuario = new List<Usuario>();

                ListUsuario.Add(new Usuario
                {
                    Nome = "Erica",
                    Sobrenome = "Sobral",
                    Nascimento = Convert.ToDateTime("30/09/1995"),
                    Endereco = "Mal Pimentel",
                    Numero = "400",
                    NomeUsuario = "adm",
                    Senha = "adm",
                    TipoUsuario = true 
                });
                ListUsuario.Add(new Usuario
                {
                    Nome = "Alexia",
                    Sobrenome = "Vitoria",
                    Nascimento = Convert.ToDateTime("30/04/2001"),
                    Endereco = "Rua Alexia",
                    Numero = "190",
                    NomeUsuario = "alexia",
                    Senha = "er",
                    TipoUsuario = false 
                });
            }
        }
        public List<Usuario> Listar()
            {
            return ListUsuario;
            }

        public Usuario LoginUsuario(string nome, string senha)
        {
            return ListUsuario.Find(u => u.Nome == nome && u.Senha == senha);
        }

        public void CadastrarUsuario (Usuario novoUsuario)
        {
            ListUsuario.Add(novoUsuario);
        }
    }
}
