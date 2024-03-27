using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Cell                                     000186598130 ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer
    // 028 StoryTypeLabel                           0001865B0F90 ModelClassType StoryTypeLabel StoryTypeLabel StoryTypeLabel Pointer
    // 030 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class SortFilteredStoryCell
    {
        public StoryLastCategoryCell?                   Cell                                    { get; set; }
        public StoryTypeLabel?                          StoryTypeLabel                          { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static SortFilteredStoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilteredStoryCell();

            value.Cell                                      = GetObject<StoryLastCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryLastCategoryCell.FromPointer); // 0270DB977040 0x20 Cell                        ( 000186598130 ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer )
            value.StoryTypeLabel                            = GetObject<StoryTypeLabel>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTypeLabel.FromPointer); // 0270DB977060 0x28 StoryTypeLabel              ( 0001865B0F90 ModelClassType StoryTypeLabel StoryTypeLabel StoryTypeLabel Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DB977080 0x30 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
