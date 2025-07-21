using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RewardItemPos                            ModelClassType Transform Transform Transform Pointer
    // 030 RewardItemPrefab                         ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer
    // 038 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 040 FooterArea                               ModelClassType GameObject GameObject GameObject Pointer
    // 048 FooterText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 PopupFrameParameter                      ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ReceiveRewardPopupView : DataModel
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public Transform?                               RewardItemPos                           { get; set; }
        public ReceiveRewardItem?                       RewardItemPrefab                        { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public GameObject?                              FooterArea                              { get; set; }
        public UITextMeshProUGUI?                       FooterText                              { get; set; }
        public PopupFrameParameter?                     PopupFrameParameter                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ReceiveRewardPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveRewardPopupView() { Pointer= p0 };

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 HeaderText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItemPos                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 RewardItemPos               ( ModelClassType Transform Transform Transform Pointer )
            value.RewardItemPrefab                          = GetObject<ReceiveRewardItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.ReceiveRewardItem.FromPointer); // 0x30 RewardItemPrefab            ( ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x38 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.FooterArea                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 FooterArea                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FooterText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 FooterText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PopupFrameParameter                       = GetObject<PopupFrameParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x58 PopupFrameParameter         ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
