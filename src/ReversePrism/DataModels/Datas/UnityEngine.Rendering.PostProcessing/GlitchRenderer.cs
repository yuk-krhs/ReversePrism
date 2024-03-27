using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VerticalJumpTime                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class GlitchRenderer
    {
        public float                                    VerticalJumpTime                        { get; set; }

        public static GlitchRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlitchRenderer();

            value.VerticalJumpTime                          = GetSingle(new IntPtr(p + 0x020)); // 02700657AE38 0x20 VerticalJumpTime            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
