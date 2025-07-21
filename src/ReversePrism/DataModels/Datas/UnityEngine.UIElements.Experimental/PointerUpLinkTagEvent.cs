using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 110 LinkID                                   ModelPrimitiveType string string string String
    // 118 LinkText                                 ModelPrimitiveType string string string String
    public partial class PointerUpLinkTagEvent : DataModel
    {
        public string                                   LinkID                                  { get; set; }
        public string                                   LinkText                                { get; set; }

        public static PointerUpLinkTagEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerUpLinkTagEvent() { Pointer= p0 };

            value.LinkID                                    = GetString(new IntPtr(p + 0x110)); // 0x110 LinkID                      ( ModelPrimitiveType string string string String )
            value.LinkText                                  = GetString(new IntPtr(p + 0x118)); // 0x118 LinkText                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
