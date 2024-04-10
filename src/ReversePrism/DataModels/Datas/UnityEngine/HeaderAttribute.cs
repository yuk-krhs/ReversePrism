using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Header                                   0001866736C0 ModelPrimitiveType string string string String
    public partial class HeaderAttribute : DataModel
    {
        public string                                   Header                                  { get; set; }

        public static HeaderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HeaderAttribute() { Pointer= p0 };

            value.Header                                    = GetString(new IntPtr(p + 0x010)); // 0245A687AAC8 0x10 Header                      ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
