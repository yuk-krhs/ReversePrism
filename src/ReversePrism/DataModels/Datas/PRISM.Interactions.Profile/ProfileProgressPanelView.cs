using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalHighScoreRateView                   0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 028 TotalTechnicalRateView                   0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 030 LiveClearCountText                       000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 FullComboCountText                       000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 040 AllGreatCountText                        000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 048 AllPerfectCountText                      000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 050 FesUnitRankIconImage                     0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 058 FesUnitRankingText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 FesUnitRankDetailButton                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 EpisordClearCountText                    000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class ProfileProgressPanelView : DataModel
    {
        public MusicRateView?                           TotalHighScoreRateView                  { get; set; }
        public MusicRateView?                           TotalTechnicalRateView                  { get; set; }
        public List<UITextMeshProUGUI>?                 LiveClearCountText                      { get; set; }
        public List<UITextMeshProUGUI>?                 FullComboCountText                      { get; set; }
        public List<UITextMeshProUGUI>?                 AllGreatCountText                       { get; set; }
        public List<UITextMeshProUGUI>?                 AllPerfectCountText                     { get; set; }
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

            value.TotalHighScoreRateView                    = GetObject<MusicRateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateView.FromPointer); // 02466B77F010 0x20 TotalHighScoreRateView      ( 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.TotalTechnicalRateView                    = GetObject<MusicRateView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateView.FromPointer); // 02466B77F030 0x28 TotalTechnicalRateView      ( 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.LiveClearCountText                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77F050 0x30 LiveClearCountText          ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FullComboCountText                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77F070 0x38 FullComboCountText          ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AllGreatCountText                         = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77F090 0x40 AllGreatCountText           ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AllPerfectCountText                       = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77F0B0 0x48 AllPerfectCountText         ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FesUnitRankIconImage                      = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 02466B77F0D0 0x50 FesUnitRankIconImage        ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FesUnitRankingText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77F0F0 0x58 FesUnitRankingText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FesUnitRankDetailButton                   = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466B77F110 0x60 FesUnitRankDetailButton     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EpisordClearCountText                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77F130 0x68 EpisordClearCountText       ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
