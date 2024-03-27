using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Message                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PlayerIdLabel                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 PlayerIdValueText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 CopyIdText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CopyIdButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 onContactButtonClicked                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onCloseRequested                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class TransferContactPopupView
    {
        public UITextMeshProUGUI?                       Message                                 { get; set; }
        public UITextMeshProUGUI?                       PlayerIdLabel                           { get; set; }
        public UITextMeshProUGUI?                       PlayerIdValueText                       { get; set; }
        public UITextMeshProUGUI?                       CopyIdText                              { get; set; }
        public UIButton?                                CopyIdButton                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static TransferContactPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferContactPopupView();

            value.Message                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395620 0x20 Message                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayerIdLabel                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395640 0x28 PlayerIdLabel               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayerIdValueText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395660 0x30 PlayerIdValueText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CopyIdText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395680 0x38 CopyIdText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CopyIdButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270043956A0 0x40 CopyIdButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 027004395700 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
