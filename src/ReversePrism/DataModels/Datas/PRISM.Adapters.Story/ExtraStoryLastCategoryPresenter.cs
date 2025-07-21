using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IExtraStoryLastCategoryView IExtraStoryLastCategoryView IExtraStoryLastCategoryView Pointer
    // 018 Argument                                 ModelClassType ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument Pointer
    // 020 AdvTransitionerPresenter                 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Model                                    ModelClassType ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel Pointer
    // 040 CellDataList                             ModelClassListType IReadOnlyList`1<IStoryLastCategoryCellData> IReadOnlyList`1<IStoryLastCategoryCellData> List<IStoryLastCategoryCellData> Pointer
    public partial class ExtraStoryLastCategoryPresenter : DataModel
    {
        public IExtraStoryLastCategoryView?             View                                    { get; set; }
        public ExtraStoryLastCategoryArgument?          Argument                                { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ExtraStoryLastCategoryModel?             Model                                   { get; set; }
        public List<IStoryLastCategoryCellData>?        CellDataList                            { get; set; }

        public static ExtraStoryLastCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IExtraStoryLastCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IExtraStoryLastCategoryView.FromPointer); // 0x10 View                        ( ModelClassType IExtraStoryLastCategoryView IExtraStoryLastCategoryView IExtraStoryLastCategoryView Pointer )
            value.Argument                                  = GetObject<ExtraStoryLastCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExtraStoryLastCategoryArgument.FromPointer); // 0x18 Argument                    ( ModelClassType ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0x20 AdvTransitionerPresenter    ( ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<ExtraStoryLastCategoryModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExtraStoryLastCategoryModel.FromPointer); // 0x38 Model                       ( ModelClassType ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel Pointer )
            value.CellDataList                              = GetObjectList<IStoryLastCategoryCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.IStoryLastCategoryCellData.FromPointer); // 0x40 CellDataList                ( ModelClassListType IReadOnlyList`1<IStoryLastCategoryCellData> IReadOnlyList`1<IStoryLastCategoryCellData> List<IStoryLastCategoryCellData> Pointer )

            return value;
        }
    }
}
