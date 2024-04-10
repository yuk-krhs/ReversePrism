using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StrKey                                   000186671910 ModelPrimitiveType string string string String
    // 018 StrDigest                                000186671910 ModelPrimitiveType string string string String
    // 020 StrFormatter                             000186671910 ModelPrimitiveType string string string String
    // 028 StrDeformatter                           000186671910 ModelPrimitiveType string string string String
    public partial class SignatureDescription : DataModel
    {
        public string                                   StrKey                                  { get; set; }
        public string                                   StrDigest                               { get; set; }
        public string                                   StrFormatter                            { get; set; }
        public string                                   StrDeformatter                          { get; set; }

        public static SignatureDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignatureDescription() { Pointer= p0 };

            value.StrKey                                    = GetString(new IntPtr(p + 0x010)); // 02466192C198 0x10 StrKey                      ( 000186671910 ModelPrimitiveType string string string String )
            value.StrDigest                                 = GetString(new IntPtr(p + 0x018)); // 02466192C1B8 0x18 StrDigest                   ( 000186671910 ModelPrimitiveType string string string String )
            value.StrFormatter                              = GetString(new IntPtr(p + 0x020)); // 02466192C1D8 0x20 StrFormatter                ( 000186671910 ModelPrimitiveType string string string String )
            value.StrDeformatter                            = GetString(new IntPtr(p + 0x028)); // 02466192C1F8 0x28 StrDeformatter              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
