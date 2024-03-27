using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SwitchMusicButton                        000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 MusicJacket                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 MusicBasicInfoView                       0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 038 UserRankingView                          000186750F20 ModelClassType UserRankingView UserRankingView UserRankingView Pointer
    // 040 MusicScoreRankingView                    000186674BB0 ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer
    // 048 DifficultiesTabGroup                     0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 050 AchievementDetailCaller                  000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer
    // 058 ProfilePopupCaller                       0001865BD220 ModelClassType ProfilePopupCaller ProfilePopupCaller ProfilePopupCaller Pointer
    // 060 MusicSelectionGridPopup                  000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 068 ViewModel                                00018666BB50 ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer
    // 070 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MusicScoreRankingTabView
    {
        public ButtonBase?                              SwitchMusicButton                       { get; set; }
        public UIRawImage?                              MusicJacket                             { get; set; }
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public UserRankingView?                         UserRankingView                         { get; set; }
        public MusicScoreRankingView?                   MusicScoreRankingView                   { get; set; }
        public UITabGroupEx?                            DifficultiesTabGroup                    { get; set; }
        public AchievementDetailPopupCaller?            AchievementDetailCaller                 { get; set; }
        public ProfilePopupCaller?                      ProfilePopupCaller                      { get; set; }
        public PopupContentBase?                        MusicSelectionGridPopup                 { get; set; }
        public MusicRankingOverlayViewModel?            ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static MusicScoreRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicScoreRankingTabView();

            value.SwitchMusicButton                         = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DB3CF8C8 0x20 SwitchMusicButton           ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.MusicJacket                               = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DB3CF8E8 0x28 MusicJacket                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0270DB3CF908 0x30 MusicBasicInfoView          ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.UserRankingView                           = GetObject<UserRankingView>(new IntPtr(p + 0x038), ReversePrism.DataModels.UserRankingView.FromPointer); // 0270DB3CF928 0x38 UserRankingView             ( 000186750F20 ModelClassType UserRankingView UserRankingView UserRankingView Pointer )
            value.MusicScoreRankingView                     = GetObject<MusicScoreRankingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicScoreRankingView.FromPointer); // 0270DB3CF948 0x40 MusicScoreRankingView       ( 000186674BB0 ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer )
            value.DifficultiesTabGroup                      = GetObject<UITabGroupEx>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270DB3CF968 0x48 DifficultiesTabGroup        ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.AchievementDetailCaller                   = GetObject<AchievementDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.AchievementDetailPopupCaller.FromPointer); // 0270DB3CF988 0x50 AchievementDetailCaller     ( 000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer )
            value.ProfilePopupCaller                        = GetObject<ProfilePopupCaller>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfilePopupCaller.FromPointer); // 0270DB3CF9A8 0x58 ProfilePopupCaller          ( 0001865BD220 ModelClassType ProfilePopupCaller ProfilePopupCaller ProfilePopupCaller Pointer )
            value.MusicSelectionGridPopup                   = GetObject<PopupContentBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DB3CF9C8 0x60 MusicSelectionGridPopup     ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ViewModel                                 = GetObject<MusicRankingOverlayViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicRankingOverlayViewModel.FromPointer); // 0270DB3CF9E8 0x68 ViewModel                   ( 00018666BB50 ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x070)); // 0270DB3CFA08 0x70 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
