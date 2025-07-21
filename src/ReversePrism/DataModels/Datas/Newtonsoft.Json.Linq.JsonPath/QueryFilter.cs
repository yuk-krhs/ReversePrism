using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expression                               ModelClassType QueryExpression QueryExpression QueryExpression Pointer
    public partial class QueryFilter : DataModel
    {
        public QueryExpression?                         Expression                              { get; set; }

        public static QueryFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryFilter() { Pointer= p0 };

            value.Expression                                = GetObject<QueryExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.QueryExpression.FromPointer); // 0x10 Expression                  ( ModelClassType QueryExpression QueryExpression QueryExpression Pointer )

            return value;
        }
    }
}
