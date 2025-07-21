using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgItem                                  ModelClassType RawImage RawImage RawImage Pointer
    // 028 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 030 TxtRequiredAmount                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtCurrentAmount                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 OutlineForTextMeshProUGUI                ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer
    public partial class RequiredCurrentItemIconView : DataModel
    {
        public RawImage?                                ImgItem                                 { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredAmount                       { get; set; }
        public UITextMeshProUGUI?                       TxtCurrentAmount                        { get; set; }
        public ColorToOutlineForTextMeshProUGUI?        OutlineForTextMeshProUGUI               { get; set; }

        public static RequiredCurrentItemIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiredCurrentItemIconView() { Pointer= p0 };

            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 ImgItem                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtRequiredAmount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtRequiredAmount           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCurrentAmount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtCurrentAmount            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OutlineForTextMeshProUGUI                 = GetObject<ColorToOutlineForTextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.ColorToOutlineForTextMeshProUGUI.FromPointer); // 0x40 OutlineForTextMeshProUGUI   ( ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer )

            return value;
        }
    }
}
