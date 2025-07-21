using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 OrdinaryCell                             ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer
    // 068 OrdinaryCellHeight                       ModelPrimitiveType float float float Single
    // 070 EveryStoryReadNotionCell                 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 078 EveryStoryReadNotionCellHeight           ModelPrimitiveType float float float Single
    // 080 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 088 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class StoryLastCategoryEnhancedCell : DataModel
    {
        public StoryLastCategoryCell?                   OrdinaryCell                            { get; set; }
        public float                                    OrdinaryCellHeight                      { get; set; }
        public EnhancedScrollerCellView?                EveryStoryReadNotionCell                { get; set; }
        public float                                    EveryStoryReadNotionCellHeight          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static StoryLastCategoryEnhancedCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryLastCategoryEnhancedCell() { Pointer= p0 };

            value.OrdinaryCell                              = GetObject<StoryLastCategoryCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.StoryLastCategoryCell.FromPointer); // 0x60 OrdinaryCell                ( ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer )
            value.OrdinaryCellHeight                        = GetSingle(new IntPtr(p + 0x068)); // 0x68 OrdinaryCellHeight          ( ModelPrimitiveType float float float Single )
            value.EveryStoryReadNotionCell                  = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x070), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x70 EveryStoryReadNotionCell    ( ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.EveryStoryReadNotionCellHeight            = GetSingle(new IntPtr(p + 0x078)); // 0x78 EveryStoryReadNotionCellHeight ( ModelPrimitiveType float float float Single )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x80 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x088), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x88 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
