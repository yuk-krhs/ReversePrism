using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetTable                              0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    public partial class RowDiffIdUsageSection : DataModel
    {
        public DataTable?                               TargetTable                             { get; set; }

        public static RowDiffIdUsageSection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RowDiffIdUsageSection() { Pointer= p0 };

            value.TargetTable                               = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 024668958BB0 0x10 TargetTable                 ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )

            return value;
        }
    }
}
