using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 fesUnit                                  Dictionary`2<string, IFesUnitStatus> IL2CPP_TYPE_GENERICINST
    // 018 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FesUnitCache : DataModel
    {
        public bool                                     IsReady                                 { get; set; }

        public static FesUnitCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitCache() { Pointer= p0 };

            value.IsReady                                   = GetBool(new IntPtr(p + 0x018)); // 0245A4ADDBF0 0x18 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
