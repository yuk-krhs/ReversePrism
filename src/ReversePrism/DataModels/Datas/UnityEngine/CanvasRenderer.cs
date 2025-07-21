using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 IsMask                                   ModelPrimitiveType bool bool bool Bool
    public partial class CanvasRenderer : DataModel
    {
        public bool                                     IsMask                                  { get; set; }

        public static CanvasRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CanvasRenderer() { Pointer= p0 };

            value.IsMask                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 IsMask                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
