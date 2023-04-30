using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class temelTip
    {
        public int id { get; set; }
        public int KullaniciKayit { get; set; }
        public int cinsiyet { get; set; }
        public int KullanıcıGuncelleme { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string referans { get; set; }
        public string tc { get; set;}
        public DateTime kayitTarih { get; set;}
        public DateTime guncellemeTarih { get; set;}
        public bool silindi { get; set; }

        public  temelTip()
        {
            Console.WriteLine("Temel Tip Metotu Çalıştı");
            deneme();
        }
        private void deneme()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 2000);
            
        }
        public void TemeltipMetot1()
        {
            Console.WriteLine("Metot1 çalıştı");
        }
    }
}
