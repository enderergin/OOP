using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class personel:temelTip
    {
        public DateTime IseBaslangıcTarih { get; set; }
        public DateTime IstenCıkısTarih { get; set; }
        public int IzinGunSayisi { get; set; }

        public personel()
        {
            Console.WriteLine("Personel nesnesi çalıştı");
            
        }
    }
}
