using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 Image                                    ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class EndTutorialConfirmPopupView : DataModel
    {
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public UIRawImage?                              Image                                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static EndTutorialConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EndTutorialConfirmPopupView() { Pointer= p0 };

            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Image                                     = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 Image                       ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
