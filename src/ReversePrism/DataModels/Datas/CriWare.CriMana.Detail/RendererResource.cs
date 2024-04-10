using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Shader                                   00018674C960 ModelClassType Shader Shader Shader Pointer
    // 020 CurrentMaterial                          00018660C290 ModelClassType Material Material Material Pointer
    // 028 HasAlpha                                 000186595480 ModelPrimitiveType bool bool bool Bool
    // 029 Additive                                 000186595480 ModelPrimitiveType bool bool bool Bool
    // 02A ApplyTargetAlpha                         000186595480 ModelPrimitiveType bool bool bool Bool
    // 02B Ui                                       000186595480 ModelPrimitiveType bool bool bool Bool
    public partial class RendererResource : DataModel
    {
        public bool                                     Disposed                                { get; set; }
        public Shader?                                  Shader                                  { get; set; }
        public Material?                                CurrentMaterial                         { get; set; }
        public bool                                     HasAlpha                                { get; set; }
        public bool                                     Additive                                { get; set; }
        public bool                                     ApplyTargetAlpha                        { get; set; }
        public bool                                     Ui                                      { get; set; }

        public static RendererResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererResource() { Pointer= p0 };

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0245A4ACFF50 0x10 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Shader                                    = GetObject<Shader>(new IntPtr(p + 0x018), ReversePrism.DataModels.Shader.FromPointer); // 0245A4ACFF70 0x18 Shader                      ( 00018674C960 ModelClassType Shader Shader Shader Pointer )
            value.CurrentMaterial                           = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0245A4ACFF90 0x20 CurrentMaterial             ( 00018660C290 ModelClassType Material Material Material Pointer )
            value.HasAlpha                                  = GetBool(new IntPtr(p + 0x028)); // 0245A4ACFFB0 0x28 HasAlpha                    ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Additive                                  = GetBool(new IntPtr(p + 0x029)); // 0245A4ACFFD0 0x29 Additive                    ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.ApplyTargetAlpha                          = GetBool(new IntPtr(p + 0x02A)); // 0245A4ACFFF0 0x2A ApplyTargetAlpha            ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Ui                                        = GetBool(new IntPtr(p + 0x02B)); // 0245A4AD0010 0x2B Ui                          ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
