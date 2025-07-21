using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 028 MustFlush                                ModelPrimitiveType bool bool bool Bool
    // 029 ThrowOnOverflow                          ModelPrimitiveType bool bool bool Bool
    // 02C BytesUsed                                ModelPrimitiveType int int int Int32
    public partial class DecoderNLS : DataModel
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
            var value   = new DecoderNLS() { Pointer= p0 };

            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0x20 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.MustFlush                                 = GetBool(new IntPtr(p + 0x028)); // 0x28 MustFlush                   ( ModelPrimitiveType bool bool bool Bool )
            value.ThrowOnOverflow                           = GetBool(new IntPtr(p + 0x029)); // 0x29 ThrowOnOverflow             ( ModelPrimitiveType bool bool bool Bool )
            value.BytesUsed                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C BytesUsed                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
