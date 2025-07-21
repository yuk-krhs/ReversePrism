using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      ModelPrimitiveType string string string String
    // 018 AuthenticationFile                       ModelPrimitiveType string string string String
    // 020 EnableAtomDecryption                     ModelPrimitiveType bool bool bool Bool
    // 021 EnableManaDecryption                     ModelPrimitiveType bool bool bool Bool
    public partial class CriWareDecrypterConfig : DataModel
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
            var value   = new CriWareDecrypterConfig() { Pointer= p0 };

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Key                         ( ModelPrimitiveType string string string String )
            value.AuthenticationFile                        = GetString(new IntPtr(p + 0x018)); // 0x18 AuthenticationFile          ( ModelPrimitiveType string string string String )
            value.EnableAtomDecryption                      = GetBool(new IntPtr(p + 0x020)); // 0x20 EnableAtomDecryption        ( ModelPrimitiveType bool bool bool Bool )
            value.EnableManaDecryption                      = GetBool(new IntPtr(p + 0x021)); // 0x21 EnableManaDecryption        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
