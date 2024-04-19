using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telescoape_manager
{
    public class UserService
    {
        private List<User> _UserS;

        public UserService()
        {
            _UserS = new List<User>();
            this.LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(this.GetFilePath()))
                {
                    string line = "";
                    while((line = sr.ReadLine()) != null)
                    {
                        User user = new User(line);
                        this._UserS.Add(user);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private String GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "users");

            return file;
        }

        public string ToSaveAll()
        {
            String save = "";

            for (int i = 0; i < _userS.Count - 1; i++)
            {
                save += _userS[i].ToSave() + "\n";
            }

            save += _userS[_userS.Count - 1].ToSave();

            return save;
        }


        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.GetFilePath()))
                {
                    sw.Write(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GenerateNr()
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 10000000);
        }

        public void AfisareUser()
        {
            foreach (User x in _UserS)
            {
                Console.WriteLine(x.UserInfo());
            }
        }
    }
}
