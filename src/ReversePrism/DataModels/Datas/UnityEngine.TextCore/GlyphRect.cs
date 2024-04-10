using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_X                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Y                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_Width                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_Height                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 s_ZeroGlyphRect                          GlyphRect IL2CPP_TYPE_VALUETYPE
    public partial class GlyphRect : DataModel
    {
        public int                                      M_X                                     { get; set; }
        public int                                      M_Y                                     { get; set; }
        public int                                      M_Width                                 { get; set; }
        public int                                      M_Height                                { get; set; }

        public static GlyphRect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphRect() { Pointer= p0 };

            value.M_X                                       = GetInt32(new IntPtr(p + 0x010)); // 0245A215B6E8 0x10 M_X                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Y                                       = GetInt32(new IntPtr(p + 0x014)); // 0245A215B708 0x14 M_Y                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Width                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A215B728 0x18 M_Width                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Height                                  = GetInt32(new IntPtr(p + 0x01C)); // 0245A215B748 0x1C M_Height                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
