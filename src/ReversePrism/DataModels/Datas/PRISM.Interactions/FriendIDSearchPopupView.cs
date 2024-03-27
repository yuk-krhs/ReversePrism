using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MyID                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 MyIDCopyButton                           000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 StringField                              0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 038 YourIDText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 SearchIDText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 InputCountText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onClose                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 UserSearchId                             000186671910 ModelPrimitiveType string string string String
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FriendIDSearchPopupView
    {
        public UITextMeshProUGUI?                       MyID                                    { get; set; }
        public ButtonBase?                              MyIDCopyButton                          { get; set; }
        public CommonInputFieldTMP?                     StringField                             { get; set; }
        public UITextMeshProUGUI?                       YourIDText                              { get; set; }
        public UITextMeshProUGUI?                       SearchIDText                            { get; set; }
        public UITextMeshProUGUI?                       InputCountText                          { get; set; }
        public string                                   UserSearchId                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FriendIDSearchPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendIDSearchPopupView();

            value.MyID                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE5888 0x20 MyID                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MyIDCopyButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DBDE58A8 0x28 MyIDCopyButton              ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StringField                               = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0270DBDE58C8 0x30 StringField                 ( 0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.YourIDText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE58E8 0x38 YourIDText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SearchIDText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE5908 0x40 SearchIDText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InputCountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE5928 0x48 InputCountText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UserSearchId                              = GetString(new IntPtr(p + 0x058)); // 0270DBDE5968 0x58 UserSearchId                ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBDE5988 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
