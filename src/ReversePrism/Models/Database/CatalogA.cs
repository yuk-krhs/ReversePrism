using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class CatalogA
    {
        public long     L { get; set; }
        public byte[]?  D { get; set; }
        public int      K { get; set; }
        public int      F { get; set; }
        public int      R { get; set; }
        public long     C { get; set; }
        public long     E { get; set; }
        public int      S { get; set; }
        public int      P { get; set; }
    }

    public class CatalogASet : Dictionary<long, CatalogA>
    {
        public Dictionary<string, CatalogA> ByRealName { get; private set; }

        public CatalogASet(IEnumerable<CatalogA> items)
        {
            ByRealName  = new Dictionary<string, CatalogA>();

            foreach(var i in items)
            {
                Add(i.L, i);
                ByRealName.Add(CatalogDB.GetRealName(i), i);
            }
        }
    }
}
