using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 AllCellDataList                          ModelClassListType IReadOnlyList`1<ExtraStorySecondCategoryCellData> IReadOnlyList`1<ExtraStorySecondCategoryCellData> List<ExtraStorySecondCategoryCellData> Pointer
    // 060 UnreadCellExists                         ModelPrimitiveType bool bool bool Bool
    public partial class ExtraStorySecondCategoryCellList : DataModel
    {
        public List<ExtraStorySecondCategoryCellData>?  AllCellDataList                         { get; set; }
        public bool                                     UnreadCellExists                        { get; set; }

        public static ExtraStorySecondCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryCellList() { Pointer= p0 };

            value.AllCellDataList                           = GetObjectList<ExtraStorySecondCategoryCellData>(new IntPtr(p + 0x058), ReversePrism.DataModels.ExtraStorySecondCategoryCellData.FromPointer); // 0x58 AllCellDataList             ( ModelClassListType IReadOnlyList`1<ExtraStorySecondCategoryCellData> IReadOnlyList`1<ExtraStorySecondCategoryCellData> List<ExtraStorySecondCategoryCellData> Pointer )
            value.UnreadCellExists                          = GetBool(new IntPtr(p + 0x060)); // 0x60 UnreadCellExists            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
