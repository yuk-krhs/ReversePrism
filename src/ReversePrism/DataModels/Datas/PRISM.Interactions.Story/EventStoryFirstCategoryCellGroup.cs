using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Cells                                    ModelClassListType EventStoryFirstCategoryCell[] EventStoryFirstCategoryCell[] List<EventStoryFirstCategoryCell> Pointer
    // 068 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 070 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class EventStoryFirstCategoryCellGroup : DataModel
    {
        public List<EventStoryFirstCategoryCell>?       Cells                                   { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static EventStoryFirstCategoryCellGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryFirstCategoryCellGroup() { Pointer= p0 };

            value.Cells                                     = GetObjectList<EventStoryFirstCategoryCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.EventStoryFirstCategoryCell.FromPointer); // 0x60 Cells                       ( ModelClassListType EventStoryFirstCategoryCell[] EventStoryFirstCategoryCell[] List<EventStoryFirstCategoryCell> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x68 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
