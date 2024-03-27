using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Filename                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 _Frame                                   0001865FDD50 ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32
    // 028 Rotated                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 029 Trimmed                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 02C SpriteSourceSize                         0001865FDD50 ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32
    // 03C SourceSize                               0001865FE1B0 ModelEnumType SpriteSize SpriteSize SpriteSize Int32
    // 044 Pivot                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class Frame
    {
        public string                                   Filename                                { get; set; }
        public SpriteFrame                              _Frame                                  { get; set; }
        public bool                                     Rotated                                 { get; set; }
        public bool                                     Trimmed                                 { get; set; }
        public SpriteFrame                              SpriteSourceSize                        { get; set; }
        public SpriteSize                               SourceSize                              { get; set; }
        public Vector2                                  Pivot                                   { get; set; }

        public static Frame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Frame();

            value.Filename                                  = GetString(new IntPtr(p + 0x010)); // 0270DA657B38 0x10 Filename                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value._Frame                                    = (SpriteFrame)GetInt32(new IntPtr(p + 0x018)); // 0270DA657B58 0x18 _Frame                      ( 0001865FDD50 ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32 )
            value.Rotated                                   = GetBool(new IntPtr(p + 0x028)); // 0270DA657B78 0x28 Rotated                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Trimmed                                   = GetBool(new IntPtr(p + 0x029)); // 0270DA657B98 0x29 Trimmed                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SpriteSourceSize                          = (SpriteFrame)GetInt32(new IntPtr(p + 0x02C)); // 0270DA657BB8 0x2C SpriteSourceSize            ( 0001865FDD50 ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32 )
            value.SourceSize                                = (SpriteSize)GetInt32(new IntPtr(p + 0x03C)); // 0270DA657BD8 0x3C SourceSize                  ( 0001865FE1B0 ModelEnumType SpriteSize SpriteSize SpriteSize Int32 )
            value.Pivot                                     = (Vector2)GetInt32(new IntPtr(p + 0x044)); // 0270DA657BF8 0x44 Pivot                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
