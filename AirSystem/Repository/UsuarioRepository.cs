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
        private static List<Usuario> ListUser;

        public UsuarioRepository()
        {
            if(ListUser == null)
            {
                ListUser = new List<Usuario>();

                ListUser.Add(new Usuario
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
                ListUser.Add(new Usuario
                {
                    Nome = "Alexia",
                    Sobrenome = "Vitoria",
                    Nascimento = Convert.ToDateTime("30/04/2001"),
                    Endereco = "Rua Alexia",
                    Numero = "190",
                    NomeUsuario = "comum",
                    Senha = "comum",
                    TipoUsuario = false 
                });
            }
        }
        public List<Usuario> Listar()
            {
            return ListUser;
            }

        public Usuario LoginUsuario(string Nome, string Senha)
        {
            return ListUser.Find(u => u.Nome == Nome && u.Senha == Senha);
        }
    }
}
