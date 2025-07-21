using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelPrimitiveType long long long Int64
    public partial class BinXmlSqlMoney : DataModel
    {
        public long                                     Data                                    { get; set; }

        public static BinXmlSqlMoney? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinXmlSqlMoney() { Pointer= p0 };

            value.Data                                      = GetInt64(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
