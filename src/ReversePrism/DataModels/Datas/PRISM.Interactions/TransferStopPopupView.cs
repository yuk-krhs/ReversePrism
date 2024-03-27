using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TransferStopCategory                     string IL2CPP_TYPE_STRING
    // 000 TitleId                                  int IL2CPP_TYPE_I4
    // 000 MessageId                                int IL2CPP_TYPE_I4
    // 000 ContactCategory                          string IL2CPP_TYPE_STRING
    // 000 PlayerIdLabel                            int IL2CPP_TYPE_I4
    // 000 PlayerIdNotExist                         int IL2CPP_TYPE_I4
    // 000 CopyIdText                               int IL2CPP_TYPE_I4
    // 000 ContactButtonText                        int IL2CPP_TYPE_I4
    // 000 CopyFinishPopupTitle                     int IL2CPP_TYPE_I4
    // 000 CopyFinishPopupMessage                   int IL2CPP_TYPE_I4
    // 000 CommonPopupCategory                      string IL2CPP_TYPE_STRING
    // 000 CancelButtonText                         int IL2CPP_TYPE_I4
    // 020 Message                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PlayerIdLabel                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 PlayerIdValueText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 CopyIdText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CopyIdButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 onClickSubject                           Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 UrlQuery                                 000186671910 ModelPrimitiveType string string string String
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class TransferStopPopupView
    {
        public UITextMeshProUGUI?                       Message                                 { get; set; }
        public UITextMeshProUGUI?                       PlayerIdLabel                           { get; set; }
        public UITextMeshProUGUI?                       PlayerIdValueText                       { get; set; }
        public UITextMeshProUGUI?                       CopyIdText                              { get; set; }
        public UIButton?                                CopyIdButton                            { get; set; }
        public string                                   UrlQuery                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static TransferStopPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferStopPopupView();

            value.Message                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF16058 0x20 Message                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayerIdLabel                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF16078 0x28 PlayerIdLabel               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayerIdValueText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF16098 0x30 PlayerIdValueText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CopyIdText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF160B8 0x38 CopyIdText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CopyIdButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBF160D8 0x40 CopyIdButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UrlQuery                                  = GetString(new IntPtr(p + 0x050)); // 0270DBF16118 0x50 UrlQuery                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBF16138 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
