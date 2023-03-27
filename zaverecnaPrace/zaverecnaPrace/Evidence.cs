using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace zaverecnaPrace
{
    internal class Evidence
    {
     
        private List<Zaznam> zaznamy;

        

        public Evidence()
        {
            zaznamy = new List<Zaznam>();
        }

        public void Pridej(string jmeno, string prijmeni,long telCislo,int vek)
        {
            
            zaznamy.Add(new Zaznam(jmeno, prijmeni, telCislo, vek));
            

        }

        public void VypisNalezene(string jmeno,string prijmeni)
        {
            int nalezenoPocet = 0;
            foreach (Zaznam i in zaznamy)
            {

                if ((i.Jmeno.ToLower()==jmeno.ToLower())&&(i.Prijmeni.ToLower()==prijmeni.ToLower())) {
                    Console.WriteLine(i);
                    nalezenoPocet++;
                } 
            
        
            }
            Console.WriteLine("Vypsaných pojistných osob:{0} ",nalezenoPocet );
        }

        

       
        public void VypisVsechny()
        {
            
            
            foreach (Zaznam i in zaznamy)
            {
                
                Console.WriteLine(i);
                
                
            }


        }


        



        



    }
}
