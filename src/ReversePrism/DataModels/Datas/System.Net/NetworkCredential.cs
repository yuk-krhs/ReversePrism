using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_domain                                 ModelPrimitiveType string string string String
    // 018 M_userName                               ModelPrimitiveType string string string String
    // 020 M_password                               ModelClassType SecureString SecureString SecureString Pointer
    public partial class NetworkCredential : DataModel
    {
        public string                                   M_domain                                { get; set; }
        public string                                   M_userName                              { get; set; }
        public SecureString?                            M_password                              { get; set; }

        public static NetworkCredential? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NetworkCredential() { Pointer= p0 };

            value.M_domain                                  = GetString(new IntPtr(p + 0x010)); // 0x10 M_domain                    ( ModelPrimitiveType string string string String )
            value.M_userName                                = GetString(new IntPtr(p + 0x018)); // 0x18 M_userName                  ( ModelPrimitiveType string string string String )
            value.M_password                                = GetObject<SecureString>(new IntPtr(p + 0x020), ReversePrism.DataModels.SecureString.FromPointer); // 0x20 M_password                  ( ModelClassType SecureString SecureString SecureString Pointer )

            return value;
        }
    }
}
