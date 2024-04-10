using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018665FEF0 ModelClassType IStoryTopMainContentView IStoryTopMainContentView IStoryTopMainContentView Pointer
    // 018 CellDataList                             000185D12D18 ModelClassListType IReadOnlyList`1<MainStoryFirstCategoryCellData> IReadOnlyList`1<MainStoryFirstCategoryCellData> List<MainStoryFirstCategoryCellData> Pointer
    // 020 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StoryTopMainContentPresenter : DataModel
    {
        public IStoryTopMainContentView?                View                                    { get; set; }
        public List<MainStoryFirstCategoryCellData>?    CellDataList                            { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static StoryTopMainContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopMainContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopMainContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopMainContentView.FromPointer); // 02466685D8B0 0x10 View                        ( 00018665FEF0 ModelClassType IStoryTopMainContentView IStoryTopMainContentView IStoryTopMainContentView Pointer )
            value.CellDataList                              = GetObjectList<MainStoryFirstCategoryCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.MainStoryFirstCategoryCellData.FromPointer); // 02466685D8D0 0x18 CellDataList                ( 000185D12D18 ModelClassListType IReadOnlyList`1<MainStoryFirstCategoryCellData> IReadOnlyList`1<MainStoryFirstCategoryCellData> List<MainStoryFirstCategoryCellData> Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 02466685D8F0 0x20 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
