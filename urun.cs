using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimOdev
{
    public class urun:baseClass
    {

        public string marka { get; set; }
        public string model { get; set; }

        private decimal _alisFiyat;
        public decimal alisFiyat { 
            get 
            {
                return  _alisFiyat;
            }

            set
            {
                if (value <= 0) 
                {
                    Console.WriteLine("Alış fiyati 0'dan küçük olamaz");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        }
        private decimal _satisFiyat;
        public decimal satisFiyat {
            get
            {
                return _satisFiyat;
            }
            set
            {
                if (_alisFiyat <= _satisFiyat )
                {
                    Console.WriteLine("Alış fiyatı satış fiyatında küçük olamaz");
                }
                else 
                { 
                    _satisFiyat = value;
                }
            }
        }
        private decimal _indirimli;
        public decimal indirimli {
            get
            {
                return  _indirimli;
            }
            set
            {
                if (value < _alisFiyat)
                {
                    Console.WriteLine("Zararına satılamaz");
                }
                else
                {
                    _indirimli = value;
                }
            }
        }

    }
}
