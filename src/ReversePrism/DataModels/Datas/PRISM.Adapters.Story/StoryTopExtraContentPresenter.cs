using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018665ED90 ModelClassType IStoryTopExtraContentView IStoryTopExtraContentView IStoryTopExtraContentView Pointer
    // 018 CellDataList                             000185CEFC48 ModelClassListType IReadOnlyList`1<ExtraStoryFirstCategoryCellData> IReadOnlyList`1<ExtraStoryFirstCategoryCellData> List<ExtraStoryFirstCategoryCellData> Pointer
    // 020 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StoryTopExtraContentPresenter
    {
        public IStoryTopExtraContentView?               View                                    { get; set; }
        public List<ExtraStoryFirstCategoryCellData>?   CellDataList                            { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static StoryTopExtraContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopExtraContentPresenter();

            value.View                                      = GetObject<IStoryTopExtraContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopExtraContentView.FromPointer); // 0270D67E50F0 0x10 View                        ( 00018665ED90 ModelClassType IStoryTopExtraContentView IStoryTopExtraContentView IStoryTopExtraContentView Pointer )
            value.CellDataList                              = GetObjectList<ExtraStoryFirstCategoryCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExtraStoryFirstCategoryCellData.FromPointer); // 0270D67E5110 0x18 CellDataList                ( 000185CEFC48 ModelClassListType IReadOnlyList`1<ExtraStoryFirstCategoryCellData> IReadOnlyList`1<ExtraStoryFirstCategoryCellData> List<ExtraStoryFirstCategoryCellData> Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D67E5130 0x20 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
