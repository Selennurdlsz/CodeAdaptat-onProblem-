using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class DusmanTank: IDusman
    {
        DusmanAdapter dusmanAdapter;
      
        public void SilahKullan(string dusmanTuru, bool silah)
        {
            if (silah == true)
            {
                dusmanAdapter = new DusmanAdapter(dusmanTuru);
                Console.WriteLine("Dusman " + dusmanTuru + " ates etti.");
                dusmanAdapter.SilahKullan(dusmanTuru, silah);
            }
            else
            {
                dusmanAdapter = new DusmanAdapter(dusmanTuru);
                Console.WriteLine("Dusman" + dusmanTuru 
                    + " tarafindan saldiri yok.");
                dusmanAdapter.SilahKullan(dusmanTuru, silah);

            }
            
        }
        public void DusmanAdi(string dusmanTuru, string dusmanAdi)
        {

            dusmanAdapter = new DusmanAdapter(dusmanTuru);
            Console.WriteLine("Dusman " + dusmanTuru + "'a " + dusmanAdi + " ismi verildi.");
            dusmanAdapter.DusmanAdi(dusmanTuru, dusmanAdi);
        }

        public void Hizlan(string dusmanTuru, bool hizli)
        {
            if (hizli == true)
            {
                dusmanAdapter = new DusmanAdapter(dusmanTuru);
                Console.WriteLine("Dusman " + dusmanTuru + " hizli.");
                dusmanAdapter.Hizlan(dusmanTuru, hizli);
            }
            else
            {
                dusmanAdapter = new DusmanAdapter(dusmanTuru);
                Console.WriteLine("Dusman " + dusmanTuru + " yavas.");
                dusmanAdapter.Hizlan(dusmanTuru, hizli);


            }

        }
    }
    
}
