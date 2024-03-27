using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186578D60 ModelClassType IIdolStoryLastCategoryView IIdolStoryLastCategoryView IIdolStoryLastCategoryView Pointer
    // 018 Argument                                 0001866C66A0 ModelClassType IdolStoryLastCategoryArgument IdolStoryLastCategoryArgument IdolStoryLastCategoryArgument Pointer
    // 020 AdvTransitionerPresenter                 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Model                                    0001866C81C0 ModelClassType IdolStoryLastCategoryModel IdolStoryLastCategoryModel IdolStoryLastCategoryModel Pointer
    // 040 CellDataList                             000185D106B8 ModelClassListType IReadOnlyList`1<IdolStoryLastCategoryCellData> IReadOnlyList`1<IdolStoryLastCategoryCellData> List<IdolStoryLastCategoryCellData> Pointer
    public partial class IdolStoryLastCategoryPresenter
    {
        public IIdolStoryLastCategoryView?              View                                    { get; set; }
        public IdolStoryLastCategoryArgument?           Argument                                { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IdolStoryLastCategoryModel?              Model                                   { get; set; }
        public List<IdolStoryLastCategoryCellData>?     CellDataList                            { get; set; }

        public static IdolStoryLastCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryLastCategoryPresenter();

            value.View                                      = GetObject<IIdolStoryLastCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIdolStoryLastCategoryView.FromPointer); // 0270D67B8E80 0x10 View                        ( 000186578D60 ModelClassType IIdolStoryLastCategoryView IIdolStoryLastCategoryView IIdolStoryLastCategoryView Pointer )
            value.Argument                                  = GetObject<IdolStoryLastCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolStoryLastCategoryArgument.FromPointer); // 0270D67B8EA0 0x18 Argument                    ( 0001866C66A0 ModelClassType IdolStoryLastCategoryArgument IdolStoryLastCategoryArgument IdolStoryLastCategoryArgument Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0270D67B8EC0 0x20 AdvTransitionerPresenter    ( 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D67B8EE0 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D67B8F00 0x30 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<IdolStoryLastCategoryModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolStoryLastCategoryModel.FromPointer); // 0270D67B8F20 0x38 Model                       ( 0001866C81C0 ModelClassType IdolStoryLastCategoryModel IdolStoryLastCategoryModel IdolStoryLastCategoryModel Pointer )
            value.CellDataList                              = GetObjectList<IdolStoryLastCategoryCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolStoryLastCategoryCellData.FromPointer); // 0270D67B8F40 0x40 CellDataList                ( 000185D106B8 ModelClassListType IReadOnlyList`1<IdolStoryLastCategoryCellData> IReadOnlyList`1<IdolStoryLastCategoryCellData> List<IdolStoryLastCategoryCellData> Pointer )

            return value;
        }
    }
}
