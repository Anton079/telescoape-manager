using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telescoape_manager
{
    public class TelescoapeService
    {
        private List <Telescoape> _telescoapes;

        public TelescoapeService()
        {
            _telescoapes = new List<Telescoape>();
            this.LoadData();
        }

        public void LoadData()
        {
            Telescoape telescop1 = new Telescoape("Celestron", 1000, 200, "EQ3");
            Telescoape telescop2 = new Telescoape("Konus", 1500, 150, "EQ3");
            Telescoape telescop3 = new Telescoape("reflector", 2000, 250, "EQ3");
            Telescoape telescop4 = new Telescoape("Levenhuk", 5000, 600, "EQ4");
            Telescoape telescop5 = new Telescoape("Celestron", 500, 50, "EQ2");

            this._telescoapes.Add(telescop1);
            this._telescoapes.Add(telescop2);
            this._telescoapes.Add(telescop3);
            this._telescoapes.Add(telescop4);
            this._telescoapes.Add(telescop5);
        }

        public void AfisareTelescoape()
        {
            foreach (Telescoape x in _telescoapes)
            {
                Console.WriteLine(x.TelescopInfo());
            }
        }
    }
}
