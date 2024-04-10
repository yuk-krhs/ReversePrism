using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018665E8D0 ModelClassType IStoryTopEventContentView IStoryTopEventContentView IStoryTopEventContentView Pointer
    // 018 CellDataList                             000185CEF428 ModelClassListType IReadOnlyList`1<EventStoryFirstCategoryCellData> IReadOnlyList`1<EventStoryFirstCategoryCellData> List<EventStoryFirstCategoryCellData> Pointer
    // 020 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StoryTopEventContentPresenter : DataModel
    {
        public IStoryTopEventContentView?               View                                    { get; set; }
        public List<EventStoryFirstCategoryCellData>?   CellDataList                            { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static StoryTopEventContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopEventContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopEventContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopEventContentView.FromPointer); // 0246668434D8 0x10 View                        ( 00018665E8D0 ModelClassType IStoryTopEventContentView IStoryTopEventContentView IStoryTopEventContentView Pointer )
            value.CellDataList                              = GetObjectList<EventStoryFirstCategoryCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventStoryFirstCategoryCellData.FromPointer); // 0246668434F8 0x18 CellDataList                ( 000185CEF428 ModelClassListType IReadOnlyList`1<EventStoryFirstCategoryCellData> IReadOnlyList`1<EventStoryFirstCategoryCellData> List<EventStoryFirstCategoryCellData> Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 024666843518 0x20 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
