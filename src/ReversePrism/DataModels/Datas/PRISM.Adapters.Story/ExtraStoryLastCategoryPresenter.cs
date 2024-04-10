using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186772B10 ModelClassType IExtraStoryLastCategoryView IExtraStoryLastCategoryView IExtraStoryLastCategoryView Pointer
    // 018 Argument                                 000186539390 ModelClassType ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument Pointer
    // 020 AdvTransitionerPresenter                 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Model                                    00018653AF60 ModelClassType ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel Pointer
    // 040 CellDataList                             000185CEFE98 ModelClassListType IReadOnlyList`1<ExtraStoryLastCategoryCellData> IReadOnlyList`1<ExtraStoryLastCategoryCellData> List<ExtraStoryLastCategoryCellData> Pointer
    public partial class ExtraStoryLastCategoryPresenter : DataModel
    {
        public IExtraStoryLastCategoryView?             View                                    { get; set; }
        public ExtraStoryLastCategoryArgument?          Argument                                { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ExtraStoryLastCategoryModel?             Model                                   { get; set; }
        public List<ExtraStoryLastCategoryCellData>?    CellDataList                            { get; set; }

        public static ExtraStoryLastCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IExtraStoryLastCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IExtraStoryLastCategoryView.FromPointer); // 0246667FAB20 0x10 View                        ( 000186772B10 ModelClassType IExtraStoryLastCategoryView IExtraStoryLastCategoryView IExtraStoryLastCategoryView Pointer )
            value.Argument                                  = GetObject<ExtraStoryLastCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExtraStoryLastCategoryArgument.FromPointer); // 0246667FAB40 0x18 Argument                    ( 000186539390 ModelClassType ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument ExtraStoryLastCategoryArgument Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0246667FAB60 0x20 AdvTransitionerPresenter    ( 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246667FAB80 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246667FABA0 0x30 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<ExtraStoryLastCategoryModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExtraStoryLastCategoryModel.FromPointer); // 0246667FABC0 0x38 Model                       ( 00018653AF60 ModelClassType ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel ExtraStoryLastCategoryModel Pointer )
            value.CellDataList                              = GetObjectList<ExtraStoryLastCategoryCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExtraStoryLastCategoryCellData.FromPointer); // 0246667FABE0 0x40 CellDataList                ( 000185CEFE98 ModelClassListType IReadOnlyList`1<ExtraStoryLastCategoryCellData> IReadOnlyList`1<ExtraStoryLastCategoryCellData> List<ExtraStoryLastCategoryCellData> Pointer )

            return value;
        }
    }
}
