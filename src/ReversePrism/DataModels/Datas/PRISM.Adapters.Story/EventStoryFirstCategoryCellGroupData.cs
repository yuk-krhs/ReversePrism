using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellDataList                             ModelClassListType IReadOnlyList`1<EventStoryFirstCategoryCellData> IReadOnlyList`1<EventStoryFirstCategoryCellData> List<EventStoryFirstCategoryCellData> Pointer
    public partial class EventStoryFirstCategoryCellGroupData : DataModel
    {
        public List<EventStoryFirstCategoryCellData>?   CellDataList                            { get; set; }

        public static EventStoryFirstCategoryCellGroupData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryFirstCategoryCellGroupData() { Pointer= p0 };

            value.CellDataList                              = GetObjectList<EventStoryFirstCategoryCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventStoryFirstCategoryCellData.FromPointer); // 0x10 CellDataList                ( ModelClassListType IReadOnlyList`1<EventStoryFirstCategoryCellData> IReadOnlyList`1<EventStoryFirstCategoryCellData> List<EventStoryFirstCategoryCellData> Pointer )

            return value;
        }
    }
}
