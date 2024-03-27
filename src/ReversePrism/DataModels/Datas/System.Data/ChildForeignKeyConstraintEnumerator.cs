using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    public partial class ChildForeignKeyConstraintEnumerator
    {
        public DataTable?                               Table                                   { get; set; }

        public static ChildForeignKeyConstraintEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChildForeignKeyConstraintEnumerator();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88A5E78 0x28 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )

            return value;
        }
    }
}
