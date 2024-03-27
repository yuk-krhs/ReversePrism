using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 M_ColumnController                       00018665E2A0 ModelClassType MultiColumnController MultiColumnController MultiColumnController Pointer
    public partial class MultiColumnTreeViewController
    {
        public MultiColumnController?                   M_ColumnController                      { get; set; }

        public static MultiColumnTreeViewController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnTreeViewController();

            value.M_ColumnController                        = GetObject<MultiColumnController>(new IntPtr(p + 0x058), ReversePrism.DataModels.MultiColumnController.FromPointer); // 0270066E7E08 0x58 M_ColumnController          ( 00018665E2A0 ModelClassType MultiColumnController MultiColumnController MultiColumnController Pointer )

            return value;
        }
    }
}
