using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SwitchMusicButton                        ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 MusicJacket                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 MusicBasicInfoView                       ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 038 UserRankingView                          ModelClassType UserRankingView UserRankingView UserRankingView Pointer
    // 040 MusicScoreRankingView                    ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer
    // 048 DifficultiesTabGroup                     ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 050 MusicSelectionGridPopup                  ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 058 ViewModel                                ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer
    // 060 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    public partial class MusicScoreRankingTabView : DataModel
    {
        public ButtonBase?                              SwitchMusicButton                       { get; set; }
        public UIRawImage?                              MusicJacket                             { get; set; }
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public UserRankingView?                         UserRankingView                         { get; set; }
        public MusicScoreRankingView?                   MusicScoreRankingView                   { get; set; }
        public UITabGroupEx?                            DifficultiesTabGroup                    { get; set; }
        public PopupContentBase?                        MusicSelectionGridPopup                 { get; set; }
        public MusicRankingOverlayViewModel?            ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static MusicScoreRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicScoreRankingTabView() { Pointer= p0 };

            value.SwitchMusicButton                         = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 SwitchMusicButton           ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.MusicJacket                               = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 MusicJacket                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x30 MusicBasicInfoView          ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.UserRankingView                           = GetObject<UserRankingView>(new IntPtr(p + 0x038), ReversePrism.DataModels.UserRankingView.FromPointer); // 0x38 UserRankingView             ( ModelClassType UserRankingView UserRankingView UserRankingView Pointer )
            value.MusicScoreRankingView                     = GetObject<MusicScoreRankingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicScoreRankingView.FromPointer); // 0x40 MusicScoreRankingView       ( ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer )
            value.DifficultiesTabGroup                      = GetObject<UITabGroupEx>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x48 DifficultiesTabGroup        ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.MusicSelectionGridPopup                   = GetObject<PopupContentBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x50 MusicSelectionGridPopup     ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ViewModel                                 = GetObject<MusicRankingOverlayViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicRankingOverlayViewModel.FromPointer); // 0x58 ViewModel                   ( ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x060)); // 0x60 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
