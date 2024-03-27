using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProducerNameText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 FriendStateObjects                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 AchievementPanelView                     000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 038 BirthdayText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CommentText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SupportIdolIcon                          0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 050 FollowButtonObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 FollowButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 ReleaseFollowButtonObject                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 ReleaseFollowButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 ReleaseFollowerButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 FriendStateDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProfileFriendUserProfilePanelView
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
            var value   = new ProfileFriendUserProfilePanelView();

            value.ProducerNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB736C88 0x20 ProducerNameText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FriendStateObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB736CA8 0x28 FriendStateObjects          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0270DB736CC8 0x30 AchievementPanelView        ( 000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.BirthdayText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB736CE8 0x38 BirthdayText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB736D08 0x40 CommentText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportIdolIcon                           = GetObject<SCharaIconView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DB736D28 0x48 SupportIdolIcon             ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FollowButtonObject                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB736D48 0x50 FollowButtonObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FollowButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB736D68 0x58 FollowButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ReleaseFollowButtonObject                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB736D88 0x60 ReleaseFollowButtonObject   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ReleaseFollowButton                       = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB736DA8 0x68 ReleaseFollowButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ReleaseFollowerButton                     = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB736DC8 0x70 ReleaseFollowerButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FriendStateDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB736DE8 0x78 FriendStateDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
