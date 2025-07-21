using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Cell                                     ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer
    // 068 StoryTypeLabel                           ModelClassType StoryTypeLabel StoryTypeLabel StoryTypeLabel Pointer
    // 070 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 078 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class SortFilteredStoryCell : DataModel
    {
        public StoryLastCategoryCell?                   Cell                                    { get; set; }
        public StoryTypeLabel?                          StoryTypeLabel                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static SortFilteredStoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilteredStoryCell() { Pointer= p0 };

            value.Cell                                      = GetObject<StoryLastCategoryCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.StoryLastCategoryCell.FromPointer); // 0x60 Cell                        ( ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer )
            value.StoryTypeLabel                            = GetObject<StoryTypeLabel>(new IntPtr(p + 0x068), ReversePrism.DataModels.StoryTypeLabel.FromPointer); // 0x68 StoryTypeLabel              ( ModelClassType StoryTypeLabel StoryTypeLabel StoryTypeLabel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x70 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x78 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
