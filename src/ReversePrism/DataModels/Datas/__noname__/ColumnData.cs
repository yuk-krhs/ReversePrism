using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Control                                  00018665E750 ModelClassType MultiColumnHeaderColumn MultiColumnHeaderColumn MultiColumnHeaderColumn Pointer
    // 018 ResizeHandle                             00018665F5E0 ModelClassType MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle Pointer
    public partial class ColumnData
    {
        public MultiColumnHeaderColumn?                 Control                                 { get; set; }
        public MultiColumnHeaderColumnResizeHandle?     ResizeHandle                            { get; set; }

        public static ColumnData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnData();

            value.Control                                   = GetObject<MultiColumnHeaderColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.MultiColumnHeaderColumn.FromPointer); // 0270068A09B8 0x10 Control                     ( 00018665E750 ModelClassType MultiColumnHeaderColumn MultiColumnHeaderColumn MultiColumnHeaderColumn Pointer )
            value.ResizeHandle                              = GetObject<MultiColumnHeaderColumnResizeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.MultiColumnHeaderColumnResizeHandle.FromPointer); // 0270068A09D8 0x18 ResizeHandle                ( 00018665F5E0 ModelClassType MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle Pointer )

            return value;
        }
    }
}
