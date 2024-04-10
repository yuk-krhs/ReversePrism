using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 request                                  <object> IL2CPP_TYPE_OBJECT
    // 018 Certificate                              0001866B8010 ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 020 Chain                                    0001866B8780 ModelClassType X509Chain X509Chain X509Chain Pointer
    // 028 SslPolicyErrors                          00018666D3E0 ModelEnumType SslPolicyErrors SslPolicyErrors SslPolicyErrors Int32
    // 02C Result                                   000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class CallbackContext : DataModel
    {
        public X509Certificate?                         Certificate                             { get; set; }
        public X509Chain?                               Chain                                   { get; set; }
        public SslPolicyErrors                          SslPolicyErrors                         { get; set; }
        public bool                                     Result                                  { get; set; }

        public static CallbackContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallbackContext() { Pointer= p0 };

            value.Certificate                               = GetObject<X509Certificate>(new IntPtr(p + 0x018), ReversePrism.DataModels.X509Certificate.FromPointer); // 024667AB2FE0 0x18 Certificate                 ( 0001866B8010 ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.Chain                                     = GetObject<X509Chain>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509Chain.FromPointer); // 024667AB3000 0x20 Chain                       ( 0001866B8780 ModelClassType X509Chain X509Chain X509Chain Pointer )
            value.SslPolicyErrors                           = (SslPolicyErrors)GetInt32(new IntPtr(p + 0x028)); // 024667AB3020 0x28 SslPolicyErrors             ( 00018666D3E0 ModelEnumType SslPolicyErrors SslPolicyErrors SslPolicyErrors Int32 )
            value.Result                                    = GetBool(new IntPtr(p + 0x02C)); // 024667AB3040 0x2C Result                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
