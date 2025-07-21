using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     ModelPrimitiveType string string string String
    // 018 SE                                       ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class CommonPopupTextInfo : DataModel
    {
        public string                                   Text                                    { get; set; }
        public SoundKey                                 SE                                      { get; set; }

        public static CommonPopupTextInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupTextInfo() { Pointer= p0 };

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Text                        ( ModelPrimitiveType string string string String )
            value.SE                                        = (SoundKey)GetInt32(new IntPtr(p + 0x018)); // 0x18 SE                          ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
