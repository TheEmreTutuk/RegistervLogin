using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriKatmani
{
    public class Oturum
    {
        public static int ID { get; set; }

        public static string Nick { get; set; }

        public static string Mail { get; set; }

        public static void CikisYap()
        {
            ID = 0;
            Nick = null;
            Mail = null;
        }
    }
}
