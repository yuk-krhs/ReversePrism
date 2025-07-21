using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabViews                                 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 ScoreRankingTab                          ModelClassType MusicScoreRankingTabView MusicScoreRankingTabView MusicScoreRankingTabView Pointer
    // 030 SeasonRankingTab                         ModelClassType SeasonRankingTabView SeasonRankingTabView SeasonRankingTabView Pointer
    // 038 CategoryView                             ModelClassType MusicRankingCategoryView MusicRankingCategoryView MusicRankingCategoryView Pointer
    // 040 PeriodView                               ModelClassType MusicRankingPeriodView MusicRankingPeriodView MusicRankingPeriodView Pointer
    // 048 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 050 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 058 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 060 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 068 SelectedIndex                            ModelPrimitiveType int int int Int32
    // 070 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 078 ViewModel                                ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer
    // 080 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 088 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
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
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static MusicRankingOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingOverlayView() { Pointer= p0 };

            value.TabViews                                  = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 TabViews                    ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ScoreRankingTab                           = GetObject<MusicScoreRankingTabView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicScoreRankingTabView.FromPointer); // 0x28 ScoreRankingTab             ( ModelClassType MusicScoreRankingTabView MusicScoreRankingTabView MusicScoreRankingTabView Pointer )
            value.SeasonRankingTab                          = GetObject<SeasonRankingTabView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SeasonRankingTabView.FromPointer); // 0x30 SeasonRankingTab            ( ModelClassType SeasonRankingTabView SeasonRankingTabView SeasonRankingTabView Pointer )
            value.CategoryView                              = GetObject<MusicRankingCategoryView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicRankingCategoryView.FromPointer); // 0x38 CategoryView                ( ModelClassType MusicRankingCategoryView MusicRankingCategoryView MusicRankingCategoryView Pointer )
            value.PeriodView                                = GetObject<MusicRankingPeriodView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicRankingPeriodView.FromPointer); // 0x40 PeriodView                  ( ModelClassType MusicRankingPeriodView MusicRankingPeriodView MusicRankingPeriodView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x048), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x48 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x050), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x50 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 0x60 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x068)); // 0x68 SelectedIndex               ( ModelPrimitiveType int int int Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 0x70 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ViewModel                                 = GetObject<MusicRankingOverlayViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicRankingOverlayViewModel.FromPointer); // 0x78 ViewModel                   ( ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x80 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
