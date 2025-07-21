using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OutlineAdjust                            ModelPrimitiveType float float float Single
    // 024 OutlineInclusive                         ModelPrimitiveType float float float Single
    // 028 OutlineResizeRate                        ModelPrimitiveType float float float Single
    public partial class OutlineParameterHolder : DataModel
    {
        public float                                    OutlineAdjust                           { get; set; }
        public float                                    OutlineInclusive                        { get; set; }
        public float                                    OutlineResizeRate                       { get; set; }

        public static OutlineParameterHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutlineParameterHolder() { Pointer= p0 };

            value.OutlineAdjust                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 OutlineAdjust               ( ModelPrimitiveType float float float Single )
            value.OutlineInclusive                          = GetSingle(new IntPtr(p + 0x024)); // 0x24 OutlineInclusive            ( ModelPrimitiveType float float float Single )
            value.OutlineResizeRate                         = GetSingle(new IntPtr(p + 0x028)); // 0x28 OutlineResizeRate           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
