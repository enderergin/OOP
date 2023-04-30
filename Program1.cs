using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bilgisayar b1 = new bilgisayar();
            //b1.id ; baseClass'da id otomatik değer tanınıyor dışarıdan erişilemiyor
            b1.marka = "lenova";
            b1.model = "z350";
            b1.alisFiyat = 20000;
            b1.satisFiyat = 25000;
            b1.indirimli = 3000;
            b1.barkod = "123";
            sanalDatebase.yeniUrun(b1);

            bilgisayar b2 = new bilgisayar();
            //b1.id ; baseClass'da id otomatik değer tanınıyor dışarıdan erişilemiyor
            b2.marka = "lenova";
            b2.model = "z350";
            b2.alisFiyat = 20000;
            b2.satisFiyat = 25000;
            b2.indirimli = 3000;
            b2.barkod = "123";

            sanalDatebase.yeniUrun(b2);
        }
    }
}
