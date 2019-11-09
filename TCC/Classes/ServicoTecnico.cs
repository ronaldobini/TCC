using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class ServicoTecnico
    {
        private int id;
        private int idServ;
        private int idTec;
        private int repServ;
        private string obsUser;

        public ServicoTecnico(int id, int idServ, int idTec, int repServ, string obsUser)
        {
            this.id = id;
            this.idServ = idServ;
            this.idTec = idTec;
            this.repServ = repServ;
            this.obsUser = obsUser;
        }
        public ServicoTecnico()
        {

        }

        public int Id { get => id; set => id = value; }
        public int IdServ { get => idServ; set => idServ = value; }
        public Servico Servico { get; set; }
        public int IdTec { get => idTec; set => idTec = value; }
        public UsuarioEmpresa Tecnico{ get; set; }
        public int RepServ { get => repServ; set => repServ = value; }
        public string ObsUser { get => obsUser; set => obsUser = value; }
    }
}