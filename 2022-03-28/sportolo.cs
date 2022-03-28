using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_28
{
    class sportolo
    {
        public string Név { get; set; }
        public string Első { get; set; }
        public string Utolsó { get; set; }
        public int Súly { get; set; }
        public int Magasság { get; set; }
        public sportolo(string sor)
        {
            string[] t = sor.Split('');
            Név = t[0];
            Első = t[1];
            Utolsó = t[2];
            
            
        }
    }
}
