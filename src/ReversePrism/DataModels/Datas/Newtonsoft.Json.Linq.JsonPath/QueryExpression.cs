using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Operator                                 0001865FDF40 ModelEnumType QueryOperator QueryOperator QueryOperator Int32
    public partial class QueryExpression
    {
        public QueryOperator                            Operator                                { get; set; }

        public static QueryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryExpression();

            value.Operator                                  = (QueryOperator)GetInt32(new IntPtr(p + 0x010)); // 0270D883E130 0x10 Operator                    ( 0001865FDF40 ModelEnumType QueryOperator QueryOperator QueryOperator Int32 )

            return value;
        }
    }
}
