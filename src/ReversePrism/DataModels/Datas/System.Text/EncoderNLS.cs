using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _charLeftOver                            char IL2CPP_TYPE_CHAR
    // 028 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 030 MustFlush                                ModelPrimitiveType bool bool bool Bool
    // 031 ThrowOnOverflow                          ModelPrimitiveType bool bool bool Bool
    // 034 CharsUsed                                ModelPrimitiveType int int int Int32
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

            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0x28 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.MustFlush                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 MustFlush                   ( ModelPrimitiveType bool bool bool Bool )
            value.ThrowOnOverflow                           = GetBool(new IntPtr(p + 0x031)); // 0x31 ThrowOnOverflow             ( ModelPrimitiveType bool bool bool Bool )
            value.CharsUsed                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 CharsUsed                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
