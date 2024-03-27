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
    public partial class PointerMoveLinkTagEvent
    {
        public string                                   LinkID                                  { get; set; }
        public string                                   LinkText                                { get; set; }

        public static PointerMoveLinkTagEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerMoveLinkTagEvent();

            value.LinkID                                    = GetString(new IntPtr(p + 0x110)); // 02700688F830 0x110 LinkID                      ( 000186671910 ModelPrimitiveType string string string String )
            value.LinkText                                  = GetString(new IntPtr(p + 0x118)); // 02700688F850 0x118 LinkText                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
