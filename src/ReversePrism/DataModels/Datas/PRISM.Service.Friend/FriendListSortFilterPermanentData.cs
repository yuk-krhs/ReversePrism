using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortFilterDatas                          000185CBABF8 ModelClassListType SortFilterData[] SortFilterData[] List<SortFilterData> Pointer
    public partial class FriendListSortFilterPermanentData
    {
        public List<SortFilterData>?                    SortFilterDatas                         { get; set; }

        public static FriendListSortFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendListSortFilterPermanentData();

            value.SortFilterDatas                           = GetObjectList<SortFilterData>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortFilterData.FromPointer); // 027003A6C1A0 0x10 SortFilterDatas             ( 000185CBABF8 ModelClassListType SortFilterData[] SortFilterData[] List<SortFilterData> Pointer )

            return value;
        }
    }
}
