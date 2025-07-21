using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IMainStoryLastCategoryView IMainStoryLastCategoryView IMainStoryLastCategoryView Pointer
    // 018 Argument                                 ModelClassType MainStoryLastCategoryArgument MainStoryLastCategoryArgument MainStoryLastCategoryArgument Pointer
    // 020 AdvTransitionerPresenter                 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Model                                    ModelClassType MainStoryLastCategoryModel MainStoryLastCategoryModel MainStoryLastCategoryModel Pointer
    // 040 CellDataList                             ModelClassListType IReadOnlyList`1<IStoryLastCategoryCellData> IReadOnlyList`1<IStoryLastCategoryCellData> List<IStoryLastCategoryCellData> Pointer
    public partial class MainStoryLastCategoryPresenter : DataModel
    {
        public IMainStoryLastCategoryView?              View                                    { get; set; }
        public MainStoryLastCategoryArgument?           Argument                                { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public MainStoryLastCategoryModel?              Model                                   { get; set; }
        public List<IStoryLastCategoryCellData>?        CellDataList                            { get; set; }

        public static MainStoryLastCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IMainStoryLastCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMainStoryLastCategoryView.FromPointer); // 0x10 View                        ( ModelClassType IMainStoryLastCategoryView IMainStoryLastCategoryView IMainStoryLastCategoryView Pointer )
            value.Argument                                  = GetObject<MainStoryLastCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.MainStoryLastCategoryArgument.FromPointer); // 0x18 Argument                    ( ModelClassType MainStoryLastCategoryArgument MainStoryLastCategoryArgument MainStoryLastCategoryArgument Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0x20 AdvTransitionerPresenter    ( ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<MainStoryLastCategoryModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.MainStoryLastCategoryModel.FromPointer); // 0x38 Model                       ( ModelClassType MainStoryLastCategoryModel MainStoryLastCategoryModel MainStoryLastCategoryModel Pointer )
            value.CellDataList                              = GetObjectList<IStoryLastCategoryCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.IStoryLastCategoryCellData.FromPointer); // 0x40 CellDataList                ( ModelClassListType IReadOnlyList`1<IStoryLastCategoryCellData> IReadOnlyList`1<IStoryLastCategoryCellData> List<IStoryLastCategoryCellData> Pointer )

            return value;
        }
    }
}
