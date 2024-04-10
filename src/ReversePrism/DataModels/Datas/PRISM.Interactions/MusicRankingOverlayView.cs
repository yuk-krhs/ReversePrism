using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabViews                                 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 ScoreRankingTab                          000186674460 ModelClassType MusicScoreRankingTabView MusicScoreRankingTabView MusicScoreRankingTabView Pointer
    // 030 SeasonRankingTab                         00018670BAD0 ModelClassType SeasonRankingTabView SeasonRankingTabView SeasonRankingTabView Pointer
    // 038 CategoryView                             0001866698C0 ModelClassType MusicRankingCategoryView MusicRankingCategoryView MusicRankingCategoryView Pointer
    // 040 PeriodView                               00018666C2C0 ModelClassType MusicRankingPeriodView MusicRankingPeriodView MusicRankingPeriodView Pointer
    // 048 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 050 HowToPlayPopupOpener                     0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 058 BackButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 068 SelectedIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 078 ViewModel                                00018666BB50 ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer
    // 080 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class MusicRankingOverlayView : DataModel
    {
        public List<GameObject>?                        TabViews                                { get; set; }
        public MusicScoreRankingTabView?                ScoreRankingTab                         { get; set; }
        public SeasonRankingTabView?                    SeasonRankingTab                        { get; set; }
        public MusicRankingCategoryView?                CategoryView                            { get; set; }
        public MusicRankingPeriodView?                  PeriodView                              { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public int                                      SelectedIndex                           { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public MusicRankingOverlayViewModel?            ViewModel                               { get; set; }

        public static MusicRankingOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingOverlayView() { Pointer= p0 };

            value.TabViews                                  = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466B4642C8 0x20 TabViews                    ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ScoreRankingTab                           = GetObject<MusicScoreRankingTabView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicScoreRankingTabView.FromPointer); // 02466B4642E8 0x28 ScoreRankingTab             ( 000186674460 ModelClassType MusicScoreRankingTabView MusicScoreRankingTabView MusicScoreRankingTabView Pointer )
            value.SeasonRankingTab                          = GetObject<SeasonRankingTabView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SeasonRankingTabView.FromPointer); // 02466B464308 0x30 SeasonRankingTab            ( 00018670BAD0 ModelClassType SeasonRankingTabView SeasonRankingTabView SeasonRankingTabView Pointer )
            value.CategoryView                              = GetObject<MusicRankingCategoryView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicRankingCategoryView.FromPointer); // 02466B464328 0x38 CategoryView                ( 0001866698C0 ModelClassType MusicRankingCategoryView MusicRankingCategoryView MusicRankingCategoryView Pointer )
            value.PeriodView                                = GetObject<MusicRankingPeriodView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicRankingPeriodView.FromPointer); // 02466B464348 0x40 PeriodView                  ( 00018666C2C0 ModelClassType MusicRankingPeriodView MusicRankingPeriodView MusicRankingPeriodView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x048), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B464368 0x48 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x050), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 02466B464388 0x50 HowToPlayPopupOpener        ( 0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466B4643A8 0x58 BackButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 02466B4643C8 0x60 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x068)); // 02466B4643E8 0x68 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B464408 0x70 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ViewModel                                 = GetObject<MusicRankingOverlayViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicRankingOverlayViewModel.FromPointer); // 02466B464428 0x78 ViewModel                   ( 00018666BB50 ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer )

            return value;
        }
    }
}
