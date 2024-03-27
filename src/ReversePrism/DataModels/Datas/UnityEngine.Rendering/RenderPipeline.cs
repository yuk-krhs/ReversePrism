using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RenderPipeline
    {
        public bool                                     Disposed                                { get; set; }

        public static RenderPipeline? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderPipeline();

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0270D0ABDB88 0x10 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
