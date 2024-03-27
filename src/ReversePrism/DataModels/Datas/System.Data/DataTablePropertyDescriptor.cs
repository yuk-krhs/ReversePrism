using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    public partial class DataTablePropertyDescriptor
    {
        public DataTable?                               Table                                   { get; set; }

        public static DataTablePropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTablePropertyDescriptor();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x088), ReversePrism.DataModels.DataTable.FromPointer); // 0270D8913CA0 0x88 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )

            return value;
        }
    }
}
