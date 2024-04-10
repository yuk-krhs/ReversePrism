using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 540 M_Columns                                0001865D7890 ModelClassType Columns Columns Columns Pointer
    // 548 M_SortingEnabled                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 550 M_SortColumnDescriptions                 00018652DE70 ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer
    // 558 M_SortedColumns                          000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer
    // 560 ColumnSortingChanged                     0001866792B0 ModelClassType Action Action Action Pointer
    // 568 headerContextMenuPopulateEvent           Action`2<ContextualMenuPopulateEvent, Column> IL2CPP_TYPE_GENERICINST
    public partial class MultiColumnListView : DataModel
    {
        public Columns?                                 M_Columns                               { get; set; }
        public bool                                     M_SortingEnabled                        { get; set; }
        public SortColumnDescriptions?                  M_SortColumnDescriptions                { get; set; }
        public List<SortColumnDescription>?             M_SortedColumns                         { get; set; }
        public Action?                                  ColumnSortingChanged                    { get; set; }

        public static MultiColumnListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnListView() { Pointer= p0 };

            value.M_Columns                                 = GetObject<Columns>(new IntPtr(p + 0x540), ReversePrism.DataModels.Columns.FromPointer); // 0245A66EBE38 0x540 M_Columns                   ( 0001865D7890 ModelClassType Columns Columns Columns Pointer )
            value.M_SortingEnabled                          = GetBool(new IntPtr(p + 0x548)); // 0245A66EBE58 0x548 M_SortingEnabled            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SortColumnDescriptions                  = GetObject<SortColumnDescriptions>(new IntPtr(p + 0x550), ReversePrism.DataModels.SortColumnDescriptions.FromPointer); // 0245A66EBE78 0x550 M_SortColumnDescriptions    ( 00018652DE70 ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer )
            value.M_SortedColumns                           = GetObjectList<SortColumnDescription>(new IntPtr(p + 0x558), ReversePrism.DataModels.SortColumnDescription.FromPointer); // 0245A66EBE98 0x558 M_SortedColumns             ( 000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer )
            value.ColumnSortingChanged                      = GetObject<Action>(new IntPtr(p + 0x560), ReversePrism.DataModels.Action.FromPointer); // 0245A66EBEB8 0x560 ColumnSortingChanged        ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
