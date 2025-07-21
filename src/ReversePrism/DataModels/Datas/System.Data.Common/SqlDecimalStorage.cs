using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelEnumListType SqlDecimal[] SqlDecimal[] List<SqlDecimal> Pointer
    public partial class SqlDecimalStorage : DataModel
    {
        public List<SqlDecimal>?                        Values                                  { get; set; }

        public static SqlDecimalStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlDecimalStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlDecimal>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType SqlDecimal[] SqlDecimal[] List<SqlDecimal> Pointer )

            return value;
        }
    }
}
