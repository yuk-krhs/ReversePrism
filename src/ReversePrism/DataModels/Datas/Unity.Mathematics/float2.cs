using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        000186666050 ModelPrimitiveType float float float Single
    // 014 Y                                        000186666050 ModelPrimitiveType float float float Single
    // 000 zero                                     float2 IL2CPP_TYPE_VALUETYPE
    public partial class float2 : DataModel
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }

        public static float2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float2() { Pointer= p0 };

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0245A15875F8 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0245A1587618 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
