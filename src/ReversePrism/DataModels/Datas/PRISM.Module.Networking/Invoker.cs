using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Header                                   00018660C830 ModelClassType Metadata Metadata Metadata Pointer
    public partial class Invoker
    {
        public Metadata?                                Header                                  { get; set; }

        public static Invoker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Invoker();

            value.Header                                    = GetObject<Metadata>(new IntPtr(p + 0x010), ReversePrism.DataModels.Metadata.FromPointer); // 027004B2DE18 0x10 Header                      ( 00018660C830 ModelClassType Metadata Metadata Metadata Pointer )

            return value;
        }
    }
}
