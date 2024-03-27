using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 PlayerName                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 LatestLoginDate                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Comment                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 StateObjects                             000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 IconView                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 068 AchievementPanelView                     000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 070 NewImageObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ViewModel                                0001865C78D0 ModelClassType FriendListViewModel FriendListViewModel FriendListViewModel Pointer
    // 080 FriendStateDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class FriendListViewCell
    {
        public UITextMeshProUGUI?                       PlayerName                              { get; set; }
        public UITextMeshProUGUI?                       LatestLoginDate                         { get; set; }
        public UITextMeshProUGUI?                       Comment                                 { get; set; }
        public List<GameObject>?                        StateObjects                            { get; set; }
        public PFIdolIconView?                          IconView                                { get; set; }
        public AchievementPanelView?                    AchievementPanelView                    { get; set; }
        public GameObject?                              NewImageObject                          { get; set; }
        public FriendListViewModel?                     ViewModel                               { get; set; }
        public IDisposable?                             FriendStateDisposable                   { get; set; }

        public static FriendListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendListViewCell();

            value.PlayerName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE6640 0x40 PlayerName                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LatestLoginDate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE6660 0x48 LatestLoginDate             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Comment                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE6680 0x50 Comment                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StateObjects                              = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBDE66A0 0x58 StateObjects                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DBDE66C0 0x60 IconView                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x068), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0270DBDE66E0 0x68 AchievementPanelView        ( 000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.NewImageObject                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBDE6700 0x70 NewImageObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<FriendListViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.FriendListViewModel.FromPointer); // 0270DBDE6720 0x78 ViewModel                   ( 0001865C78D0 ModelClassType FriendListViewModel FriendListViewModel FriendListViewModel Pointer )
            value.FriendStateDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DBDE6740 0x80 FriendStateDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
