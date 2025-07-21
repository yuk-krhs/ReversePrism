using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgSCharaFull                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 BtnClose                                 ModelClassType UIButton UIButton UIButton Pointer
    // 030 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class SCharaFullImageOverlayView : DataModel
    {
        public UIRawImage?                              ImgSCharaFull                           { get; set; }
        public UIButton?                                BtnClose                                { get; set; }

        public static SCharaFullImageOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaFullImageOverlayView() { Pointer= p0 };

            value.ImgSCharaFull                             = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 ImgSCharaFull               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnClose                                  = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnClose                    ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
