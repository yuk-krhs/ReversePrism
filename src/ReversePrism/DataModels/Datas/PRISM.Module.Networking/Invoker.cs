using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Header                                   ModelClassType Metadata Metadata Metadata Pointer
    public partial class Invoker : DataModel
    {
        public Metadata?                                Header                                  { get; set; }

        public static Invoker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Invoker() { Pointer= p0 };

            value.Header                                    = GetObject<Metadata>(new IntPtr(p + 0x010), ReversePrism.DataModels.Metadata.FromPointer); // 0x10 Header                      ( ModelClassType Metadata Metadata Metadata Pointer )

            return value;
        }
    }
}
