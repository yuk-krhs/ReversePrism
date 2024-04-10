using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proxied                                  000186670BE0 ModelClassType Stream Stream Stream Pointer
    // 030 BytesLeft                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LimitedInputStream : DataModel
    {
        public Stream?                                  Proxied                                 { get; set; }
        public int                                      BytesLeft                               { get; set; }

        public static LimitedInputStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitedInputStream() { Pointer= p0 };

            value.Proxied                                   = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 02466A47FC38 0x28 Proxied                     ( 000186670BE0 ModelClassType Stream Stream Stream Pointer )
            value.BytesLeft                                 = GetInt32(new IntPtr(p + 0x030)); // 02466A47FC58 0x30 BytesLeft                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
