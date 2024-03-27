using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TopMessageText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 PlayerName                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 LatestLoginDate                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 IconView                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 AchievementPanelView                     000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 048 StateObjects                             000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 achievementDetailPopupViewFactory        PopupViewFactory`1<IAchievementDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 058 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onAchievement                            Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 068 ViewModel                                0001865C9D30 ModelClassType FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel Pointer
    // 070 removeTaskFactory                        Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 078 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FriendRemoveConfirmPopupView
    {
        public TextMeshProUGUI?                         TopMessageText                          { get; set; }
        public UITextMeshProUGUI?                       PlayerName                              { get; set; }
        public UITextMeshProUGUI?                       LatestLoginDate                         { get; set; }
        public PFIdolIconView?                          IconView                                { get; set; }
        public AchievementPanelView?                    AchievementPanelView                    { get; set; }
        public List<GameObject>?                        StateObjects                            { get; set; }
        public FriendRemoveConfirmPopupViewModel?       ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FriendRemoveConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendRemoveConfirmPopupView();

            value.TopMessageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DBDF3300 0x20 TopMessageText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.PlayerName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDF3320 0x28 PlayerName                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LatestLoginDate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDF3340 0x30 LatestLoginDate             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DBDF3360 0x38 IconView                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0270DBDF3380 0x40 AchievementPanelView        ( 000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.StateObjects                              = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBDF33A0 0x48 StateObjects                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModel                                 = GetObject<FriendRemoveConfirmPopupViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.FriendRemoveConfirmPopupViewModel.FromPointer); // 0270DBDF3420 0x68 ViewModel                   ( 0001865C9D30 ModelClassType FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBDF3460 0x78 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
