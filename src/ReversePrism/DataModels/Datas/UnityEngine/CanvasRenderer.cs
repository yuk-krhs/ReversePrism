using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 IsMask                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CanvasRenderer
    {
        public bool                                     IsMask                                  { get; set; }

        public static CanvasRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CanvasRenderer();

            value.IsMask                                    = GetBool(new IntPtr(p + 0x018)); // 027003A05A00 0x18 IsMask                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
