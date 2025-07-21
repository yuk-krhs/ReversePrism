using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IEventStoryLastCategoryView IEventStoryLastCategoryView IEventStoryLastCategoryView Pointer
    // 018 Argument                                 ModelClassType EventStoryLastCategoryArgument EventStoryLastCategoryArgument EventStoryLastCategoryArgument Pointer
    // 020 AdvTransitionerPresenter                 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Model                                    ModelClassType EventStoryLastCategoryModel EventStoryLastCategoryModel EventStoryLastCategoryModel Pointer
    // 040 CellDataList                             ModelClassListType IReadOnlyList`1<IStoryLastCategoryCellData> IReadOnlyList`1<IStoryLastCategoryCellData> List<IStoryLastCategoryCellData> Pointer
    public partial class EventStoryLastCategoryPresenter : DataModel
    {
        public IEventStoryLastCategoryView?             View                                    { get; set; }
        public EventStoryLastCategoryArgument?          Argument                                { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public EventStoryLastCategoryModel?             Model                                   { get; set; }
        public List<IStoryLastCategoryCellData>?        CellDataList                            { get; set; }

        public static EventStoryLastCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IEventStoryLastCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEventStoryLastCategoryView.FromPointer); // 0x10 View                        ( ModelClassType IEventStoryLastCategoryView IEventStoryLastCategoryView IEventStoryLastCategoryView Pointer )
            value.Argument                                  = GetObject<EventStoryLastCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventStoryLastCategoryArgument.FromPointer); // 0x18 Argument                    ( ModelClassType EventStoryLastCategoryArgument EventStoryLastCategoryArgument EventStoryLastCategoryArgument Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0x20 AdvTransitionerPresenter    ( ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<EventStoryLastCategoryModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventStoryLastCategoryModel.FromPointer); // 0x38 Model                       ( ModelClassType EventStoryLastCategoryModel EventStoryLastCategoryModel EventStoryLastCategoryModel Pointer )
            value.CellDataList                              = GetObjectList<IStoryLastCategoryCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.IStoryLastCategoryCellData.FromPointer); // 0x40 CellDataList                ( ModelClassListType IReadOnlyList`1<IStoryLastCategoryCellData> IReadOnlyList`1<IStoryLastCategoryCellData> List<IStoryLastCategoryCellData> Pointer )

            return value;
        }
    }
}
