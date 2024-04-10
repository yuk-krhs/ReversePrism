using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 4C0 M_Columns                                0001865D7890 ModelClassType Columns Columns Columns Pointer
    // 4C8 M_SortingEnabled                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 4D0 M_SortColumnDescriptions                 00018652DE70 ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer
    // 4D8 M_SortedColumns                          000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer
    // 4E0 ColumnSortingChanged                     0001866792B0 ModelClassType Action Action Action Pointer
    // 4E8 headerContextMenuPopulateEvent           Action`2<ContextualMenuPopulateEvent, Column> IL2CPP_TYPE_GENERICINST
    public partial class MultiColumnTreeView : DataModel
    {
        public Columns?                                 M_Columns                               { get; set; }
        public bool                                     M_SortingEnabled                        { get; set; }
        public SortColumnDescriptions?                  M_SortColumnDescriptions                { get; set; }
        public List<SortColumnDescription>?             M_SortedColumns                         { get; set; }
        public Action?                                  ColumnSortingChanged                    { get; set; }

        public static MultiColumnTreeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnTreeView() { Pointer= p0 };

            value.M_Columns                                 = GetObject<Columns>(new IntPtr(p + 0x4C0), ReversePrism.DataModels.Columns.FromPointer); // 0245A66ECC88 0x4C0 M_Columns                   ( 0001865D7890 ModelClassType Columns Columns Columns Pointer )
            value.M_SortingEnabled                          = GetBool(new IntPtr(p + 0x4C8)); // 0245A66ECCA8 0x4C8 M_SortingEnabled            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SortColumnDescriptions                  = GetObject<SortColumnDescriptions>(new IntPtr(p + 0x4D0), ReversePrism.DataModels.SortColumnDescriptions.FromPointer); // 0245A66ECCC8 0x4D0 M_SortColumnDescriptions    ( 00018652DE70 ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer )
            value.M_SortedColumns                           = GetObjectList<SortColumnDescription>(new IntPtr(p + 0x4D8), ReversePrism.DataModels.SortColumnDescription.FromPointer); // 0245A66ECCE8 0x4D8 M_SortedColumns             ( 000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer )
            value.ColumnSortingChanged                      = GetObject<Action>(new IntPtr(p + 0x4E0), ReversePrism.DataModels.Action.FromPointer); // 0245A66ECD08 0x4E0 ColumnSortingChanged        ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
