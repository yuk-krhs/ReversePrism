using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Control                                  ModelClassType MultiColumnHeaderColumn MultiColumnHeaderColumn MultiColumnHeaderColumn Pointer
    // 018 ResizeHandle                             ModelClassType MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle Pointer
    public partial class ColumnData : DataModel
    {
        public MultiColumnHeaderColumn?                 Control                                 { get; set; }
        public MultiColumnHeaderColumnResizeHandle?     ResizeHandle                            { get; set; }

        public static ColumnData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnData() { Pointer= p0 };

            value.Control                                   = GetObject<MultiColumnHeaderColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.MultiColumnHeaderColumn.FromPointer); // 0x10 Control                     ( ModelClassType MultiColumnHeaderColumn MultiColumnHeaderColumn MultiColumnHeaderColumn Pointer )
            value.ResizeHandle                              = GetObject<MultiColumnHeaderColumnResizeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.MultiColumnHeaderColumnResizeHandle.FromPointer); // 0x18 ResizeHandle                ( ModelClassType MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle MultiColumnHeaderColumnResizeHandle Pointer )

            return value;
        }
    }
}
