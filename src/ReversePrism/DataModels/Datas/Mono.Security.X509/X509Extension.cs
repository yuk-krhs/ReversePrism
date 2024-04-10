using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExtnOid                                  000186671E00 ModelPrimitiveType string string string String
    // 018 ExtnCritical                             000186595480 ModelPrimitiveType bool bool bool Bool
    // 020 ExtnValue                                00018666D020 ModelClassType ASN1 ASN1 ASN1 Pointer
    public partial class X509Extension : DataModel
    {
        public string                                   ExtnOid                                 { get; set; }
        public bool                                     ExtnCritical                            { get; set; }
        public ASN1?                                    ExtnValue                               { get; set; }

        public static X509Extension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Extension() { Pointer= p0 };

            value.ExtnOid                                   = GetString(new IntPtr(p + 0x010)); // 024667A45228 0x10 ExtnOid                     ( 000186671E00 ModelPrimitiveType string string string String )
            value.ExtnCritical                              = GetBool(new IntPtr(p + 0x018)); // 024667A45248 0x18 ExtnCritical                ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.ExtnValue                                 = GetObject<ASN1>(new IntPtr(p + 0x020), ReversePrism.DataModels.ASN1.FromPointer); // 024667A45268 0x20 ExtnValue                   ( 00018666D020 ModelClassType ASN1 ASN1 ASN1 Pointer )

            return value;
        }
    }
}
