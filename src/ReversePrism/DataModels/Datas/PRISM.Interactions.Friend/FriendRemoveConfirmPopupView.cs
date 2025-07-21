using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TopMessageText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 PlayerName                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 LatestLoginDate                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 IconView                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 AchievementPanelView                     ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 048 StateObjects                             ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onAchievement                            Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 060 ViewModel                                ModelClassType FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel Pointer
    // 068 removeTaskFactory                        Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 070 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FriendRemoveConfirmPopupView : DataModel
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
            var value   = new FriendRemoveConfirmPopupView() { Pointer= p0 };

            value.TopMessageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x20 TopMessageText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.PlayerName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 PlayerName                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LatestLoginDate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 LatestLoginDate             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x38 IconView                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0x40 AchievementPanelView        ( ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.StateObjects                              = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 StateObjects                ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModel                                 = GetObject<FriendRemoveConfirmPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.FriendRemoveConfirmPopupViewModel.FromPointer); // 0x60 ViewModel                   ( ModelClassType FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel FriendRemoveConfirmPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x70 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
