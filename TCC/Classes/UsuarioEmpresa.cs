using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class UsuarioEmpresa
    {
        private int id;
        private int idUsuario;
        private int idEmpresa;
        private string funcao;
        private int nivelEmp;
        private int qtdServicos;
        private string nivelEscolar;
        private string formacao;
        private int repMedia;        
        public UsuarioEmpresa(int id, int idUsuario, int idEmpresa, string funcao, int nivelEmp, int qtdServicos,
            string nivelEscolar, string formacao, int repMedia)
        {
            this.id = id;
            this.idUsuario = idUsuario;
            this.idEmpresa = idEmpresa;
            this.funcao = funcao;
            this.nivelEmp = nivelEmp;
            this.qtdServicos = qtdServicos;
            this.nivelEscolar = nivelEscolar;
            this.formacao = formacao;
            this.repMedia = repMedia;
        }

        public UsuarioEmpresa()
        {
        }

        public int Id { get => id; set => id = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public Usuario Usuario { get; set; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public Empresa Empresa { get; set; }
        public string Funcao { get => funcao; set => funcao = value; }
        public int NivelEmp { get => nivelEmp; set => nivelEmp = value; }
        public int QtdServicos { get => qtdServicos; set => qtdServicos = value; }
        public string NivelEscolar { get => nivelEscolar; set => nivelEscolar = value; }
        public Escolaridade Escolaridade { get; set; }
        public string Formacao { get => formacao; set => formacao = value; }
        public int RepMedia { get => repMedia; set => repMedia = value; }

    }
}