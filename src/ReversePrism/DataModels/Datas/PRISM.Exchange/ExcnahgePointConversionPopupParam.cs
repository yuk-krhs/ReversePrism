using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CurConversionItemCount                   ModelPrimitiveType int int int Int32
    // 098 PointAndConversionItemCountPairs         ICollection`1<KeyValuePair`2<int, int>> IL2CPP_TYPE_GENERICINST
    public partial class ExcnahgePointConversionPopupParam : DataModel
    {
        public int                                      CurConversionItemCount                  { get; set; }

        public static ExcnahgePointConversionPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExcnahgePointConversionPopupParam() { Pointer= p0 };

            value.CurConversionItemCount                    = GetInt32(new IntPtr(p + 0x090)); // 0x90 CurConversionItemCount      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
