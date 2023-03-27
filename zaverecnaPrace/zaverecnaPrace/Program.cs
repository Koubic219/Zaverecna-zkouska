using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace zaverecnaPrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evidence evidence = new Evidence();
            Obrazovka telo = new Obrazovka(evidence);
            telo.VyberAkce();
           
        }


    }
    
}
