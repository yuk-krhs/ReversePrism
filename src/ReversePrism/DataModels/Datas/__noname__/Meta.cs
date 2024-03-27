using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 App                                      0001866722E0 ModelPrimitiveType string string string String
    // 018 Version                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 Image                                    0001866722E0 ModelPrimitiveType string string string String
    // 028 Format                                   0001866722E0 ModelPrimitiveType string string string String
    // 030 Size                                     0001865FE1B0 ModelEnumType SpriteSize SpriteSize SpriteSize Int32
    // 038 Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 040 Smartupdate                              0001866722E0 ModelPrimitiveType string string string String
    public partial class Meta
    {
        public string                                   App                                     { get; set; }
        public string                                   Version                                 { get; set; }
        public string                                   Image                                   { get; set; }
        public string                                   Format                                  { get; set; }
        public SpriteSize                               Size                                    { get; set; }
        public float                                    Scale                                   { get; set; }
        public string                                   Smartupdate                             { get; set; }

        public static Meta? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Meta();

            value.App                                       = GetString(new IntPtr(p + 0x010)); // 0270DA657CA0 0x10 App                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x018)); // 0270DA657CC0 0x18 Version                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Image                                     = GetString(new IntPtr(p + 0x020)); // 0270DA657CE0 0x20 Image                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Format                                    = GetString(new IntPtr(p + 0x028)); // 0270DA657D00 0x28 Format                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Size                                      = (SpriteSize)GetInt32(new IntPtr(p + 0x030)); // 0270DA657D20 0x30 Size                        ( 0001865FE1B0 ModelEnumType SpriteSize SpriteSize SpriteSize Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x038)); // 0270DA657D40 0x38 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Smartupdate                               = GetString(new IntPtr(p + 0x040)); // 0270DA657D60 0x40 Smartupdate                 ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
