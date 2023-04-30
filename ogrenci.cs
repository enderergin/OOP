using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ogrenci:temelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }

        public ogrenci()
        {
            Console.WriteLine("Öğrenci nesnesi çalıştı");
            
        }
    }
}
