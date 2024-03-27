using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA5FD8 ModelEnumListType SqlInt32[] SqlInt32[] List<SqlInt32> Pointer
    public partial class SqlInt32Storage
    {
        public List<SqlInt32>?                          Values                                  { get; set; }

        public static SqlInt32Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlInt32Storage();

            value.Values                                    = GetEnumList<SqlInt32>(new IntPtr(p + 0x050)); // 0270D89ECED0 0x50 Values                      ( 000185CA5FD8 ModelEnumListType SqlInt32[] SqlInt32[] List<SqlInt32> Pointer )

            return value;
        }
    }
}
