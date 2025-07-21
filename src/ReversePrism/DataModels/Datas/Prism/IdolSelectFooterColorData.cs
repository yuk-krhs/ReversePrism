using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DataList                                 ModelClassListType List`1<ColorData> List`1<ColorData> List<ColorData> Pointer
    public partial class IdolSelectFooterColorData : DataModel
    {
        public List<ColorData>?                         DataList                                { get; set; }

        public static IdolSelectFooterColorData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSelectFooterColorData() { Pointer= p0 };

            value.DataList                                  = GetObjectList<ColorData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ColorData.FromPointer); // 0x18 DataList                    ( ModelClassListType List`1<ColorData> List`1<ColorData> List<ColorData> Pointer )

            return value;
        }
    }
}
