using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_RectTransform                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 M_ShowMaskGraphic                        ModelPrimitiveType bool bool bool Bool
    // 030 M_Graphic                                ModelClassType Graphic Graphic Graphic Pointer
    // 038 M_MaskMaterial                           ModelClassType Material Material Material Pointer
    // 040 M_UnmaskMaterial                         ModelClassType Material Material Material Pointer
    public partial class Mask : DataModel
    {
        public RectTransform?                           M_RectTransform                         { get; set; }
        public bool                                     M_ShowMaskGraphic                       { get; set; }
        public Graphic?                                 M_Graphic                               { get; set; }
        public Material?                                M_MaskMaterial                          { get; set; }
        public Material?                                M_UnmaskMaterial                        { get; set; }

        public static Mask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mask() { Pointer= p0 };

            value.M_RectTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 M_RectTransform             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ShowMaskGraphic                         = GetBool(new IntPtr(p + 0x028)); // 0x28 M_ShowMaskGraphic           ( ModelPrimitiveType bool bool bool Bool )
            value.M_Graphic                                 = GetObject<Graphic>(new IntPtr(p + 0x030), ReversePrism.DataModels.Graphic.FromPointer); // 0x30 M_Graphic                   ( ModelClassType Graphic Graphic Graphic Pointer )
            value.M_MaskMaterial                            = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 M_MaskMaterial              ( ModelClassType Material Material Material Pointer )
            value.M_UnmaskMaterial                          = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0x40 M_UnmaskMaterial            ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
