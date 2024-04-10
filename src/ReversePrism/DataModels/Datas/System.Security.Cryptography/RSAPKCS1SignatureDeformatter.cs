using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rsa                                      000186603C00 ModelClassType RSA RSA RSA Pointer
    // 018 HashName                                 000186671910 ModelPrimitiveType string string string String
    public partial class RSAPKCS1SignatureDeformatter : DataModel
    {
        public RSA?                                     Rsa                                     { get; set; }
        public string                                   HashName                                { get; set; }

        public static RSAPKCS1SignatureDeformatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RSAPKCS1SignatureDeformatter() { Pointer= p0 };

            value.Rsa                                       = GetObject<RSA>(new IntPtr(p + 0x010), ReversePrism.DataModels.RSA.FromPointer); // 024661937AB8 0x10 Rsa                         ( 000186603C00 ModelClassType RSA RSA RSA Pointer )
            value.HashName                                  = GetString(new IntPtr(p + 0x018)); // 024661937AD8 0x18 HashName                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
