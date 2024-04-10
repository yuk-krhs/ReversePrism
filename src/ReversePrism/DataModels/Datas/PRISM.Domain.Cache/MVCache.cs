using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 mvUnits                                  Dictionary`2<int, IMvUnitStatus> IL2CPP_TYPE_GENERICINST
    // 018 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MVCache : DataModel
    {
        public bool                                     IsReady                                 { get; set; }

        public static MVCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MVCache() { Pointer= p0 };

            value.IsReady                                   = GetBool(new IntPtr(p + 0x018)); // 0245A4ADFBA8 0x18 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
