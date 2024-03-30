using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace telescoape_manager
{
    public class Inchiriere
    {
        private int _id;
        private int _idUser;
        private int _idTelescop;

        public Inchiriere(int id, int idUser, int idTelescop)
        {
            Id = id;
            IdUser = idUser;
            IdTelescop = idTelescop;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public int IdTelescop
        {
            get { return _idTelescop; }
            set { _idTelescop = value; }
        }

        public string InchiriereInfo()
        {
            string text = " ";
            text += "Idul" + Id + "\n";
            text += "Idul User " + IdUser + "\n";
            text += "Id Telescop" + IdTelescop + "\n";
            return text;
        }

    }
}
