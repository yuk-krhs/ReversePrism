using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaTabDatas                            000185D24368 ModelClassListType List`1<GashaTabData> List`1<GashaTabData> List<GashaTabData> Pointer
    public partial class GashaDetailsTabSave : DataModel
    {
        public List<GashaTabData>?                      GashaTabDatas                           { get; set; }

        public static GashaDetailsTabSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailsTabSave() { Pointer= p0 };

            value.GashaTabDatas                             = GetObjectList<GashaTabData>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaTabData.FromPointer); // 0245A3A7BE78 0x20 GashaTabDatas               ( 000185D24368 ModelClassListType List`1<GashaTabData> List`1<GashaTabData> List<GashaTabData> Pointer )

            return value;
        }
    }
}
