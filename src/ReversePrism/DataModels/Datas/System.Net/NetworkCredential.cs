using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_domain                                 000186671910 ModelPrimitiveType string string string String
    // 018 M_userName                               000186671910 ModelPrimitiveType string string string String
    // 020 M_password                               0001867100C0 ModelClassType SecureString SecureString SecureString Pointer
    public partial class NetworkCredential
    {
        public string                                   M_domain                                { get; set; }
        public string                                   M_userName                              { get; set; }
        public SecureString?                            M_password                              { get; set; }

        public static NetworkCredential? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NetworkCredential();

            value.M_domain                                  = GetString(new IntPtr(p + 0x010)); // 0270D7A10BA0 0x10 M_domain                    ( 000186671910 ModelPrimitiveType string string string String )
            value.M_userName                                = GetString(new IntPtr(p + 0x018)); // 0270D7A10BC0 0x18 M_userName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.M_password                                = GetObject<SecureString>(new IntPtr(p + 0x020), ReversePrism.DataModels.SecureString.FromPointer); // 0270D7A10BE0 0x20 M_password                  ( 0001867100C0 ModelClassType SecureString SecureString SecureString Pointer )

            return value;
        }
    }
}
