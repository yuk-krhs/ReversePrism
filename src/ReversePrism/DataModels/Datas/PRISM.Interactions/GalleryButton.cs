using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 UiGradient                               ModelClassType UIGradient UIGradient UIGradient Pointer
    // 030 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 038 onTap                                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class GalleryButton : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public UIGradient?                              UiGradient                              { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }

        public static GalleryButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryButton() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UiGradient                                = GetObject<UIGradient>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGradient.FromPointer); // 0x28 UiGradient                  ( ModelClassType UIGradient UIGradient UIGradient Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x30 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )

            return value;
        }
    }
}
