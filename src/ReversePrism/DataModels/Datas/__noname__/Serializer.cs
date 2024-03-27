using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Builder                                  0001866774E0 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    public partial class Serializer
    {
        public StringBuilder?                           Builder                                 { get; set; }

        public static Serializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Serializer();

            value.Builder                                   = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270DBF14BC0 0x10 Builder                     ( 0001866774E0 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )

            return value;
        }
    }
}
