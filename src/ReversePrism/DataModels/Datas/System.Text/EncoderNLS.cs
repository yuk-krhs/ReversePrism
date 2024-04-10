using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _charLeftOver                            char IL2CPP_TYPE_CHAR
    // 028 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 030 MustFlush                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 ThrowOnOverflow                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 034 CharsUsed                                0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class EncoderNLS : DataModel
    {
        public Encoding?                                Encoding                                { get; set; }
        public bool                                     MustFlush                               { get; set; }
        public bool                                     ThrowOnOverflow                         { get; set; }
        public int                                      CharsUsed                               { get; set; }

        public static EncoderNLS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncoderNLS() { Pointer= p0 };

            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0245A3CA5B08 0x28 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.MustFlush                                 = GetBool(new IntPtr(p + 0x030)); // 0245A3CA5B28 0x30 MustFlush                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ThrowOnOverflow                           = GetBool(new IntPtr(p + 0x031)); // 0245A3CA5B48 0x31 ThrowOnOverflow             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.CharsUsed                                 = GetInt32(new IntPtr(p + 0x034)); // 0245A3CA5B68 0x34 CharsUsed                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
