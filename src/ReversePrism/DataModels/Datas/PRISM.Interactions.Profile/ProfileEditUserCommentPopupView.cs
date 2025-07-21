using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommentInputField                        ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 028 CommentCount                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onDecide                                 Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 040 CommentText                              ModelPrimitiveType string string string String
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileEditUserCommentPopupView : DataModel
    {
        public CommonInputFieldTMP?                     CommentInputField                       { get; set; }
        public UITextMeshProUGUI?                       CommentCount                            { get; set; }
        public string                                   CommentText                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileEditUserCommentPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEditUserCommentPopupView() { Pointer= p0 };

            value.CommentInputField                         = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x20 CommentInputField           ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.CommentCount                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 CommentCount                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentText                               = GetString(new IntPtr(p + 0x040)); // 0x40 CommentText                 ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
