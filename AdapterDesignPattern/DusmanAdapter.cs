using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class DusmanAdapter:IDusman//Adapter
    {
        IEkleDusman ekleDusman;
        IDusman dusman;
        public DusmanAdapter(string dusmanTuru)
        {
            if (dusmanTuru == "robot")
                ekleDusman = new DusmanRobotu();
            else if (dusmanTuru == "tank")
                dusman = new DusmanTank();
        }

        public void DusmanAdi(string dusmanTuru, string dusmanAdi)
        {
            if (dusmanTuru == "robot")
                ekleDusman.RobotIsim(dusmanTuru, dusmanAdi);
            if (dusmanTuru == "tank")
                dusman.DusmanAdi(dusmanTuru, dusmanAdi);
        }

        public void Hizlan(string dusmanTuru, bool hizli)
        {
            if (dusmanTuru == "robot")
                ekleDusman.Yuru(dusmanTuru, hizli);
            if (dusmanTuru == "tank")
                dusman.Hizlan(dusmanTuru, hizli);
        }

        public void SilahKullan(string dusmanTuru, bool silah)
        {
            if (dusmanTuru == "robot")
                ekleDusman.YumrukAt(dusmanTuru, silah);
            if (dusmanTuru == "tank")
                dusman.SilahKullan(dusmanTuru, silah);
        }
    }
}
