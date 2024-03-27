using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 028 MustFlush                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 ThrowOnOverflow                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 02C BytesUsed                                0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class DecoderNLS
    {
        public Encoding?                                Encoding                                { get; set; }
        public bool                                     MustFlush                               { get; set; }
        public bool                                     ThrowOnOverflow                         { get; set; }
        public int                                      BytesUsed                               { get; set; }

        public static DecoderNLS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderNLS();

            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0270033E6BE0 0x20 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.MustFlush                                 = GetBool(new IntPtr(p + 0x028)); // 0270033E6C00 0x28 MustFlush                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ThrowOnOverflow                           = GetBool(new IntPtr(p + 0x029)); // 0270033E6C20 0x29 ThrowOnOverflow             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.BytesUsed                                 = GetInt32(new IntPtr(p + 0x02C)); // 0270033E6C40 0x2C BytesUsed                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
