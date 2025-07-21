using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MyID                                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 MyIDCopyButton                           ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 StringField                              ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 038 YourIDText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 SearchIDText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 InputCountText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onClose                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 UserSearchId                             ModelPrimitiveType string string string String
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FriendIDSearchPopupView : DataModel
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
            var value   = new FriendIDSearchPopupView() { Pointer= p0 };

            value.MyID                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 MyID                        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MyIDCopyButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 MyIDCopyButton              ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StringField                               = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x30 StringField                 ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.YourIDText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 YourIDText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SearchIDText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 SearchIDText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InputCountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 InputCountText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UserSearchId                              = GetString(new IntPtr(p + 0x058)); // 0x58 UserSearchId                ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
