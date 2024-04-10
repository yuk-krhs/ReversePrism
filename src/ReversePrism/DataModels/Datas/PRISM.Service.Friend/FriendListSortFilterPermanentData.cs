using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortFilterDatas                          000185CBABF8 ModelClassListType SortFilterData[] SortFilterData[] List<SortFilterData> Pointer
    public partial class FriendListSortFilterPermanentData : DataModel
    {
        public List<SortFilterData>?                    SortFilterDatas                         { get; set; }

        public static FriendListSortFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendListSortFilterPermanentData() { Pointer= p0 };

            value.SortFilterDatas                           = GetObjectList<SortFilterData>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortFilterData.FromPointer); // 0245A3A770D8 0x10 SortFilterDatas             ( 000185CBABF8 ModelClassListType SortFilterData[] SortFilterData[] List<SortFilterData> Pointer )

            return value;
        }
    }
}
