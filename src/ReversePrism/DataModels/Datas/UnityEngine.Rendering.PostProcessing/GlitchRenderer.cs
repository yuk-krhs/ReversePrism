using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VerticalJumpTime                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class GlitchRenderer : DataModel
    {
        public float                                    VerticalJumpTime                        { get; set; }

        public static GlitchRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlitchRenderer() { Pointer= p0 };

            value.VerticalJumpTime                          = GetSingle(new IntPtr(p + 0x020)); // 0245A6550F98 0x20 VerticalJumpTime            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
