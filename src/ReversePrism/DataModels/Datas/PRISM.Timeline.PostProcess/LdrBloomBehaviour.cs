using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 Intensity                                ModelPrimitiveType float float float Single
    // 018 Threshold                                ModelPrimitiveType float float float Single
    // 01C SoftKnee                                 ModelPrimitiveType float float float Single
    // 020 Clamp                                    ModelPrimitiveType float float float Single
    // 024 Diffusion                                ModelPrimitiveType float float float Single
    // 028 AnamorphicRatio                          ModelPrimitiveType float float float Single
    // 02C Color                                    ModelEnumType Color Color Color Int32
    // 040 DirtTexture                              ModelClassType Texture Texture Texture Pointer
    // 048 DirtIntensity                            ModelPrimitiveType float float float Single
    // 04C Tiling                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 Brightness                               ModelEnumType Color Color Color Int32
    public partial class LdrBloomBehaviour : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public float                                    Intensity                               { get; set; }
        public float                                    Threshold                               { get; set; }
        public float                                    SoftKnee                                { get; set; }
        public float                                    Clamp                                   { get; set; }
        public float                                    Diffusion                               { get; set; }
        public float                                    AnamorphicRatio                         { get; set; }
        public Color                                    Color                                   { get; set; }
        public Texture?                                 DirtTexture                             { get; set; }
        public float                                    DirtIntensity                           { get; set; }
        public Vector2                                  Tiling                                  { get; set; }
        public Color                                    Brightness                              { get; set; }

        public static LdrBloomBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LdrBloomBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.Intensity                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 Intensity                   ( ModelPrimitiveType float float float Single )
            value.Threshold                                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 Threshold                   ( ModelPrimitiveType float float float Single )
            value.SoftKnee                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C SoftKnee                    ( ModelPrimitiveType float float float Single )
            value.Clamp                                     = GetSingle(new IntPtr(p + 0x020)); // 0x20 Clamp                       ( ModelPrimitiveType float float float Single )
            value.Diffusion                                 = GetSingle(new IntPtr(p + 0x024)); // 0x24 Diffusion                   ( ModelPrimitiveType float float float Single )
            value.AnamorphicRatio                           = GetSingle(new IntPtr(p + 0x028)); // 0x28 AnamorphicRatio             ( ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Color                       ( ModelEnumType Color Color Color Int32 )
            value.DirtTexture                               = GetObject<Texture>(new IntPtr(p + 0x040), ReversePrism.DataModels.Texture.FromPointer); // 0x40 DirtTexture                 ( ModelClassType Texture Texture Texture Pointer )
            value.DirtIntensity                             = GetSingle(new IntPtr(p + 0x048)); // 0x48 DirtIntensity               ( ModelPrimitiveType float float float Single )
            value.Tiling                                    = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0x4C Tiling                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Brightness                                = (Color)GetInt32(new IntPtr(p + 0x054)); // 0x54 Brightness                  ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
