using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_HasPersistedData                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_SortDescriptions                       000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer
    // 020 M_OrderedColumnStates                    000185D327E8 ModelEnumListType List`1<ColumnState> List`1<ColumnState> List<ColumnState> Pointer
    public partial class ViewState
    {
        public bool                                     M_HasPersistedData                      { get; set; }
        public List<SortColumnDescription>?             M_SortDescriptions                      { get; set; }
        public List<ColumnState>?                       M_OrderedColumnStates                   { get; set; }

        public static ViewState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewState();

            value.M_HasPersistedData                        = GetBool(new IntPtr(p + 0x010)); // 02700689EF90 0x10 M_HasPersistedData          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SortDescriptions                        = GetObjectList<SortColumnDescription>(new IntPtr(p + 0x018), ReversePrism.DataModels.SortColumnDescription.FromPointer); // 02700689EFB0 0x18 M_SortDescriptions          ( 000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer )
            value.M_OrderedColumnStates                     = GetEnumList<ColumnState>(new IntPtr(p + 0x020)); // 02700689EFD0 0x20 M_OrderedColumnStates       ( 000185D327E8 ModelEnumListType List`1<ColumnState> List`1<ColumnState> List<ColumnState> Pointer )

            return value;
        }
    }
}
