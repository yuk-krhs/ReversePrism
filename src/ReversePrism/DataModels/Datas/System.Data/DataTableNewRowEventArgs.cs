using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Row                                      ModelClassType DataRow DataRow DataRow Pointer
    public partial class DataTableNewRowEventArgs : DataModel
    {
        public DataRow?                                 Row                                     { get; set; }

        public static DataTableNewRowEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTableNewRowEventArgs() { Pointer= p0 };

            value.Row                                       = GetObject<DataRow>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataRow.FromPointer); // 0x10 Row                         ( ModelClassType DataRow DataRow DataRow Pointer )

            return value;
        }
    }
}
