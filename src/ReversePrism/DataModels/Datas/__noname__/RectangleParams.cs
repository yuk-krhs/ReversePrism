using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 020 Uv                                       00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 030 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 040 SubRect                                  00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 050 BackgroundPositionX                      00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 05C BackgroundPositionY                      00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 068 BackgroundRepeat                         000186590710 ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32
    // 070 BackgroundSize                           0001865913C0 ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32
    // 088 Texture                                  00018664D720 ModelClassType Texture Texture Texture Pointer
    // 090 Sprite                                   00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 098 VectorImage                              0001866B03B0 ModelClassType VectorImage VectorImage VectorImage Pointer
    // 0A0 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 0A8 ScaleMode                                0001866C1AA0 ModelEnumType ScaleMode ScaleMode ScaleMode Int32
    // 0AC PlaymodeTintColor                        0001865AB0A0 ModelEnumType Color Color Color Int32
    // 0BC TopLeftRadius                            0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0C4 TopRightRadius                           0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0CC BottomRightRadius                        0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0D4 BottomLeftRadius                         0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0DC ContentSize                              0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0E4 TextureSize                              0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0EC LeftSlice                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 0F0 TopSlice                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 0F4 RightSlice                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 0F8 BottomSlice                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 0FC SliceScale                               000186666050 ModelPrimitiveType float float float Single
    // 100 SpriteGeomRect                           00018664F8A0 ModelEnumType Rect Rect Rect Int32
    // 110 ColorPage                                0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32
    // 118 MeshFlags                                0001867105B0 ModelEnumType MeshFlags MeshFlags MeshFlags Int32
    public partial class RectangleParams : DataModel
    {
        public Rect                                     Rect                                    { get; set; }
        public Rect                                     Uv                                      { get; set; }
        public Color                                    Color                                   { get; set; }
        public Rect                                     SubRect                                 { get; set; }
        public BackgroundPosition                       BackgroundPositionX                     { get; set; }
        public BackgroundPosition                       BackgroundPositionY                     { get; set; }
        public BackgroundRepeat                         BackgroundRepeat                        { get; set; }
        public BackgroundSize                           BackgroundSize                          { get; set; }
        public Texture?                                 Texture                                 { get; set; }
        public Sprite?                                  Sprite                                  { get; set; }
        public VectorImage?                             VectorImage                             { get; set; }
        public Material?                                Material                                { get; set; }
        public ScaleMode                                ScaleMode                               { get; set; }
        public Color                                    PlaymodeTintColor                       { get; set; }
        public Vector2                                  TopLeftRadius                           { get; set; }
        public Vector2                                  TopRightRadius                          { get; set; }
        public Vector2                                  BottomRightRadius                       { get; set; }
        public Vector2                                  BottomLeftRadius                        { get; set; }
        public Vector2                                  ContentSize                             { get; set; }
        public Vector2                                  TextureSize                             { get; set; }
        public int                                      LeftSlice                               { get; set; }
        public int                                      TopSlice                                { get; set; }
        public int                                      RightSlice                              { get; set; }
        public int                                      BottomSlice                             { get; set; }
        public float                                    SliceScale                              { get; set; }
        public Rect                                     SpriteGeomRect                          { get; set; }
        public ColorPage                                ColorPage                               { get; set; }
        public MeshFlags                                MeshFlags                               { get; set; }

        public static RectangleParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectangleParams() { Pointer= p0 };

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0245A67AA020 0x10 Rect                        ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Uv                                        = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0245A67AA040 0x20 Uv                          ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x030)); // 0245A67AA060 0x30 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.SubRect                                   = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0245A67AA080 0x40 SubRect                     ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.BackgroundPositionX                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x050)); // 0245A67AA0A0 0x50 BackgroundPositionX         ( 00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundPositionY                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x05C)); // 0245A67AA0C0 0x5C BackgroundPositionY         ( 00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundRepeat                          = (BackgroundRepeat)GetInt32(new IntPtr(p + 0x068)); // 0245A67AA0E0 0x68 BackgroundRepeat            ( 000186590710 ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32 )
            value.BackgroundSize                            = (BackgroundSize)GetInt32(new IntPtr(p + 0x070)); // 0245A67AA100 0x70 BackgroundSize              ( 0001865913C0 ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32 )
            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x088), ReversePrism.DataModels.Texture.FromPointer); // 0245A67AA120 0x88 Texture                     ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x090), ReversePrism.DataModels.Sprite.FromPointer); // 0245A67AA140 0x90 Sprite                      ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.VectorImage                               = GetObject<VectorImage>(new IntPtr(p + 0x098), ReversePrism.DataModels.VectorImage.FromPointer); // 0245A67AA160 0x98 VectorImage                 ( 0001866B03B0 ModelClassType VectorImage VectorImage VectorImage Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Material.FromPointer); // 0245A67AA180 0xA0 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.ScaleMode                                 = (ScaleMode)GetInt32(new IntPtr(p + 0x0A8)); // 0245A67AA1A0 0xA8 ScaleMode                   ( 0001866C1AA0 ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.PlaymodeTintColor                         = (Color)GetInt32(new IntPtr(p + 0x0AC)); // 0245A67AA1C0 0xAC PlaymodeTintColor           ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x0BC)); // 0245A67AA1E0 0xBC TopLeftRadius               ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x0C4)); // 0245A67AA200 0xC4 TopRightRadius              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x0CC)); // 0245A67AA220 0xCC BottomRightRadius           ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x0D4)); // 0245A67AA240 0xD4 BottomLeftRadius            ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ContentSize                               = (Vector2)GetInt32(new IntPtr(p + 0x0DC)); // 0245A67AA260 0xDC ContentSize                 ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TextureSize                               = (Vector2)GetInt32(new IntPtr(p + 0x0E4)); // 0245A67AA280 0xE4 TextureSize                 ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftSlice                                 = GetInt32(new IntPtr(p + 0x0EC)); // 0245A67AA2A0 0xEC LeftSlice                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TopSlice                                  = GetInt32(new IntPtr(p + 0x0F0)); // 0245A67AA2C0 0xF0 TopSlice                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RightSlice                                = GetInt32(new IntPtr(p + 0x0F4)); // 0245A67AA2E0 0xF4 RightSlice                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BottomSlice                               = GetInt32(new IntPtr(p + 0x0F8)); // 0245A67AA300 0xF8 BottomSlice                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SliceScale                                = GetSingle(new IntPtr(p + 0x0FC)); // 0245A67AA320 0xFC SliceScale                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.SpriteGeomRect                            = (Rect)GetInt32(new IntPtr(p + 0x100)); // 0245A67AA340 0x100 SpriteGeomRect              ( 00018664F8A0 ModelEnumType Rect Rect Rect Int32 )
            value.ColorPage                                 = (ColorPage)GetInt32(new IntPtr(p + 0x110)); // 0245A67AA360 0x110 ColorPage                   ( 0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.MeshFlags                                 = (MeshFlags)GetInt32(new IntPtr(p + 0x118)); // 0245A67AA380 0x118 MeshFlags                   ( 0001867105B0 ModelEnumType MeshFlags MeshFlags MeshFlags Int32 )

            return value;
        }
    }
}
