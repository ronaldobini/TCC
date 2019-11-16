using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{

    public class Usuario
    {
        private int id;
        private string login;
        private string senha;
        private string nome;
        private string email;
        private string cpf;
        private string tel1;
        private string tel2;
        private string endereco;
        private int numero;
        private string complemento;
        private string cep;
        private Cidade cidade;
        private int reputacao;
        private MySqlDateTime dataCadastro;
        private MySqlDateTime ultimoLogin;
        private int errosSenha;
        private int block;
        private int nivel;
        private UsuarioEmpresa userEmp;

        public Usuario()
        {

        }
        public Usuario(int id, string login, string senha, string nome, string email,
            string cpf, string tel1, string tel2, string endereco, int numero, string complemento,
            string cep, Cidade cidade, int reputacao, MySqlDateTime dataCadastro, MySqlDateTime ultimoLogin,
            int errosSenha, int block, int nivel, UsuarioEmpresa userEmp)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.tel1 = tel1;
            this.tel2 = tel2;
            this.endereco = endereco;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
            this.cidade = cidade;
            this.reputacao = reputacao;
            this.dataCadastro = dataCadastro;
            this.ultimoLogin = ultimoLogin;
            this.errosSenha = errosSenha;
            this.block = block;
            this.nivel = nivel;
            this.userEmp = userEmp;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Tel1 { get => tel1; set => tel1 = value; }
        public string Tel2 { get => tel2; set => tel2 = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public Cidade Cidade { get => cidade; set => cidade = value; }
        public int Reputacao { get => reputacao; set => reputacao = value; }
        public MySqlDateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public MySqlDateTime UltimoLogin { get => ultimoLogin; set => ultimoLogin = value; }
        public int ErrosSenha { get => errosSenha; set => errosSenha = value; }
        public int Block { get => block; set => block = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public UsuarioEmpresa UserEmp { get => userEmp; set => userEmp = value; }
    }
}