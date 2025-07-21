using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    public partial class DataTablePropertyDescriptor : DataModel
    {
        public DataTable?                               Table                                   { get; set; }

        public static DataTablePropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTablePropertyDescriptor() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x088), ReversePrism.DataModels.DataTable.FromPointer); // 0x88 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )

            return value;
        }
    }
}
