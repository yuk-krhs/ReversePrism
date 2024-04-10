using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 CellDataList                             000185D16918 ModelClassListType IReadOnlyList`1<StorySortFilterCharacterFilterCellData> IReadOnlyList`1<StorySortFilterCharacterFilterCellData> List<StorySortFilterCharacterFilterCellData> Pointer
    public partial class StorySortFilterCharacterFilterCellContainerData : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public List<StorySortFilterCharacterFilterCellData>? CellDataList                            { get; set; }

        public static StorySortFilterCharacterFilterCellContainerData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterCharacterFilterCellContainerData() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 02466681E768 0x10 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CellDataList                              = GetObjectList<StorySortFilterCharacterFilterCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.StorySortFilterCharacterFilterCellData.FromPointer); // 02466681E788 0x18 CellDataList                ( 000185D16918 ModelClassListType IReadOnlyList`1<StorySortFilterCharacterFilterCellData> IReadOnlyList`1<StorySortFilterCharacterFilterCellData> List<StorySortFilterCharacterFilterCellData> Pointer )

            return value;
        }
    }
}
