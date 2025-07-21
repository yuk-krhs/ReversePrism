using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Filename                                 ModelPrimitiveType string string string String
    // 018 _Frame                                   ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32
    // 028 Rotated                                  ModelPrimitiveType bool bool bool Bool
    // 029 Trimmed                                  ModelPrimitiveType bool bool bool Bool
    // 02C SpriteSourceSize                         ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32
    // 03C SourceSize                               ModelEnumType SpriteSize SpriteSize SpriteSize Int32
    // 044 Pivot                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class Frame : DataModel
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
            var value   = new Frame() { Pointer= p0 };

            value.Filename                                  = GetString(new IntPtr(p + 0x010)); // 0x10 Filename                    ( ModelPrimitiveType string string string String )
            value._Frame                                    = (SpriteFrame)GetInt32(new IntPtr(p + 0x018)); // 0x18 _Frame                      ( ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32 )
            value.Rotated                                   = GetBool(new IntPtr(p + 0x028)); // 0x28 Rotated                     ( ModelPrimitiveType bool bool bool Bool )
            value.Trimmed                                   = GetBool(new IntPtr(p + 0x029)); // 0x29 Trimmed                     ( ModelPrimitiveType bool bool bool Bool )
            value.SpriteSourceSize                          = (SpriteFrame)GetInt32(new IntPtr(p + 0x02C)); // 0x2C SpriteSourceSize            ( ModelEnumType SpriteFrame SpriteFrame SpriteFrame Int32 )
            value.SourceSize                                = (SpriteSize)GetInt32(new IntPtr(p + 0x03C)); // 0x3C SourceSize                  ( ModelEnumType SpriteSize SpriteSize SpriteSize Int32 )
            value.Pivot                                     = (Vector2)GetInt32(new IntPtr(p + 0x044)); // 0x44 Pivot                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
