using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA5E08 ModelEnumListType SqlInt16[] SqlInt16[] List<SqlInt16> Pointer
    public partial class SqlInt16Storage
    {
        public List<SqlInt16>?                          Values                                  { get; set; }

        public static SqlInt16Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlInt16Storage();

            value.Values                                    = GetEnumList<SqlInt16>(new IntPtr(p + 0x050)); // 0270D89EC850 0x50 Values                      ( 000185CA5E08 ModelEnumListType SqlInt16[] SqlInt16[] List<SqlInt16> Pointer )

            return value;
        }
    }
}
