using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 PIdolParent                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 PIdolDetailButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 ProfilePanelView                         0001865B6E50 ModelClassType ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView Pointer
    // 040 ProgressListView                         0001865B9550 ModelClassType ProfileFriendUserProgressListView ProfileFriendUserProgressListView ProfileFriendUserProgressListView Pointer
    // 048 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 050 TabObjects                               000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 fesUnitRankPopupViewFactory              PopupViewFactory`1<IProfileFriendUserFesUnitRankPopupView> IL2CPP_TYPE_GENERICINST
    // 060 achievementDetailPopupViewFactory        PopupViewFactory`1<IAchievementDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 068 pIdolDetailPopupViewFactory              PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 070 sCharaDetailPopupViewFactory             PopupViewFactory`1<ISCharaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 078 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 080 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 088 friendRemoveConfirmPopupViewFactory      PopupViewFactory`1<IFriendRemoveConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 090 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 098 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onPIdolDetail                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A8 onSCharaDetail                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 onAchievementDetail                      Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0B8 ViewModel                                0001865B9A40 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer
    // 0C0 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 0C8 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileFriendUserProfilePopupView : DataModel
    {
        public RawImage?                                BgImage                                 { get; set; }
        public Transform?                               PIdolParent                             { get; set; }
        public UIButton?                                PIdolDetailButton                       { get; set; }
        public ProfileFriendUserProfilePanelView?       ProfilePanelView                        { get; set; }
        public ProfileFriendUserProgressListView?       ProgressListView                        { get; set; }
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public List<GameObject>?                        TabObjects                              { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
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

            value.BgImage                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 02466B7C3860 0x20 BgImage                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.PIdolParent                               = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B7C3880 0x28 PIdolParent                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.PIdolDetailButton                         = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 02466B7C38A0 0x30 PIdolDetailButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ProfilePanelView                          = GetObject<ProfileFriendUserProfilePanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileFriendUserProfilePanelView.FromPointer); // 02466B7C38C0 0x38 ProfilePanelView            ( 0001865B6E50 ModelClassType ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView ProfileFriendUserProfilePanelView Pointer )
            value.ProgressListView                          = GetObject<ProfileFriendUserProgressListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileFriendUserProgressListView.FromPointer); // 02466B7C38E0 0x40 ProgressListView            ( 0001865B9550 ModelClassType ProfileFriendUserProgressListView ProfileFriendUserProgressListView ProfileFriendUserProgressListView Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466B7C3900 0x48 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabObjects                                = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466B7C3920 0x50 TabObjects                  ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x078), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 02466B7C39C0 0x78 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x080), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 02466B7C39E0 0x80 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466B7C3A20 0x90 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ViewModel                                 = GetObject<ProfileFriendUserViewModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ProfileFriendUserViewModel.FromPointer); // 02466B7C3AC0 0xB8 ViewModel                   ( 0001865B9A40 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466B7C3AE0 0xC0 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B7C3B00 0xC8 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
