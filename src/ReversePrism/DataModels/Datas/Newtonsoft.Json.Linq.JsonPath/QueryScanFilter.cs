using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expression                               0001865FCF10 ModelClassType QueryExpression QueryExpression QueryExpression Pointer
    public partial class QueryScanFilter
    {
        public QueryExpression?                         Expression                              { get; set; }

        public static QueryScanFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryScanFilter();

            value.Expression                                = GetObject<QueryExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.QueryExpression.FromPointer); // 0270D8863370 0x10 Expression                  ( 0001865FCF10 ModelClassType QueryExpression QueryExpression QueryExpression Pointer )

            return value;
        }
    }
}
