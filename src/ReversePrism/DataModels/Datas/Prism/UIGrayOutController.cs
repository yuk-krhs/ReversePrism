using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Excludes                                 ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer
    // 028 GrayOutColor                             ModelEnumType Color Color Color Int32
    // 038 originalColors                           Dictionary`2<Graphic, Color> IL2CPP_TYPE_GENERICINST
    // 040 originalTMPOutlineColors                 Dictionary`2<ColorToOutlineForTextMeshProUGUI, Color> IL2CPP_TYPE_GENERICINST
    // 048 originalTMPUnderlayColors                Dictionary`2<ColorToUnderlayForTextMeshProUGUI, Color> IL2CPP_TYPE_GENERICINST
    // 050 originalGradients                        Dictionary`2<UIGradient, Gradient> IL2CPP_TYPE_GENERICINST
    // 058 IsGrayOut                                ModelPrimitiveType bool bool bool Bool
    public partial class UIGrayOutController : DataModel
    {
        public List<Graphic>?                           Excludes                                { get; set; }
        public Color                                    GrayOutColor                            { get; set; }
        public bool                                     IsGrayOut                               { get; set; }

        public static UIGrayOutController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIGrayOutController() { Pointer= p0 };

            value.Excludes                                  = GetObjectList<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 0x20 Excludes                    ( ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer )
            value.GrayOutColor                              = (Color)GetInt32(new IntPtr(p + 0x028)); // 0x28 GrayOutColor                ( ModelEnumType Color Color Color Int32 )
            value.IsGrayOut                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 IsGrayOut                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
