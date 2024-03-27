using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Layout                                   000186672F10 ModelPrimitiveType string string string String
    public partial class LayoutNotFoundException
    {
        public string                                   Layout                                  { get; set; }

        public static LayoutNotFoundException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutNotFoundException();

            value.Layout                                    = GetString(new IntPtr(p + 0x090)); // 0270D7866BB0 0x90 Layout                      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
