using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 040 HashCode                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 Unicode                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 Pivot                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 050 Sprite                                   00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    public partial class TMP_Sprite
    {
        public string                                   Name                                    { get; set; }
        public int                                      HashCode                                { get; set; }
        public int                                      Unicode                                 { get; set; }
        public Vector2                                  Pivot                                   { get; set; }
        public Sprite?                                  Sprite                                  { get; set; }

        public static TMP_Sprite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Sprite();

            value.Name                                      = GetString(new IntPtr(p + 0x038)); // 0270D0DE0058 0x38 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x040)); // 0270D0DE0078 0x40 HashCode                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Unicode                                   = GetInt32(new IntPtr(p + 0x044)); // 0270D0DE0098 0x44 Unicode                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Pivot                                     = (Vector2)GetInt32(new IntPtr(p + 0x048)); // 0270D0DE00B8 0x48 Pivot                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x050), ReversePrism.DataModels.Sprite.FromPointer); // 0270D0DE00D8 0x50 Sprite                      ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
