using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisPontos
{
    class distancia
    {
        private double _x1, _x2, _y1, _y2;

        public string ponto1 { set => _x1 = Convert.ToDouble(value); }
        public string ponto2 { set => _x2 = Convert.ToDouble(value); }
        public string ponto3 { set => _y1 = Convert.ToDouble(value); }
        public string ponto4 { set => _y2 = Convert.ToDouble(value); }
        public string Pontos => (Math.Sqrt((_x2 - _x1) * (_x2 - _x1) + (_y2 - _y1) * (_y2 - _y1)) ).ToString();
    }
}
