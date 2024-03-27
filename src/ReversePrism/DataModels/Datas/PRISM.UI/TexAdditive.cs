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
    // 020 Graphic                                  0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 028 TexAdditiveMat                           00018660BDD0 ModelClassType Material Material Material Pointer
    // 030 Shader                                   00018674C760 ModelClassType Shader Shader Shader Pointer
    // 038 TintColor                                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 048 EffectTexture                            00018664CFB0 ModelClassType Texture Texture Texture Pointer
    // 050 AdditiveAmount                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class TexAdditive
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
            var value   = new TexAdditive();

            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 0270D5D27EB0 0x20 Graphic                     ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.TexAdditiveMat                            = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0270D5D27ED0 0x28 TexAdditiveMat              ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.Shader                                    = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0270D5D27EF0 0x30 Shader                      ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.TintColor                                 = (Color)GetInt32(new IntPtr(p + 0x038)); // 0270D5D27F10 0x38 TintColor                   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.EffectTexture                             = GetObject<Texture>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture.FromPointer); // 0270D5D27F30 0x48 EffectTexture               ( 00018664CFB0 ModelClassType Texture Texture Texture Pointer )
            value.AdditiveAmount                            = GetSingle(new IntPtr(p + 0x050)); // 0270D5D27F50 0x50 AdditiveAmount              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
