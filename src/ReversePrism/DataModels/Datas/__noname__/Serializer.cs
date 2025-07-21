using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Builder                                  ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    public partial class Serializer : DataModel
    {
        public StringBuilder?                           Builder                                 { get; set; }

        public static Serializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Serializer() { Pointer= p0 };

            value.Builder                                   = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x10 Builder                     ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )

            return value;
        }
    }
}
