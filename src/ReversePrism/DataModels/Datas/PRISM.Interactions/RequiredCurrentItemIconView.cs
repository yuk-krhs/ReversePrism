using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgItem                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 TxtRequiredAmount                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtCurrentAmount                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 OutlineForTextMeshProUGUI                0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer
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

            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 02466A2B54E0 0x20 ImgItem                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2B5500 0x28 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtRequiredAmount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2B5520 0x30 TxtRequiredAmount           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCurrentAmount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2B5540 0x38 TxtCurrentAmount            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OutlineForTextMeshProUGUI                 = GetObject<ColorToOutlineForTextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.ColorToOutlineForTextMeshProUGUI.FromPointer); // 02466A2B5560 0x40 OutlineForTextMeshProUGUI   ( 0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer )

            return value;
        }
    }
}
