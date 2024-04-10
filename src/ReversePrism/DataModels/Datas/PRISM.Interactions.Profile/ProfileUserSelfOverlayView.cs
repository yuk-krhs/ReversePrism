using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FesUnitRankCountResourceTagName          string IL2CPP_TYPE_STRING
    // 000 HistoryResourceTagName                   string IL2CPP_TYPE_STRING
    // 020 TabListView                              0001865AAA80 ModelClassType ProfileCategoryTabListView ProfileCategoryTabListView ProfileCategoryTabListView Pointer
    // 028 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 PanelViewObjects                         000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 UserSelfPanelView                        0001865C7440 ModelClassType ProfileUserSelfPanelView ProfileUserSelfPanelView ProfileUserSelfPanelView Pointer
    // 040 ProgressPanelView                        0001865BF5D0 ModelClassType ProfileProgressPanelView ProfileProgressPanelView ProfileProgressPanelView Pointer
    // 048 HistoryPanelView                         0001865BA420 ModelClassType ProfileHistoryPanelView ProfileHistoryPanelView ProfileHistoryPanelView Pointer
    // 050 pIdoleDetailPopupFactory                 PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 058 pIdoleSelectPopupFactory                 PopupViewFactory`1<IProfilePIdolSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 060 editPlayerNamePopupFactory               PopupViewFactory`1<IProfileEditPlayerNamePopupView> IL2CPP_TYPE_GENERICINST
    // 068 editPlayerNameConfirmPopupFactory        PopupViewFactory`1<IProfileEditPlayerNameConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 070 achievementSelectPopupFactory            PopupViewFactory`1<IProfileAchievementSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 078 achievementDetailPopupFactory            PopupViewFactory`1<IAchievementDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 080 editBirthdayPopupFactory                 PopupViewFactory`1<IProfileEditBirthdayPopupView> IL2CPP_TYPE_GENERICINST
    // 088 editCommentPopupFactory                  PopupViewFactory`1<IProfileEditUserCommentPopupView> IL2CPP_TYPE_GENERICINST
    // 090 supportCharaSelectPopupFactory           PopupViewFactory`1<IProfileSupportCharaSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 098 supportCharaDetailPopupViewFactory       PopupViewFactory`1<ISCharaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0A0 fesUnitRankDetailPopupFactory            PopupViewFactory`1<IProfileProgressFesUnitRankDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0A8 produceCardSummaryPopupFactoy            PopupViewFactory`1<IProfileProduceCardSummaryPopupView> IL2CPP_TYPE_GENERICINST
    // 0B0 eventArchiveInfoPopupFactoy              PopupViewFactory`1<IProfileEventArchiveInfoPopupView> IL2CPP_TYPE_GENERICINST
    // 0B8 fesUnitRankCountPopupFactory             PopupViewFactory`1<IProfileFesUnitRankCountPopupView> IL2CPP_TYPE_GENERICINST
    // 0C0 ViewModel                                0001865C5E90 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 0C8 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0D0 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ProfileUserSelfOverlayView : DataModel
    {
        public ProfileCategoryTabListView?              TabListView                             { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public List<GameObject>?                        PanelViewObjects                        { get; set; }
        public ProfileUserSelfPanelView?                UserSelfPanelView                       { get; set; }
        public ProfileProgressPanelView?                ProgressPanelView                       { get; set; }
        public ProfileHistoryPanelView?                 HistoryPanelView                        { get; set; }
        public ProfileUserSalfViewModel?                ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ProfileUserSelfOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileUserSelfOverlayView() { Pointer= p0 };

            value.TabListView                               = GetObject<ProfileCategoryTabListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileCategoryTabListView.FromPointer); // 02466B77B908 0x20 TabListView                 ( 0001865AAA80 ModelClassType ProfileCategoryTabListView ProfileCategoryTabListView ProfileCategoryTabListView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B77B928 0x28 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PanelViewObjects                          = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B77B948 0x30 PanelViewObjects            ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UserSelfPanelView                         = GetObject<ProfileUserSelfPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileUserSelfPanelView.FromPointer); // 02466B77B968 0x38 UserSelfPanelView           ( 0001865C7440 ModelClassType ProfileUserSelfPanelView ProfileUserSelfPanelView ProfileUserSelfPanelView Pointer )
            value.ProgressPanelView                         = GetObject<ProfileProgressPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileProgressPanelView.FromPointer); // 02466B77B988 0x40 ProgressPanelView           ( 0001865BF5D0 ModelClassType ProfileProgressPanelView ProfileProgressPanelView ProfileProgressPanelView Pointer )
            value.HistoryPanelView                          = GetObject<ProfileHistoryPanelView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfileHistoryPanelView.FromPointer); // 02466B77B9A8 0x48 HistoryPanelView            ( 0001865BA420 ModelClassType ProfileHistoryPanelView ProfileHistoryPanelView ProfileHistoryPanelView Pointer )
            value.ViewModel                                 = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 02466B77BB88 0xC0 ViewModel                   ( 0001865C5E90 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B77BBA8 0xC8 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466B77BBC8 0xD0 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
