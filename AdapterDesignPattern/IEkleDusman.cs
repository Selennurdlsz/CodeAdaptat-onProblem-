using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public interface IEkleDusman
    {
        void YumrukAt(string dusmanTuru, bool yumruk);
        void Yuru(string dusmanTuru, bool yuru);
        void RobotIsim(string dusmanTuru, string isim);
    }
}
