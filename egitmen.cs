using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class egitmen:temelTip
    {
        public string bras { get; set; }
        public int braseviye { get; set; }
        public DateTime Isbaslangıc { get; set; }
        public DateTime IsBitis { get; set; }
        public int izin { get; set; }
        public egitmen()
        {
            Console.WriteLine("EğitmenMetotuÇalıştı");
            
        }

    }
}
