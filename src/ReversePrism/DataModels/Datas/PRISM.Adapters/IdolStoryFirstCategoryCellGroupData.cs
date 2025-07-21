using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 014 IsAnyUnread                              ModelPrimitiveType bool bool bool Bool
    // 018 CellDataList                             ModelClassListType IReadOnlyList`1<IdolStoryFirstCategoryCellData> IReadOnlyList`1<IdolStoryFirstCategoryCellData> List<IdolStoryFirstCategoryCellData> Pointer
    // 020 IsUnreadFilterEnabled                    ModelPrimitiveType bool bool bool Bool
    public partial class IdolStoryFirstCategoryCellGroupData : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public bool                                     IsAnyUnread                             { get; set; }
        public List<IdolStoryFirstCategoryCellData>?    CellDataList                            { get; set; }
        public bool                                     IsUnreadFilterEnabled                   { get; set; }

        public static IdolStoryFirstCategoryCellGroupData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryFirstCategoryCellGroupData() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.IsAnyUnread                               = GetBool(new IntPtr(p + 0x014)); // 0x14 IsAnyUnread                 ( ModelPrimitiveType bool bool bool Bool )
            value.CellDataList                              = GetObjectList<IdolStoryFirstCategoryCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolStoryFirstCategoryCellData.FromPointer); // 0x18 CellDataList                ( ModelClassListType IReadOnlyList`1<IdolStoryFirstCategoryCellData> IReadOnlyList`1<IdolStoryFirstCategoryCellData> List<IdolStoryFirstCategoryCellData> Pointer )
            value.IsUnreadFilterEnabled                     = GetBool(new IntPtr(p + 0x020)); // 0x20 IsUnreadFilterEnabled       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
