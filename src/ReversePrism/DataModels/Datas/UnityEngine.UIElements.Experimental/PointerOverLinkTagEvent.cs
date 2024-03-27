using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 110 LinkID                                   000186671910 ModelPrimitiveType string string string String
    // 118 LinkText                                 000186671910 ModelPrimitiveType string string string String
    public partial class PointerOverLinkTagEvent
    {
        public string                                   LinkID                                  { get; set; }
        public string                                   LinkText                                { get; set; }

        public static PointerOverLinkTagEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerOverLinkTagEvent();

            value.LinkID                                    = GetString(new IntPtr(p + 0x110)); // 02700688B9B0 0x110 LinkID                      ( 000186671910 ModelPrimitiveType string string string String )
            value.LinkText                                  = GetString(new IntPtr(p + 0x118)); // 02700688B9D0 0x118 LinkText                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
