using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StrKey                                   ModelPrimitiveType string string string String
    // 018 StrDigest                                ModelPrimitiveType string string string String
    // 020 StrFormatter                             ModelPrimitiveType string string string String
    // 028 StrDeformatter                           ModelPrimitiveType string string string String
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

            value.StrKey                                    = GetString(new IntPtr(p + 0x010)); // 0x10 StrKey                      ( ModelPrimitiveType string string string String )
            value.StrDigest                                 = GetString(new IntPtr(p + 0x018)); // 0x18 StrDigest                   ( ModelPrimitiveType string string string String )
            value.StrFormatter                              = GetString(new IntPtr(p + 0x020)); // 0x20 StrFormatter                ( ModelPrimitiveType string string string String )
            value.StrDeformatter                            = GetString(new IntPtr(p + 0x028)); // 0x28 StrDeformatter              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
