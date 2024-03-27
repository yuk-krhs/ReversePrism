using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     0001865F7700 ModelPrimitiveType long long long Int64
    public partial class BinXmlSqlMoney
    {
        public long                                     Data                                    { get; set; }

        public static BinXmlSqlMoney? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinXmlSqlMoney();

            value.Data                                      = GetInt64(new IntPtr(p + 0x010)); // 0270D734B908 0x10 Data                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
