using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_ColumnController                       ModelClassType MultiColumnController MultiColumnController MultiColumnController Pointer
    public partial class MultiColumnListViewController : DataModel
    {
        public MultiColumnController?                   M_ColumnController                      { get; set; }

        public static MultiColumnListViewController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnListViewController() { Pointer= p0 };

            value.M_ColumnController                        = GetObject<MultiColumnController>(new IntPtr(p + 0x048), ReversePrism.DataModels.MultiColumnController.FromPointer); // 0x48 M_ColumnController          ( ModelClassType MultiColumnController MultiColumnController MultiColumnController Pointer )

            return value;
        }
    }
}
