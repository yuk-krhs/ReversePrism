using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelEnumListType SqlInt64[] SqlInt64[] List<SqlInt64> Pointer
    public partial class SqlInt64Storage : DataModel
    {
        public List<SqlInt64>?                          Values                                  { get; set; }

        public static SqlInt64Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlInt64Storage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlInt64>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType SqlInt64[] SqlInt64[] List<SqlInt64> Pointer )

            return value;
        }
    }
}
