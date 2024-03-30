using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telescoape_manager
{
    public class InchiriereService
    {
        private List<Inchiriere> _Inchiriere;

        public InchiriereService()
        {
            _Inchiriere = new List<Inchiriere>();
            this.LoadData();
        }

        public void LoadData()
        {
            Inchiriere Inchiriere1 = new Inchiriere(1, 5, 1);
            Inchiriere Inchiriere2 = new Inchiriere(3, 1, 5);
            Inchiriere Inchiriere3 = new Inchiriere(2, 4, 4);
            Inchiriere Inchiriere4 = new Inchiriere(4, 4, 4);
            Inchiriere Inchiriere5 = new Inchiriere(5, 2, 1);

            this._Inchiriere.Add(Inchiriere1);
            this._Inchiriere.Add(Inchiriere2);
            this._Inchiriere.Add(Inchiriere3);
            this._Inchiriere.Add(Inchiriere4);
            this._Inchiriere.Add(Inchiriere5);
        }

        public void AfisareInchiriere()
        {
            foreach (Inchiriere x in _Inchiriere)
            {
                Console.WriteLine(x.InchiriereInfo());
            }
        }
    }
}
