using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimOdev
{
    public class baseClass
    {
        public static int sayac = 1;
        private int _id;

        public baseClass() 
        {
            _id = sayac; // burada belirtince id değer kazanıp sayaç çalışıyor
            sayac = sayac + 1; 
            
        }
        public int id 
        { 
            get 
            {
                return _id;
            } 
            
           private set 
            {
                //_id = sayac; burada belirtirsen private olduğu için dışarıya değer göndermiyor
                //sayac = sayac + 1; dışarıdan değer girilmemesi içinse private olarak belirtmek zorundasın

            }
        }
        private string _barkod;
        public string barkod { 
            get 
            {
                return _barkod;
            }
            set 
            {
                bool barkodkontrol = sanalDatebase.dbbarkodkontrol(value);
                if (barkodkontrol) // deger bulunamadı
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("İçeride aynı barkod var ");
                }
                
            } 
        }
        public string kullaniciIsmi { get; set; }
        public string guncelleyenKullaici { get; set; }
        public DateTime OlusturulanTarih { get; set; }
        public DateTime GuncellenenTarih { get; set; }
        public bool Silindi {get; set; }
    }
}
