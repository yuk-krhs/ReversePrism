using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    public partial class DataTableClearEventArgs
    {
        public DataTable?                               Table                                   { get; set; }

        public static DataTableClearEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTableClearEventArgs();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0270D890ACD0 0x10 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )

            return value;
        }
    }
}
