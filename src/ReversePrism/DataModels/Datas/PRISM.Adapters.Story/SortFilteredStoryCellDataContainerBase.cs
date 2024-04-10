using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StorySortFilterModel                     00018659FA80 ModelClassType StorySortFilterModel StorySortFilterModel StorySortFilterModel Pointer
    // 018 AllCellDataList                          000185CA4298 ModelClassListType SortFilteredStoryCellData[] SortFilteredStoryCellData[] List<SortFilteredStoryCellData> Pointer
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

            value.StorySortFilterModel                      = GetObject<StorySortFilterModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StorySortFilterModel.FromPointer); // 024666846010 0x10 StorySortFilterModel        ( 00018659FA80 ModelClassType StorySortFilterModel StorySortFilterModel StorySortFilterModel Pointer )
            value.AllCellDataList                           = GetObjectList<SortFilteredStoryCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.SortFilteredStoryCellData.FromPointer); // 024666846030 0x18 AllCellDataList             ( 000185CA4298 ModelClassListType SortFilteredStoryCellData[] SortFilteredStoryCellData[] List<SortFilteredStoryCellData> Pointer )

            return value;
        }
    }
}
