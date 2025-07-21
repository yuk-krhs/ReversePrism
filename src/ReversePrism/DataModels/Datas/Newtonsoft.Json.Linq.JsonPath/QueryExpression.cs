using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Operator                                 ModelEnumType QueryOperator QueryOperator QueryOperator Int32
    public partial class QueryExpression : DataModel
    {
        public QueryOperator                            Operator                                { get; set; }

        public static QueryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryExpression() { Pointer= p0 };

            value.Operator                                  = (QueryOperator)GetInt32(new IntPtr(p + 0x010)); // 0x10 Operator                    ( ModelEnumType QueryOperator QueryOperator QueryOperator Int32 )

            return value;
        }
    }
}
