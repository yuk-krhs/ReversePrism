using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 EffectiveKeySizeValue                    0001865F3220 ModelPrimitiveType int int int Int32
    // 000 s_legalBlockSizes                        KeySizes[] IL2CPP_TYPE_SZARRAY
    // 008 s_legalKeySizes                          KeySizes[] IL2CPP_TYPE_SZARRAY
    public partial class RC2
    {
        public int                                      EffectiveKeySizeValue                   { get; set; }

        public static RC2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RC2();

            value.EffectiveKeySizeValue                     = GetInt32(new IntPtr(p + 0x048)); // 027004230188 0x48 EffectiveKeySizeValue       ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
