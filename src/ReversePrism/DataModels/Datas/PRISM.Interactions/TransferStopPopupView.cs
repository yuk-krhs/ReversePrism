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
    // 020 Message                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PlayerIdLabel                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 PlayerIdValueText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 CopyIdText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CopyIdButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 048 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onClickFaq                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 UrlQuery                                 ModelPrimitiveType string string string String
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class TransferStopPopupView : DataModel
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
            var value   = new TransferStopPopupView() { Pointer= p0 };

            value.Message                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 Message                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayerIdLabel                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 PlayerIdLabel               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayerIdValueText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 PlayerIdValueText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CopyIdText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 CopyIdText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CopyIdButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 CopyIdButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UrlQuery                                  = GetString(new IntPtr(p + 0x058)); // 0x58 UrlQuery                    ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
