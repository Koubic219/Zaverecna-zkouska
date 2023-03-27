using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class Obrazovka
    {

        private Evidence evidence { get; }

        public Obrazovka(Evidence evidence) {
            this.evidence = evidence;
        }


        

        public void VypisUdaje()
        {

        }

        public void VypisUvodniObrazovku()
        {
            
            Console.WriteLine("---------------------------" );
            Console.WriteLine("Evidence pojistěných ");
            Console.WriteLine( "---------------------------");
            Console.WriteLine( " ");
            Console.WriteLine( "Vyberte si akci: ");
            Console.WriteLine( "1 - Pridat nového pojistěného: ");
            Console.WriteLine( "2 - Vypsat všechny pojistené: ");
            Console.WriteLine( "3 - Vyhledat pojisteného: ");
            Console.WriteLine( "4 - Konec" );
            Console.WriteLine(" ");
        }
        

        public string NactiJmeno()
        {

            return NactiText("Zadejte jmeno znovu: ");
        }
        public string NactiPrijmeni()
        {

            return NactiText("Zadejte přijmení znovu: ");
        }

        public string NactiText(string chybovaHlaska)
        {
            string zadej;
            while (string.IsNullOrWhiteSpace(zadej = Console.ReadLine()))
            {
                Console.WriteLine(chybovaHlaska);
            }
            return zadej;
        }


        public void VyberAkce()
        {

            VypisUvodniObrazovku();



            char volba = Console.ReadKey().KeyChar;


            while (volba != '4')
            {
                
                
                
                switch (volba)
                {
                    case '1':
                        Console.WriteLine( " ");
                        Console.WriteLine( "Zadejte jméno pojistného: ");
                        string jmeno = NactiJmeno();
                        Console.WriteLine("Zadejte přijmení: " );
                        string prijmeni= NactiPrijmeni();
                        Console.WriteLine("Zadejte telefoní číslo: ");
                        long cislo;
                        while (!long.TryParse(Console.ReadLine(), out cislo))
                        {
                            Console.WriteLine("Chybné zadání, zadejte znovu telefoní číslo: ");
                        }
                        Console.WriteLine("Zadejte věk: ");
                        int vek;
                        while (!int.TryParse(Console.ReadLine(), out vek))
                        {
                            Console.WriteLine("Chybné zadání, zadejte znovu věk: ");
                        } 
                            
                            

                        evidence.Pridej(jmeno, prijmeni,cislo,vek);
                        break;
                    case '2':
                        
                        evidence.VypisVsechny();
                       
                        break;
                    case '3':
                        Console.WriteLine("Zadejte jméno pojistného: ");
                        string jmenoHledej = NactiJmeno();
                        Console.WriteLine("Zadejte přijmení: ");
                        string prijmeniHledej = NactiPrijmeni();
                        evidence.VypisNalezene(jmenoHledej,prijmeniHledej);


                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                
                VypisUvodniObrazovku();
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();


            }
        } 



    }
}
