using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 request                                  <object> IL2CPP_TYPE_OBJECT
    // 018 Certificate                              ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 020 Chain                                    ModelClassType X509Chain X509Chain X509Chain Pointer
    // 028 SslPolicyErrors                          ModelEnumType SslPolicyErrors SslPolicyErrors SslPolicyErrors Int32
    // 02C Result                                   ModelPrimitiveType bool bool bool Bool
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

            value.Certificate                               = GetObject<X509Certificate>(new IntPtr(p + 0x018), ReversePrism.DataModels.X509Certificate.FromPointer); // 0x18 Certificate                 ( ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.Chain                                     = GetObject<X509Chain>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509Chain.FromPointer); // 0x20 Chain                       ( ModelClassType X509Chain X509Chain X509Chain Pointer )
            value.SslPolicyErrors                           = (SslPolicyErrors)GetInt32(new IntPtr(p + 0x028)); // 0x28 SslPolicyErrors             ( ModelEnumType SslPolicyErrors SslPolicyErrors SslPolicyErrors Int32 )
            value.Result                                    = GetBool(new IntPtr(p + 0x02C)); // 0x2C Result                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
