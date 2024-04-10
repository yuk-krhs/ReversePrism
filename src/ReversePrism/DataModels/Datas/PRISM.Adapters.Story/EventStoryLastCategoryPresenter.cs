using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001867679E0 ModelClassType IEventStoryLastCategoryView IEventStoryLastCategoryView IEventStoryLastCategoryView Pointer
    // 018 Argument                                 000186768DF0 ModelClassType EventStoryLastCategoryArgument EventStoryLastCategoryArgument EventStoryLastCategoryArgument Pointer
    // 020 AdvTransitionerPresenter                 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Model                                    00018676AA70 ModelClassType EventStoryLastCategoryModel EventStoryLastCategoryModel EventStoryLastCategoryModel Pointer
    // 040 CellDataList                             000185CEF698 ModelClassListType IReadOnlyList`1<EventStoryLastCategoryCellData> IReadOnlyList`1<EventStoryLastCategoryCellData> List<EventStoryLastCategoryCellData> Pointer
    public partial class EventStoryLastCategoryPresenter : DataModel
    {
        public IEventStoryLastCategoryView?             View                                    { get; set; }
        public EventStoryLastCategoryArgument?          Argument                                { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public EventStoryLastCategoryModel?             Model                                   { get; set; }
        public List<EventStoryLastCategoryCellData>?    CellDataList                            { get; set; }

        public static EventStoryLastCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IEventStoryLastCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEventStoryLastCategoryView.FromPointer); // 0246667F7148 0x10 View                        ( 0001867679E0 ModelClassType IEventStoryLastCategoryView IEventStoryLastCategoryView IEventStoryLastCategoryView Pointer )
            value.Argument                                  = GetObject<EventStoryLastCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventStoryLastCategoryArgument.FromPointer); // 0246667F7168 0x18 Argument                    ( 000186768DF0 ModelClassType EventStoryLastCategoryArgument EventStoryLastCategoryArgument EventStoryLastCategoryArgument Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0246667F7188 0x20 AdvTransitionerPresenter    ( 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246667F71A8 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246667F71C8 0x30 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<EventStoryLastCategoryModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventStoryLastCategoryModel.FromPointer); // 0246667F71E8 0x38 Model                       ( 00018676AA70 ModelClassType EventStoryLastCategoryModel EventStoryLastCategoryModel EventStoryLastCategoryModel Pointer )
            value.CellDataList                              = GetObjectList<EventStoryLastCategoryCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventStoryLastCategoryCellData.FromPointer); // 0246667F7208 0x40 CellDataList                ( 000185CEF698 ModelClassListType IReadOnlyList`1<EventStoryLastCategoryCellData> IReadOnlyList`1<EventStoryLastCategoryCellData> List<EventStoryLastCategoryCellData> Pointer )

            return value;
        }
    }
}
