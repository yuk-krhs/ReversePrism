using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 Icon                                     ModelClassType RawImage RawImage RawImage Pointer
    // 030 ImgItemBase                              ModelClassType RawImage RawImage RawImage Pointer
    // 038 ImgItemFrame                             ModelClassType RawImage RawImage RawImage Pointer
    // 040 Text                                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class RewardItem : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public RawImage?                                Icon                                    { get; set; }
        public RawImage?                                ImgItemBase                             { get; set; }
        public RawImage?                                ImgItemFrame                            { get; set; }
        public UITextMeshProUGUI?                       Text                                    { get; set; }

        public static RewardItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardItem() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Icon                                      = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 Icon                        ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemBase                               = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0x30 ImgItemBase                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemFrame                              = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0x38 ImgItemFrame                ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 Text                        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
