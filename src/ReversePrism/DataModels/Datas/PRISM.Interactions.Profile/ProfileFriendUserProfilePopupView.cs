using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  ModelClassType RawImage RawImage RawImage Pointer
    // 028 PIdolParent                              ModelClassType Transform Transform Transform Pointer
    // 030 PIdolDetailButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 038 ProfilePanelView                         ModelClassType ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView Pointer
    // 040 ProgressListView                         ModelClassType ProfileFriendUserProgressListView ProfileFriendUserProgressListView ProfileFriendUserProgressListView Pointer
    // 048 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 050 TabObjects                               ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 060 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 onPIdolDetail                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onSCharaDetail                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 onAchievementDetail                      Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 ViewModel                                ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer
    // 088 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 090 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileFriendUserProfilePopupView : DataModel
    {
        public RawImage?                                BgImage                                 { get; set; }
        public Transform?                               PIdolParent                             { get; set; }
        public UIButton?                                PIdolDetailButton                       { get; set; }
        public ProfileFriendUserProfilePanelView?       ProfilePanelView                        { get; set; }
        public ProfileFriendUserProgressListView?       ProgressListView                        { get; set; }
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public List<GameObject>?                        TabObjects                              { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ProfileFriendUserViewModel?              ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileFriendUserProfilePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserProfilePopupView() { Pointer= p0 };

            value.BgImage                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 BgImage                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.PIdolParent                               = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 PIdolParent                 ( ModelClassType Transform Transform Transform Pointer )
            value.PIdolDetailButton                         = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 PIdolDetailButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProfilePanelView                          = GetObject<ProfileFriendUserProfilePanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileFriendUserProfilePanelView.FromPointer); // 0x38 ProfilePanelView            ( ModelClassType ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView Pointer )
            value.ProgressListView                          = GetObject<ProfileFriendUserProgressListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileFriendUserProgressListView.FromPointer); // 0x40 ProgressListView            ( ModelClassType ProfileFriendUserProgressListView ProfileFriendUserProgressListView ProfileFriendUserProgressListView Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x48 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabObjects                                = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 TabObjects                  ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x58 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ViewModel                                 = GetObject<ProfileFriendUserViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProfileFriendUserViewModel.FromPointer); // 0x80 ViewModel                   ( ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x088), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x88 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x90 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
