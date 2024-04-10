using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018665F9D0 ModelClassType IStoryTopIdolContentView IStoryTopIdolContentView IStoryTopIdolContentView Pointer
    // 018 CellDataList                             000185D10478 ModelClassListType IReadOnlyList`1<IdolStoryFirstCategoryCellData> IReadOnlyList`1<IdolStoryFirstCategoryCellData> List<IdolStoryFirstCategoryCellData> Pointer
    // 020 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StoryTopIdolContentPresenter : DataModel
    {
        public IStoryTopIdolContentView?                View                                    { get; set; }
        public List<IdolStoryFirstCategoryCellData>?    CellDataList                            { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static StoryTopIdolContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopIdolContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopIdolContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopIdolContentView.FromPointer); // 02466685A488 0x10 View                        ( 00018665F9D0 ModelClassType IStoryTopIdolContentView IStoryTopIdolContentView IStoryTopIdolContentView Pointer )
            value.CellDataList                              = GetObjectList<IdolStoryFirstCategoryCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolStoryFirstCategoryCellData.FromPointer); // 02466685A4A8 0x18 CellDataList                ( 000185D10478 ModelClassListType IReadOnlyList`1<IdolStoryFirstCategoryCellData> IReadOnlyList`1<IdolStoryFirstCategoryCellData> List<IdolStoryFirstCategoryCellData> Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 02466685A4C8 0x20 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
