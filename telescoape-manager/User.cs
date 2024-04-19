using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace telescoape_manager
{
    public class User
    {
        private int _id;
        private string _email;
        private string _password;
        private int _phone;

        public User(String proprietati)
        {
            String[] token = proprietati.Split(',');

            this._id = int.Parse(token[0]);
            this._email = token[1];
            this._password = token[2];
            this._phone = int.Parse(token[3]);

        }

        public User(int Id, string Email, string Password, int Phone)
        {
            Id = id;
            Email = email;
            Password = password;
            Phone = phone;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int phone
        {
            get { return _phone; }

        }

        public string UserInfo()
        {
            string text = " ";
            text += "Id " + id + "\n";
            text += "Email " + email + "\n";
            text += "Password " + email + "\n";
            text += "Phone " + phone + "\n";
            return text;
        }

        public string ToSave()
        {
            return this._id + "," + this._email + "," + this._password + "," + this._phone;
        }
    }
}
