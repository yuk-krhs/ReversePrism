using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BagOID                                   000186671910 ModelPrimitiveType string string string String
    // 018 Asn1                                     00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer
    public partial class SafeBag
    {
        public string                                   BagOID                                  { get; set; }
        public ASN1?                                    Asn1                                    { get; set; }

        public static SafeBag? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeBag();

            value.BagOID                                    = GetString(new IntPtr(p + 0x010)); // 0270DB379D18 0x10 BagOID                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Asn1                                      = GetObject<ASN1>(new IntPtr(p + 0x018), ReversePrism.DataModels.ASN1.FromPointer); // 0270DB379D38 0x18 Asn1                        ( 00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer )

            return value;
        }
    }
}
