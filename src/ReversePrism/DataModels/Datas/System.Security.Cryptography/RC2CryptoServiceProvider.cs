using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 M_use40bitSalt                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 s_legalKeySizes                          KeySizes[] IL2CPP_TYPE_SZARRAY
    public partial class RC2CryptoServiceProvider
    {
        public bool                                     M_use40bitSalt                          { get; set; }

        public static RC2CryptoServiceProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RC2CryptoServiceProvider();

            value.M_use40bitSalt                            = GetBool(new IntPtr(p + 0x050)); // 027004230528 0x50 M_use40bitSalt              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
