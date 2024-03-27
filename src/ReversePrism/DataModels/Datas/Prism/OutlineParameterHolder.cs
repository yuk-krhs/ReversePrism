using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OutlineAdjust                            000186666050 ModelPrimitiveType float float float Single
    // 024 OutlineInclusive                         000186666050 ModelPrimitiveType float float float Single
    // 028 OutlineResizeRate                        000186666050 ModelPrimitiveType float float float Single
    public partial class OutlineParameterHolder
    {
        public float                                    OutlineAdjust                           { get; set; }
        public float                                    OutlineInclusive                        { get; set; }
        public float                                    OutlineResizeRate                       { get; set; }

        public static OutlineParameterHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutlineParameterHolder();

            value.OutlineAdjust                             = GetSingle(new IntPtr(p + 0x020)); // 0270D3307F50 0x20 OutlineAdjust               ( 000186666050 ModelPrimitiveType float float float Single )
            value.OutlineInclusive                          = GetSingle(new IntPtr(p + 0x024)); // 0270D3307F70 0x24 OutlineInclusive            ( 000186666050 ModelPrimitiveType float float float Single )
            value.OutlineResizeRate                         = GetSingle(new IntPtr(p + 0x028)); // 0270D3307F90 0x28 OutlineResizeRate           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
