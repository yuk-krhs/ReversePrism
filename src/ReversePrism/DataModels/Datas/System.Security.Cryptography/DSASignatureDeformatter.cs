using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DsaKey                                   0001866736E0 ModelClassType DSA DSA DSA Pointer
    // 018 Oid                                      000186671910 ModelPrimitiveType string string string String
    public partial class DSASignatureDeformatter
    {
        public DSA?                                     DsaKey                                  { get; set; }
        public string                                   Oid                                     { get; set; }

        public static DSASignatureDeformatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DSASignatureDeformatter();

            value.DsaKey                                    = GetObject<DSA>(new IntPtr(p + 0x010), ReversePrism.DataModels.DSA.FromPointer); // 02700422EF70 0x10 DsaKey                      ( 0001866736E0 ModelClassType DSA DSA DSA Pointer )
            value.Oid                                       = GetString(new IntPtr(p + 0x018)); // 02700422EF90 0x18 Oid                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
