using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class Zaznam
    {
        public int Vek { get; set; }
        public long TelCislo { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        


        public Zaznam(string jmeno, string prijmeni, long telCislo, int vek ) {
            Vek = vek;
            TelCislo = telCislo;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            
            
        }
       

        


        public override string ToString()
        {
            return  Jmeno + " " + Prijmeni + " " + Vek + " " + TelCislo; 
        }



    }
}
