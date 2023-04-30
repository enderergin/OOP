using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /* temelTip t1 = new temelTip();
             t1.TemeltipMetot1(); //temelTipteki metot eğitmen kalıtımındanda çağırılabiliyor

             egitmen e1 = new egitmen();
             e1.TemeltipMetot1(); //temelTipteki metot eğitmen kalıtımındanda çağırılabiliyor

             personel p1 = new personel();
             ogrenci o1 = new ogrenci();

             temelTip t2;
             t2 = e1;
             e1 = (egitmen)t2;
             t2 = p1;
             p1 = (personel)t2;
             t2 = o1;
             o1 = (ogrenci)t2;

             /* object q1 = t2; boxing
              * t2 = (temelTip)q1; // unboxing ile tam tersine dönüştürebiliyorsun--
              */ // class object ile tek bir değere tanımlıyabiliyoruz
            #endregion
            #region
            ogrenci o1 = new ogrenci();
            o1.TemeltipMetot1();
            egitmen e1 = new egitmen();
            e1.TemeltipMetot1();
            personel p1 = new personel();
            p1.TemeltipMetot1();

            object ob = o1;
            o1 = (ogrenci)ob;
            ob = p1;
            p1 = (personel)ob;
            #endregion





        }
    }
}
