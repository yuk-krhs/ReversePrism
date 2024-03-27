using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RewardItemPos                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 RewardItemPrefab                         000186625810 ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer
    // 038 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 040 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 048 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 050 AchievementDetailCaller                  000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer
    // 058 FooterArea                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 FooterText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 PopupFrameParameter                      000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 078 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ReceiveRewardPopupView
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public Transform?                               RewardItemPos                           { get; set; }
        public ReceiveRewardItem?                       RewardItemPrefab                        { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public AchievementDetailPopupCaller?            AchievementDetailCaller                 { get; set; }
        public GameObject?                              FooterArea                              { get; set; }
        public UITextMeshProUGUI?                       FooterText                              { get; set; }
        public PopupFrameParameter?                     PopupFrameParameter                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ReceiveRewardPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveRewardPopupView();

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB5990F8 0x20 HeaderText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItemPos                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB599118 0x28 RewardItemPos               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.RewardItemPrefab                          = GetObject<ReceiveRewardItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.ReceiveRewardItem.FromPointer); // 0270DB599138 0x30 RewardItemPrefab            ( 000186625810 ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270DB599158 0x38 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DB599178 0x40 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270DB599198 0x48 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.AchievementDetailCaller                   = GetObject<AchievementDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.AchievementDetailPopupCaller.FromPointer); // 0270DB5991B8 0x50 AchievementDetailCaller     ( 000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer )
            value.FooterArea                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB5991D8 0x58 FooterArea                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FooterText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB5991F8 0x60 FooterText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PopupFrameParameter                       = GetObject<PopupFrameParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0270DB599238 0x70 PopupFrameParameter         ( 000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB599258 0x78 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
