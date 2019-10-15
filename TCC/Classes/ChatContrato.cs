using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class ChatContrato
    {
        private int id;
        private int idServ;
        private int idUser;
        private int idUserEmp;

        public ChatContrato(int id, int idServ, int idUser, int idUserEmp)
        {
            this.id = id;
            this.idServ = idServ;
            this.idUser = idUser;
            this.idUserEmp = idUserEmp;
        }
        public ChatContrato()
        {
        }

        public int Id { get => id; set => id = value; }
        public int IdServ { get => idServ; set => idServ = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public int IdUserEmp { get => idUserEmp; set => idUserEmp = value; }
    }
}