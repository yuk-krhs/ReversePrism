using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      0001866722E0 ModelPrimitiveType string string string String
    // 018 AuthenticationFile                       0001866722E0 ModelPrimitiveType string string string String
    // 020 EnableAtomDecryption                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 021 EnableManaDecryption                     000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CriWareDecrypterConfig
    {
        public string                                   Key                                     { get; set; }
        public string                                   AuthenticationFile                      { get; set; }
        public bool                                     EnableAtomDecryption                    { get; set; }
        public bool                                     EnableManaDecryption                    { get; set; }

        public static CriWareDecrypterConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriWareDecrypterConfig();

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 0270D11727A0 0x10 Key                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AuthenticationFile                        = GetString(new IntPtr(p + 0x018)); // 0270D11727C0 0x18 AuthenticationFile          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.EnableAtomDecryption                      = GetBool(new IntPtr(p + 0x020)); // 0270D11727E0 0x20 EnableAtomDecryption        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EnableManaDecryption                      = GetBool(new IntPtr(p + 0x021)); // 0270D1172800 0x21 EnableManaDecryption        ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
