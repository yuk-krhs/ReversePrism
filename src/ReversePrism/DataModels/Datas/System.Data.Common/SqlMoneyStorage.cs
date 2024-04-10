using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA63E8 ModelEnumListType SqlMoney[] SqlMoney[] List<SqlMoney> Pointer
    public partial class SqlMoneyStorage : DataModel
    {
        public List<SqlMoney>?                          Values                                  { get; set; }

        public static SqlMoneyStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlMoneyStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlMoney>(new IntPtr(p + 0x050)); // 024668A58CA8 0x50 Values                      ( 000185CA63E8 ModelEnumListType SqlMoney[] SqlMoney[] List<SqlMoney> Pointer )

            return value;
        }
    }
}
