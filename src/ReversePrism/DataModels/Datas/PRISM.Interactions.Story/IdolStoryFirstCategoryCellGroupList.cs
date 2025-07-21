using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 CellGroupDataList                        ModelClassListType IReadOnlyList`1<IdolStoryFirstCategoryCellGroupData> IReadOnlyList`1<IdolStoryFirstCategoryCellGroupData> List<IdolStoryFirstCategoryCellGroupData> Pointer
    public partial class IdolStoryFirstCategoryCellGroupList : DataModel
    {
        public List<IdolStoryFirstCategoryCellGroupData>? CellGroupDataList                       { get; set; }

        public static IdolStoryFirstCategoryCellGroupList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryFirstCategoryCellGroupList() { Pointer= p0 };

            value.CellGroupDataList                         = GetObjectList<IdolStoryFirstCategoryCellGroupData>(new IntPtr(p + 0x058), ReversePrism.DataModels.IdolStoryFirstCategoryCellGroupData.FromPointer); // 0x58 CellGroupDataList           ( ModelClassListType IReadOnlyList`1<IdolStoryFirstCategoryCellGroupData> IReadOnlyList`1<IdolStoryFirstCategoryCellGroupData> List<IdolStoryFirstCategoryCellGroupData> Pointer )

            return value;
        }
    }
}
