using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektim
{
    internal class Calisanlar
    {
        public int ID;
        private string isim;
        private string soyisim;
        private string departman;
        private int maas;

        public int ID1 { get => ID; set => ID = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Departman { get => departman; set => departman = value; }
        public int Maas { get => maas; set => maas = value; }

        public void isimler()
        {
            
        }
    }
}
