using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Sprite                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Color                                  0001865AA8E0 ModelEnumType Color Color Color Int32
    // 024 M_Transform                              00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 064 M_GameObject                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 M_Flags                                  000186664E00 ModelEnumType TileFlags TileFlags TileFlags Int32
    // 06C M_ColliderType                           000186602CC0 ModelEnumType ColliderType ColliderType ColliderType Int32
    public partial class TileDataNative
    {
        public int                                      M_Sprite                                { get; set; }
        public Color                                    M_Color                                 { get; set; }
        public Matrix4x4                                M_Transform                             { get; set; }
        public int                                      M_GameObject                            { get; set; }
        public TileFlags                                M_Flags                                 { get; set; }
        public ColliderType                             M_ColliderType                          { get; set; }

        public static TileDataNative? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TileDataNative();

            value.M_Sprite                                  = GetInt32(new IntPtr(p + 0x010)); // 02700221C790 0x10 M_Sprite                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Color                                   = (Color)GetInt32(new IntPtr(p + 0x014)); // 02700221C7B0 0x14 M_Color                     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_Transform                               = (Matrix4x4)GetInt32(new IntPtr(p + 0x024)); // 02700221C7D0 0x24 M_Transform                 ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_GameObject                              = GetInt32(new IntPtr(p + 0x064)); // 02700221C7F0 0x64 M_GameObject                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Flags                                   = (TileFlags)GetInt32(new IntPtr(p + 0x068)); // 02700221C810 0x68 M_Flags                     ( 000186664E00 ModelEnumType TileFlags TileFlags TileFlags Int32 )
            value.M_ColliderType                            = (ColliderType)GetInt32(new IntPtr(p + 0x06C)); // 02700221C830 0x6C M_ColliderType              ( 000186602CC0 ModelEnumType ColliderType ColliderType ColliderType Int32 )

            return value;
        }
    }
}
