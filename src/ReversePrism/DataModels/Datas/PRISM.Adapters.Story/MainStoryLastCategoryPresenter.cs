using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865A6FB0 ModelClassType IMainStoryLastCategoryView IMainStoryLastCategoryView IMainStoryLastCategoryView Pointer
    // 018 Argument                                 0001865C9640 ModelClassType MainStoryLastCategoryArgument MainStoryLastCategoryArgument MainStoryLastCategoryArgument Pointer
    // 020 AdvTransitionerPresenter                 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Model                                    0001865CB0B0 ModelClassType MainStoryLastCategoryModel MainStoryLastCategoryModel MainStoryLastCategoryModel Pointer
    // 040 CellDataList                             000185D12F58 ModelClassListType IReadOnlyList`1<MainStoryLastCategoryCellData> IReadOnlyList`1<MainStoryLastCategoryCellData> List<MainStoryLastCategoryCellData> Pointer
    public partial class MainStoryLastCategoryPresenter
    {
        public IMainStoryLastCategoryView?              View                                    { get; set; }
        public MainStoryLastCategoryArgument?           Argument                                { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public MainStoryLastCategoryModel?              Model                                   { get; set; }
        public List<MainStoryLastCategoryCellData>?     CellDataList                            { get; set; }

        public static MainStoryLastCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryPresenter();

            value.View                                      = GetObject<IMainStoryLastCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMainStoryLastCategoryView.FromPointer); // 0270D67BCE90 0x10 View                        ( 0001865A6FB0 ModelClassType IMainStoryLastCategoryView IMainStoryLastCategoryView IMainStoryLastCategoryView Pointer )
            value.Argument                                  = GetObject<MainStoryLastCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.MainStoryLastCategoryArgument.FromPointer); // 0270D67BCEB0 0x18 Argument                    ( 0001865C9640 ModelClassType MainStoryLastCategoryArgument MainStoryLastCategoryArgument MainStoryLastCategoryArgument Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0270D67BCED0 0x20 AdvTransitionerPresenter    ( 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D67BCEF0 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D67BCF10 0x30 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<MainStoryLastCategoryModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.MainStoryLastCategoryModel.FromPointer); // 0270D67BCF30 0x38 Model                       ( 0001865CB0B0 ModelClassType MainStoryLastCategoryModel MainStoryLastCategoryModel MainStoryLastCategoryModel Pointer )
            value.CellDataList                              = GetObjectList<MainStoryLastCategoryCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.MainStoryLastCategoryCellData.FromPointer); // 0270D67BCF50 0x40 CellDataList                ( 000185D12F58 ModelClassListType IReadOnlyList`1<MainStoryLastCategoryCellData> IReadOnlyList`1<MainStoryLastCategoryCellData> List<MainStoryLastCategoryCellData> Pointer )

            return value;
        }
    }
}
