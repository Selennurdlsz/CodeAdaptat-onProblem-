using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public interface IDusman
    {
        void SilahKullan(string dusmanTuru, bool silah);
        void Hizlan(string dusmanTuru, bool hizli);
        void DusmanAdi(string dusmanTuru, string dusmanAdi);
    }
}
