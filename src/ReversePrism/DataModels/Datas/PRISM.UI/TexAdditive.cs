using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TintColorID                              int IL2CPP_TYPE_I4
    // 004 EffectTextureID                          int IL2CPP_TYPE_I4
    // 008 AdditiveAmountID                         int IL2CPP_TYPE_I4
    // 020 Graphic                                  ModelClassType Graphic Graphic Graphic Pointer
    // 028 TexAdditiveMat                           ModelClassType Material Material Material Pointer
    // 030 Shader                                   ModelClassType Shader Shader Shader Pointer
    // 038 TintColor                                ModelEnumType Color Color Color Int32
    // 048 EffectTexture                            ModelClassType Texture Texture Texture Pointer
    // 050 AdditiveAmount                           ModelPrimitiveType float float float Single
    public partial class TexAdditive : DataModel
    {
        public Graphic?                                 Graphic                                 { get; set; }
        public Material?                                TexAdditiveMat                          { get; set; }
        public Shader?                                  Shader                                  { get; set; }
        public Color                                    TintColor                               { get; set; }
        public Texture?                                 EffectTexture                           { get; set; }
        public float                                    AdditiveAmount                          { get; set; }

        public static TexAdditive? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TexAdditive() { Pointer= p0 };

            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 0x20 Graphic                     ( ModelClassType Graphic Graphic Graphic Pointer )
            value.TexAdditiveMat                            = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 TexAdditiveMat              ( ModelClassType Material Material Material Pointer )
            value.Shader                                    = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0x30 Shader                      ( ModelClassType Shader Shader Shader Pointer )
            value.TintColor                                 = (Color)GetInt32(new IntPtr(p + 0x038)); // 0x38 TintColor                   ( ModelEnumType Color Color Color Int32 )
            value.EffectTexture                             = GetObject<Texture>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture.FromPointer); // 0x48 EffectTexture               ( ModelClassType Texture Texture Texture Pointer )
            value.AdditiveAmount                            = GetSingle(new IntPtr(p + 0x050)); // 0x50 AdditiveAmount              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
