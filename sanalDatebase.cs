using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimOdev
{
    public static class sanalDatebase
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrun(baseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod)) 
            {
                 db.Add(data);
            }

            
        }

        public static bool dbbarkodkontrol(string barkod)
        {
            if (db != null && db.Count>0)
            {
                bool kontrolislemi = true;
                for (int i = 0; i <= db.Count; i++)
                {
                    baseClass bc = (baseClass)db[i];
                    if (bc.barkod == barkod)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
