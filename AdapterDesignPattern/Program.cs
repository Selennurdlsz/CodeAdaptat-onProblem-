using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDesignPattern
{
   class Program
    {
        static void Main(string[] args)
        {
            //Client 
            DusmanTank t1 = new DusmanTank();
            t1.SilahKullan("tank", true);
            t1.Hizlan("tank", false);
            t1.DusmanAdi("tank","Düşman1");
         
            DusmanRobotu robot1 = new DusmanRobotu();
            robot1.YumrukAt("robot",true);
            robot1.Yuru("robot",true);
            robot1.RobotIsim("robot","Düşman2");

            /* Adaptasyonu burada kullanıyoruz. */
            IDusman dusman = new DusmanAdapter("robot");
            dusman.SilahKullan("robot",false);
            dusman.Hizlan("robot",true);
            dusman.DusmanAdi("robot","Düşman3");

            Console.ReadLine();
        }
    }
}
