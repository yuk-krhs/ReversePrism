using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Texture                                  000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 018 Hotspot                                  0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 DefaultCursorId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Cursor : DataModel
    {
        public Texture2D?                               Texture                                 { get; set; }
        public Vector2                                  Hotspot                                 { get; set; }
        public int                                      DefaultCursorId                         { get; set; }

        public static Cursor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cursor() { Pointer= p0 };

            value.Texture                                   = GetObject<Texture2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A3F1F1D8 0x10 Texture                     ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Hotspot                                   = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0245A3F1F1F8 0x18 Hotspot                     ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DefaultCursorId                           = GetInt32(new IntPtr(p + 0x020)); // 0245A3F1F218 0x20 DefaultCursorId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
