using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RateTabGroup                             0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 HighScoreRateView                        00018666C7B0 ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer
    // 030 TechnicalRateView                        00018666C7B0 ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer
    // 038 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 040 HowToPlayPopupOpener                     0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 048 BackButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 InitialDisplayType                       000186670C10 ModelEnumType MusicRateType MusicRateType MusicRateType Int32
    // 058 onClose                                  Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    // 060 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 HighScoreRateData                        00018666CF40 ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer
    // 070 TechnicalRateData                        00018666CF40 ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer
    public partial class MusicRateOverlayView
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
            var value   = new MusicRateOverlayView();

            value.RateTabGroup                              = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270DB3F65A0 0x20 RateTabGroup                ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.HighScoreRateView                         = GetObject<MusicRateDetailView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateDetailView.FromPointer); // 0270DB3F65C0 0x28 HighScoreRateView           ( 00018666C7B0 ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer )
            value.TechnicalRateView                         = GetObject<MusicRateDetailView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicRateDetailView.FromPointer); // 0270DB3F65E0 0x30 TechnicalRateView           ( 00018666C7B0 ModelClassType MusicRateDetailView MusicRateDetailView MusicRateDetailView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB3F6600 0x38 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x040), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0270DB3F6620 0x40 HowToPlayPopupOpener        ( 0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB3F6640 0x48 BackButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.InitialDisplayType                        = (MusicRateType)GetInt32(new IntPtr(p + 0x050)); // 0270DB3F6660 0x50 InitialDisplayType          ( 000186670C10 ModelEnumType MusicRateType MusicRateType MusicRateType Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB3F66A0 0x60 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.HighScoreRateData                         = GetObject<MusicRateDetailViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicRateDetailViewModel.FromPointer); // 0270DB3F66C0 0x68 HighScoreRateData           ( 00018666CF40 ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer )
            value.TechnicalRateData                         = GetObject<MusicRateDetailViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.MusicRateDetailViewModel.FromPointer); // 0270DB3F66E0 0x70 TechnicalRateData           ( 00018666CF40 ModelClassType MusicRateDetailViewModel MusicRateDetailViewModel MusicRateDetailViewModel Pointer )

            return value;
        }
    }
}
