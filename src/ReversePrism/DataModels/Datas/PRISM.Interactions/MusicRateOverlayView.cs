using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RateTabGroup                             ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 HighScoreRateView                        ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer
    // 030 TechnicalRateView                        ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer
    // 038 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 040 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 048 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 050 InitialDisplayType                       ModelEnumType MusicRateType MusicRateType MusicRateType Int32
    // 058 onClose                                  Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    // 060 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 HighScoreRateData                        ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer
    // 070 TechnicalRateData                        ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer
    public partial class MusicRateOverlayView : DataModel
    {
        public UITabGroupEx?                            RateTabGroup                            { get; set; }
        public MusicRateDetailView?                     HighScoreRateView                       { get; set; }
        public MusicRateDetailView?                     TechnicalRateView                       { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public MusicRateType                            InitialDisplayType                      { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public MusicRateDetailViewModel?                HighScoreRateData                       { get; set; }
        public MusicRateDetailViewModel?                TechnicalRateData                       { get; set; }

        public static MusicRateOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateOverlayView() { Pointer= p0 };

            value.RateTabGroup                              = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x20 RateTabGroup                ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.HighScoreRateView                         = GetObject<MusicRateDetailView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateDetailView.FromPointer); // 0x28 HighScoreRateView           ( ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer )
            value.TechnicalRateView                         = GetObject<MusicRateDetailView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicRateDetailView.FromPointer); // 0x30 TechnicalRateView           ( ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x38 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x040), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x40 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.InitialDisplayType                        = (MusicRateType)GetInt32(new IntPtr(p + 0x050)); // 0x50 InitialDisplayType          ( ModelEnumType MusicRateType MusicRateType MusicRateType Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.HighScoreRateData                         = GetObject<MusicRateDetailViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicRateDetailViewModel.FromPointer); // 0x68 HighScoreRateData           ( ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer )
            value.TechnicalRateData                         = GetObject<MusicRateDetailViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.MusicRateDetailViewModel.FromPointer); // 0x70 TechnicalRateData           ( ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer )

            return value;
        }
    }
}
