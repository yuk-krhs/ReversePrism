using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     ModelEnumType Rect Rect Rect Int32
    // 020 Uv                                       ModelEnumType Rect Rect Rect Int32
    // 030 Color                                    ModelEnumType Color Color Color Int32
    // 040 SubRect                                  ModelEnumType Rect Rect Rect Int32
    // 050 BackgroundPositionX                      ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 05C BackgroundPositionY                      ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 068 BackgroundRepeat                         ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32
    // 070 BackgroundSize                           ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32
    // 088 Texture                                  ModelClassType Texture Texture Texture Pointer
    // 090 Sprite                                   ModelClassType Sprite Sprite Sprite Pointer
    // 098 VectorImage                              ModelClassType VectorImage VectorImage VectorImage Pointer
    // 0A0 Material                                 ModelClassType Material Material Material Pointer
    // 0A8 ScaleMode                                ModelEnumType ScaleMode ScaleMode ScaleMode Int32
    // 0AC PlaymodeTintColor                        ModelEnumType Color Color Color Int32
    // 0BC TopLeftRadius                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0C4 TopRightRadius                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0CC BottomRightRadius                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0D4 BottomLeftRadius                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0DC ContentSize                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0E4 TextureSize                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0EC LeftSlice                                ModelPrimitiveType int int int Int32
    // 0F0 TopSlice                                 ModelPrimitiveType int int int Int32
    // 0F4 RightSlice                               ModelPrimitiveType int int int Int32
    // 0F8 BottomSlice                              ModelPrimitiveType int int int Int32
    // 0FC SliceScale                               ModelPrimitiveType float float float Single
    // 100 SpriteGeomRect                           ModelEnumType Rect Rect Rect Int32
    // 110 RectInset                                ModelEnumType Vector4 Vector4 Vector4 Int32
    // 120 ColorPage                                ModelEnumType ColorPage ColorPage ColorPage Int32
    // 128 MeshFlags                                ModelEnumType MeshFlags MeshFlags MeshFlags Int32
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
        public Vector4                                  RectInset                               { get; set; }
        public ColorPage                                ColorPage                               { get; set; }
        public MeshFlags                                MeshFlags                               { get; set; }

        public static RectangleParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectangleParams() { Pointer= p0 };

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 Rect                        ( ModelEnumType Rect Rect Rect Int32 )
            value.Uv                                        = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0x20 Uv                          ( ModelEnumType Rect Rect Rect Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 Color                       ( ModelEnumType Color Color Color Int32 )
            value.SubRect                                   = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0x40 SubRect                     ( ModelEnumType Rect Rect Rect Int32 )
            value.BackgroundPositionX                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x050)); // 0x50 BackgroundPositionX         ( ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundPositionY                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x05C)); // 0x5C BackgroundPositionY         ( ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundRepeat                          = (BackgroundRepeat)GetInt32(new IntPtr(p + 0x068)); // 0x68 BackgroundRepeat            ( ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32 )
            value.BackgroundSize                            = (BackgroundSize)GetInt32(new IntPtr(p + 0x070)); // 0x70 BackgroundSize              ( ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32 )
            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x088), ReversePrism.DataModels.Texture.FromPointer); // 0x88 Texture                     ( ModelClassType Texture Texture Texture Pointer )
            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x090), ReversePrism.DataModels.Sprite.FromPointer); // 0x90 Sprite                      ( ModelClassType Sprite Sprite Sprite Pointer )
            value.VectorImage                               = GetObject<VectorImage>(new IntPtr(p + 0x098), ReversePrism.DataModels.VectorImage.FromPointer); // 0x98 VectorImage                 ( ModelClassType VectorImage VectorImage VectorImage Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Material.FromPointer); // 0xA0 Material                    ( ModelClassType Material Material Material Pointer )
            value.ScaleMode                                 = (ScaleMode)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 ScaleMode                   ( ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.PlaymodeTintColor                         = (Color)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC PlaymodeTintColor           ( ModelEnumType Color Color Color Int32 )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC TopLeftRadius               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 TopRightRadius              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC BottomRightRadius           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 BottomLeftRadius            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ContentSize                               = (Vector2)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC ContentSize                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TextureSize                               = (Vector2)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 TextureSize                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftSlice                                 = GetInt32(new IntPtr(p + 0x0EC)); // 0xEC LeftSlice                   ( ModelPrimitiveType int int int Int32 )
            value.TopSlice                                  = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 TopSlice                    ( ModelPrimitiveType int int int Int32 )
            value.RightSlice                                = GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 RightSlice                  ( ModelPrimitiveType int int int Int32 )
            value.BottomSlice                               = GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 BottomSlice                 ( ModelPrimitiveType int int int Int32 )
            value.SliceScale                                = GetSingle(new IntPtr(p + 0x0FC)); // 0xFC SliceScale                  ( ModelPrimitiveType float float float Single )
            value.SpriteGeomRect                            = (Rect)GetInt32(new IntPtr(p + 0x100)); // 0x100 SpriteGeomRect              ( ModelEnumType Rect Rect Rect Int32 )
            value.RectInset                                 = (Vector4)GetInt32(new IntPtr(p + 0x110)); // 0x110 RectInset                   ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ColorPage                                 = (ColorPage)GetInt32(new IntPtr(p + 0x120)); // 0x120 ColorPage                   ( ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.MeshFlags                                 = (MeshFlags)GetInt32(new IntPtr(p + 0x128)); // 0x128 MeshFlags                   ( ModelEnumType MeshFlags MeshFlags MeshFlags Int32 )

            return value;
        }
    }
}
