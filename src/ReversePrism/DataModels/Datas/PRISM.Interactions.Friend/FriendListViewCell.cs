using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 PlayerName                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 LatestLoginDate                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Comment                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 StateObjects                             ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 IconView                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 068 AchievementPanelView                     ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 070 NewImageObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 078 ViewModel                                ModelClassType FriendListViewModel FriendListViewModel FriendListViewModel Pointer
    // 080 FriendStateDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class FriendListViewCell : DataModel
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
            var value   = new FriendListViewCell() { Pointer= p0 };

            value.PlayerName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 PlayerName                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LatestLoginDate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 LatestLoginDate             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Comment                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 Comment                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StateObjects                              = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 StateObjects                ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x60 IconView                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x068), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0x68 AchievementPanelView        ( ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.NewImageObject                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 NewImageObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<FriendListViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.FriendListViewModel.FromPointer); // 0x78 ViewModel                   ( ModelClassType FriendListViewModel FriendListViewModel FriendListViewModel Pointer )
            value.FriendStateDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDisposable.FromPointer); // 0x80 FriendStateDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
