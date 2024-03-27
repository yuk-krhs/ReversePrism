using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA5848 ModelEnumListType SqlDecimal[] SqlDecimal[] List<SqlDecimal> Pointer
    public partial class SqlDecimalStorage
    {
        public List<SqlDecimal>?                        Values                                  { get; set; }

        public static SqlDecimalStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlDecimalStorage();

            value.Values                                    = GetEnumList<SqlDecimal>(new IntPtr(p + 0x050)); // 0270D89EB4D0 0x50 Values                      ( 000185CA5848 ModelEnumListType SqlDecimal[] SqlDecimal[] List<SqlDecimal> Pointer )

            return value;
        }
    }
}
