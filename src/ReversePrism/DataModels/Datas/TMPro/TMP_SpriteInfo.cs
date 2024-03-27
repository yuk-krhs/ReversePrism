using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SpriteIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 CharacterIndex                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 VertexIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TMP_SpriteInfo
    {
        public int                                      SpriteIndex                             { get; set; }
        public int                                      CharacterIndex                          { get; set; }
        public int                                      VertexIndex                             { get; set; }

        public static TMP_SpriteInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_SpriteInfo();

            value.SpriteIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0270DA6104D8 0x10 SpriteIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CharacterIndex                            = GetInt32(new IntPtr(p + 0x014)); // 0270DA6104F8 0x14 CharacterIndex              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VertexIndex                               = GetInt32(new IntPtr(p + 0x018)); // 0270DA610518 0x18 VertexIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
