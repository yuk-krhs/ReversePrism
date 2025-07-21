using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Sprite                                 ModelClassType Sprite Sprite Sprite Pointer
    // 020 M_Color                                  ModelEnumType Color Color Color Int32
    // 030 M_Transform                              ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 070 M_InstancedGameObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 078 M_Flags                                  ModelEnumType TileFlags TileFlags TileFlags Int32
    // 07C M_ColliderType                           ModelEnumType ColliderType ColliderType ColliderType Int32
    public partial class Tile : DataModel
    {
        public Sprite?                                  M_Sprite                                { get; set; }
        public Color                                    M_Color                                 { get; set; }
        public Matrix4x4                                M_Transform                             { get; set; }
        public GameObject?                              M_InstancedGameObject                   { get; set; }
        public TileFlags                                M_Flags                                 { get; set; }
        public ColliderType                             M_ColliderType                          { get; set; }

        public static Tile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tile() { Pointer= p0 };

            value.M_Sprite                                  = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0x18 M_Sprite                    ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_Color                                   = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Color                     ( ModelEnumType Color Color Color Int32 )
            value.M_Transform                               = (Matrix4x4)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_Transform                 ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_InstancedGameObject                     = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 M_InstancedGameObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_Flags                                   = (TileFlags)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_Flags                     ( ModelEnumType TileFlags TileFlags TileFlags Int32 )
            value.M_ColliderType                            = (ColliderType)GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_ColliderType              ( ModelEnumType ColliderType ColliderType ColliderType Int32 )

            return value;
        }
    }
}
