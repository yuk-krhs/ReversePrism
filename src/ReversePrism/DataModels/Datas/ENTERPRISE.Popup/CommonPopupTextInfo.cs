using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 SE                                       000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class CommonPopupTextInfo
    {
        public string                                   Text                                    { get; set; }
        public SoundKey                                 SE                                      { get; set; }

        public static CommonPopupTextInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupTextInfo();

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0270DB01F090 0x10 Text                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SE                                        = (SoundKey)GetInt32(new IntPtr(p + 0x018)); // 0270DB01F0B0 0x18 SE                          ( 000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
