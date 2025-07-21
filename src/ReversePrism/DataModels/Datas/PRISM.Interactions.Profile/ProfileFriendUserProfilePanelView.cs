using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProducerNameText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 FriendStateObjects                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 AchievementPanelView                     ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 038 BirthdayText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CommentText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SupportIdolIcon                          ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 050 FollowButtonObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 058 FollowButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 060 ReleaseFollowButtonObject                ModelClassType GameObject GameObject GameObject Pointer
    // 068 ReleaseFollowButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 070 ReleaseFollowerButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 078 FriendStateDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProfileFriendUserProfilePanelView : DataModel
    {
        public UITextMeshProUGUI?                       ProducerNameText                        { get; set; }
        public List<GameObject>?                        FriendStateObjects                      { get; set; }
        public AchievementPanelView?                    AchievementPanelView                    { get; set; }
        public UITextMeshProUGUI?                       BirthdayText                            { get; set; }
        public UITextMeshProUGUI?                       CommentText                             { get; set; }
        public SCharaIconView?                          SupportIdolIcon                         { get; set; }
        public GameObject?                              FollowButtonObject                      { get; set; }
        public UIButton?                                FollowButton                            { get; set; }
        public GameObject?                              ReleaseFollowButtonObject               { get; set; }
        public UIButton?                                ReleaseFollowButton                     { get; set; }
        public UIButton?                                ReleaseFollowerButton                   { get; set; }
        public IDisposable?                             FriendStateDisposable                   { get; set; }

        public static ProfileFriendUserProfilePanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserProfilePanelView() { Pointer= p0 };

            value.ProducerNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 ProducerNameText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FriendStateObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 FriendStateObjects          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0x30 AchievementPanelView        ( ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.BirthdayText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 BirthdayText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 CommentText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportIdolIcon                           = GetObject<SCharaIconView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x48 SupportIdolIcon             ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FollowButtonObject                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 FollowButtonObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FollowButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 FollowButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ReleaseFollowButtonObject                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 ReleaseFollowButtonObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReleaseFollowButton                       = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 ReleaseFollowButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ReleaseFollowerButton                     = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ReleaseFollowerButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FriendStateDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0x78 FriendStateDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
