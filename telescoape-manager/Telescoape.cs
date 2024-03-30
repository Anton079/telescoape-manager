using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telescoape_manager
{
    public class Telescoape
    {
        private string _model;
        private int _distantaFocala;
        private int _apertura;
        private string _tipMontura;

        public Telescoape(string model, int distanaFocala, int aperuta, string tipMontura)
        {
            Model = model;
            DistantaFocala = distanaFocala;
            Apertura = aperuta;
            TipMontura = tipMontura;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int DistantaFocala
        {
            get { return _distantaFocala; }
            set {  _distantaFocala = value; }
        }

        public int Apertura
        {
            get { return _apertura; }
            set { _apertura = value; }
        }

        public string TipMontura
        {
            get { return _tipMontura; }
            set { _tipMontura = value; }
        }

        public string TelescopInfo()
        {
            string text = " ";
            text += "Model " + Model + "\n";
            text += "Distanta Focala " + DistantaFocala + "\n";
            text += "Apertura " + Apertura + "\n";
            text += "Tip Montura " + TipMontura + "\n";
            return text;
        }
    }
}
