using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellList                                 0001865A9930 ModelClassType StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList Pointer
    // 028 SortFilterButton                         000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortToggleButton                         0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 sortFilterPopupFactory                   PopupViewFactory`1<IStorySortFilterPopupView> IL2CPP_TYPE_GENERICINST
    public partial class StoryTopFavoriteContentView
    {
        public StoryTopFavoriteContentCellList?         CellList                                { get; set; }
        public FilterAndSortView?                       SortFilterButton                        { get; set; }
        public UISwitch?                                SortToggleButton                        { get; set; }

        public static StoryTopFavoriteContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopFavoriteContentView();

            value.CellList                                  = GetObject<StoryTopFavoriteContentCellList>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopFavoriteContentCellList.FromPointer); // 0270DB995D38 0x20 CellList                    ( 0001865A9930 ModelClassType StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList Pointer )
            value.SortFilterButton                          = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270DB995D58 0x28 SortFilterButton            ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortToggleButton                          = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0270DB995D78 0x30 SortToggleButton            ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )

            return value;
        }
    }
}
