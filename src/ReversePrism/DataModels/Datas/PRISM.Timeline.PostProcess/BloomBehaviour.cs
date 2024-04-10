using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 DownSampleLevel                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Intensity                                000186666050 ModelPrimitiveType float float float Single
    // 01C Threshold                                000186666050 ModelPrimitiveType float float float Single
    // 020 SoftKnee                                 000186666050 ModelPrimitiveType float float float Single
    // 024 Clamp                                    000186666050 ModelPrimitiveType float float float Single
    // 028 Diffusion                                000186666050 ModelPrimitiveType float float float Single
    // 02C AnamorphicRatio                          000186666050 ModelPrimitiveType float float float Single
    // 030 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 040 DirtTexture                              00018664D720 ModelClassType Texture Texture Texture Pointer
    // 048 DirtIntensity                            000186666050 ModelPrimitiveType float float float Single
    // 04C Tiling                                   0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 Brightness                               0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class BloomBehaviour : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public int                                      DownSampleLevel                         { get; set; }
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

        public static BloomBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BloomBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0246650D8070 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DownSampleLevel                           = GetInt32(new IntPtr(p + 0x014)); // 0246650D8090 0x14 DownSampleLevel             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Intensity                                 = GetSingle(new IntPtr(p + 0x018)); // 0246650D80B0 0x18 Intensity                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Threshold                                 = GetSingle(new IntPtr(p + 0x01C)); // 0246650D80D0 0x1C Threshold                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.SoftKnee                                  = GetSingle(new IntPtr(p + 0x020)); // 0246650D80F0 0x20 SoftKnee                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Clamp                                     = GetSingle(new IntPtr(p + 0x024)); // 0246650D8110 0x24 Clamp                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Diffusion                                 = GetSingle(new IntPtr(p + 0x028)); // 0246650D8130 0x28 Diffusion                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.AnamorphicRatio                           = GetSingle(new IntPtr(p + 0x02C)); // 0246650D8150 0x2C AnamorphicRatio             ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x030)); // 0246650D8170 0x30 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.DirtTexture                               = GetObject<Texture>(new IntPtr(p + 0x040), ReversePrism.DataModels.Texture.FromPointer); // 0246650D8190 0x40 DirtTexture                 ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.DirtIntensity                             = GetSingle(new IntPtr(p + 0x048)); // 0246650D81B0 0x48 DirtIntensity               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Tiling                                    = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0246650D81D0 0x4C Tiling                      ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Brightness                                = (Color)GetInt32(new IntPtr(p + 0x054)); // 0246650D81F0 0x54 Brightness                  ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
