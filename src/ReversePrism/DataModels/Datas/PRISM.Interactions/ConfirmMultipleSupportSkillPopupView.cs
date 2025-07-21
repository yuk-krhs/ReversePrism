using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NodePrefab                               ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 028 NodeParent                               ModelClassType Transform Transform Transform Pointer
    // 030 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 PopupFrameParameter                      ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ConfirmMultipleSupportSkillPopupView : DataModel
    {
        public SupportSkillNode?                        NodePrefab                              { get; set; }
        public Transform?                               NodeParent                              { get; set; }
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public PopupFrameParameter?                     PopupFrameParameter                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ConfirmMultipleSupportSkillPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfirmMultipleSupportSkillPopupView() { Pointer= p0 };

            value.NodePrefab                                = GetObject<SupportSkillNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x20 NodePrefab                  ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.NodeParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 NodeParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PopupFrameParameter                       = GetObject<PopupFrameParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x40 PopupFrameParameter         ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
