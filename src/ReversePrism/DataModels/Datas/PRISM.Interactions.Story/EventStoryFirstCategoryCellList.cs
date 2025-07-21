using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 CellCount                                ModelPrimitiveType int int int Int32
    // 060 EmptyViewText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CellDataList                             ModelClassListType IReadOnlyList`1<EventStoryFirstCategoryCellData> IReadOnlyList`1<EventStoryFirstCategoryCellData> List<EventStoryFirstCategoryCellData> Pointer
    public partial class EventStoryFirstCategoryCellList : DataModel
    {
        public int                                      CellCount                               { get; set; }
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }
        public List<EventStoryFirstCategoryCellData>?   CellDataList                            { get; set; }

        public static EventStoryFirstCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryFirstCategoryCellList() { Pointer= p0 };

            value.CellCount                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 CellCount                   ( ModelPrimitiveType int int int Int32 )
            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 EmptyViewText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellDataList                              = GetObjectList<EventStoryFirstCategoryCellData>(new IntPtr(p + 0x068), ReversePrism.DataModels.EventStoryFirstCategoryCellData.FromPointer); // 0x68 CellDataList                ( ModelClassListType IReadOnlyList`1<EventStoryFirstCategoryCellData> IReadOnlyList`1<EventStoryFirstCategoryCellData> List<EventStoryFirstCategoryCellData> Pointer )

            return value;
        }
    }
}
