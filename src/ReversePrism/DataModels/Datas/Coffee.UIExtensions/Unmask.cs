using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Center                                 Vector2 IL2CPP_TYPE_VALUETYPE
    // 020 M_FitTarget                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 M_FitOnLateUpdate                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_OnlyForChildren                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02A M_ShowUnmaskGraphic                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 UnmaskMaterial                           00018660BDD0 ModelClassType Material Material Material Pointer
    // 038 RevertUnmaskMaterial                     00018660BDD0 ModelClassType Material Material Material Pointer
    // 040 Graphic                                  0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    public partial class Unmask : DataModel
    {
        public RectTransform?                           M_FitTarget                             { get; set; }
        public bool                                     M_FitOnLateUpdate                       { get; set; }
        public bool                                     M_OnlyForChildren                       { get; set; }
        public bool                                     M_ShowUnmaskGraphic                     { get; set; }
        public Material?                                UnmaskMaterial                          { get; set; }
        public Material?                                RevertUnmaskMaterial                    { get; set; }
        public Graphic?                                 Graphic                                 { get; set; }

        public static Unmask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Unmask() { Pointer= p0 };

            value.M_FitTarget                               = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 02466BCAA558 0x20 M_FitTarget                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_FitOnLateUpdate                         = GetBool(new IntPtr(p + 0x028)); // 02466BCAA578 0x28 M_FitOnLateUpdate           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_OnlyForChildren                         = GetBool(new IntPtr(p + 0x029)); // 02466BCAA598 0x29 M_OnlyForChildren           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShowUnmaskGraphic                       = GetBool(new IntPtr(p + 0x02A)); // 02466BCAA5B8 0x2A M_ShowUnmaskGraphic         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnmaskMaterial                            = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 02466BCAA5D8 0x30 UnmaskMaterial              ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.RevertUnmaskMaterial                      = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 02466BCAA5F8 0x38 RevertUnmaskMaterial        ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x040), ReversePrism.DataModels.Graphic.FromPointer); // 02466BCAA618 0x40 Graphic                     ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )

            return value;
        }
    }
}
