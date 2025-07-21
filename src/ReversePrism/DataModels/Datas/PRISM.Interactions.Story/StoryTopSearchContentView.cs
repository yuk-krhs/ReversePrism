using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellList                                 ModelClassType SortFilteredStoryCellListView SortFilteredStoryCellListView SortFilteredStoryCellListView Pointer
    // 028 StorySearchButton                        ModelClassType StorySearchButton StorySearchButton StorySearchButton Pointer
    public partial class StoryTopSearchContentView : DataModel
    {
        public SortFilteredStoryCellListView?           CellList                                { get; set; }
        public StorySearchButton?                       StorySearchButton                       { get; set; }

        public static StoryTopSearchContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopSearchContentView() { Pointer= p0 };

            value.CellList                                  = GetObject<SortFilteredStoryCellListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortFilteredStoryCellListView.FromPointer); // 0x20 CellList                    ( ModelClassType SortFilteredStoryCellListView SortFilteredStoryCellListView SortFilteredStoryCellListView Pointer )
            value.StorySearchButton                         = GetObject<StorySearchButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.StorySearchButton.FromPointer); // 0x28 StorySearchButton           ( ModelClassType StorySearchButton StorySearchButton StorySearchButton Pointer )

            return value;
        }
    }
}
