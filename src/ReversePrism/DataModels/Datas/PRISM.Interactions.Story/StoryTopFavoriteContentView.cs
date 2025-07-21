using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellList                                 ModelClassType SortFilteredStoryCellListView SortFilteredStoryCellListView SortFilteredStoryCellListView Pointer
    // 028 SortFilterButton                         ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortToggleButton                         ModelClassType UISwitch UISwitch UISwitch Pointer
    public partial class StoryTopFavoriteContentView : DataModel
    {
        public SortFilteredStoryCellListView?           CellList                                { get; set; }
        public FilterAndSortView?                       SortFilterButton                        { get; set; }
        public UISwitch?                                SortToggleButton                        { get; set; }

        public static StoryTopFavoriteContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopFavoriteContentView() { Pointer= p0 };

            value.CellList                                  = GetObject<SortFilteredStoryCellListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortFilteredStoryCellListView.FromPointer); // 0x20 CellList                    ( ModelClassType SortFilteredStoryCellListView SortFilteredStoryCellListView SortFilteredStoryCellListView Pointer )
            value.SortFilterButton                          = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x28 SortFilterButton            ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortToggleButton                          = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0x30 SortToggleButton            ( ModelClassType UISwitch UISwitch UISwitch Pointer )

            return value;
        }
    }
}
