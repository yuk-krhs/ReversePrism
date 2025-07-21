using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalHighScoreRateView                   ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 028 TotalTechnicalRateView                   ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 030 LiveClearCountView                       ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 038 FullComboCountView                       ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 040 AllGreatCountView                        ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 048 AllPerfectCountView                      ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 050 AllShinyCountView                        ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 058 FesUnitRankIconImage                     ModelClassType UIImage UIImage UIImage Pointer
    // 060 FesUnitRankingText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 FesUnitRankDetailButton                  ModelClassType UIButton UIButton UIButton Pointer
    // 070 EpisordClearCountText                    ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class ProfileProgressPanelView : DataModel
    {
        public MusicRateView?                           TotalHighScoreRateView                  { get; set; }
        public MusicRateView?                           TotalTechnicalRateView                  { get; set; }
        public ProfileLiveCountView?                    LiveClearCountView                      { get; set; }
        public ProfileLiveCountView?                    FullComboCountView                      { get; set; }
        public ProfileLiveCountView?                    AllGreatCountView                       { get; set; }
        public ProfileLiveCountView?                    AllPerfectCountView                     { get; set; }
        public ProfileLiveCountView?                    AllShinyCountView                       { get; set; }
        public UIImage?                                 FesUnitRankIconImage                    { get; set; }
        public UITextMeshProUGUI?                       FesUnitRankingText                      { get; set; }
        public UIButton?                                FesUnitRankDetailButton                 { get; set; }
        public List<UITextMeshProUGUI>?                 EpisordClearCountText                   { get; set; }

        public static ProfileProgressPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProgressPanelView() { Pointer= p0 };

            value.TotalHighScoreRateView                    = GetObject<MusicRateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateView.FromPointer); // 0x20 TotalHighScoreRateView      ( ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.TotalTechnicalRateView                    = GetObject<MusicRateView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateView.FromPointer); // 0x28 TotalTechnicalRateView      ( ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.LiveClearCountView                        = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x30 LiveClearCountView          ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.FullComboCountView                        = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x38 FullComboCountView          ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllGreatCountView                         = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x40 AllGreatCountView           ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllPerfectCountView                       = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x48 AllPerfectCountView         ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllShinyCountView                         = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x50 AllShinyCountView           ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.FesUnitRankIconImage                      = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 FesUnitRankIconImage        ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FesUnitRankingText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 FesUnitRankingText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FesUnitRankDetailButton                   = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 FesUnitRankDetailButton     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EpisordClearCountText                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 EpisordClearCountText       ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
