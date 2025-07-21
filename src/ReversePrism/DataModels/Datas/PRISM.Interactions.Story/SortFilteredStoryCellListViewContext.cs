using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 <OnClickCell>k__BackingField             Subject`1<SortFilteredStoryCellData> IL2CPP_TYPE_GENERICINST
    // 048 <OnClickFavoriteToggle>k__BackingField   Subject`1<SortFilteredStoryCellData> IL2CPP_TYPE_GENERICINST
    public partial class SortFilteredStoryCellListViewContext : DataModel
    {

        public static SortFilteredStoryCellListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilteredStoryCellListViewContext() { Pointer= p0 };


            return value;
        }
    }
}
