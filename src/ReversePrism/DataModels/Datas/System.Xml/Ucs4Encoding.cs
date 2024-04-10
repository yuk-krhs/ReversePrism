using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Ucs4Decoder                              0001866FE410 ModelClassType Ucs4Decoder Ucs4Decoder Ucs4Decoder Pointer
    public partial class Ucs4Encoding : DataModel
    {
        public Ucs4Decoder?                             Ucs4Decoder                             { get; set; }

        public static Ucs4Encoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ucs4Encoding() { Pointer= p0 };

            value.Ucs4Decoder                               = GetObject<Ucs4Decoder>(new IntPtr(p + 0x038), ReversePrism.DataModels.Ucs4Decoder.FromPointer); // 0246674FD220 0x38 Ucs4Decoder                 ( 0001866FE410 ModelClassType Ucs4Decoder Ucs4Decoder Ucs4Decoder Pointer )

            return value;
        }
    }
}
