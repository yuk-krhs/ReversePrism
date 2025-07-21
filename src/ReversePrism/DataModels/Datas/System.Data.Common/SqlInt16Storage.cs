using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelEnumListType SqlInt16[] SqlInt16[] List<SqlInt16> Pointer
    public partial class SqlInt16Storage : DataModel
    {
        public List<SqlInt16>?                          Values                                  { get; set; }

        public static SqlInt16Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlInt16Storage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlInt16>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType SqlInt16[] SqlInt16[] List<SqlInt16> Pointer )

            return value;
        }
    }
}
