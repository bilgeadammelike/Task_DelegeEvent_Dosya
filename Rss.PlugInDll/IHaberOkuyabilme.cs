using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rss.PlugInDll
{
    public interface IHaberOkuyabilme
    {
        string DefaultURL { get; }
        string SourceURL { get; set; }
        List<Haber> HaberListesi(string URL);
    }
}
