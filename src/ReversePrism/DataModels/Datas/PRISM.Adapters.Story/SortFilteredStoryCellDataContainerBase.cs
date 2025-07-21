using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StorySortFilterModel                     ModelClassType StorySortFilterModel StorySortFilterModel StorySortFilterModel Pointer
    // 018 AllCellDataList                          ModelClassListType SortFilteredStoryCellData[] SortFilteredStoryCellData[] List<SortFilteredStoryCellData> Pointer
    public partial class SortFilteredStoryCellDataContainerBase : DataModel
    {
        public StorySortFilterModel?                    StorySortFilterModel                    { get; set; }
        public List<SortFilteredStoryCellData>?         AllCellDataList                         { get; set; }

        public static SortFilteredStoryCellDataContainerBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilteredStoryCellDataContainerBase() { Pointer= p0 };

            value.StorySortFilterModel                      = GetObject<StorySortFilterModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StorySortFilterModel.FromPointer); // 0x10 StorySortFilterModel        ( ModelClassType StorySortFilterModel StorySortFilterModel StorySortFilterModel Pointer )
            value.AllCellDataList                           = GetObjectList<SortFilteredStoryCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.SortFilteredStoryCellData.FromPointer); // 0x18 AllCellDataList             ( ModelClassListType SortFilteredStoryCellData[] SortFilteredStoryCellData[] List<SortFilteredStoryCellData> Pointer )

            return value;
        }
    }
}
