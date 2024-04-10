using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Expressions                              000185CFEED8 ModelClassListType List`1<QueryExpression> List`1<QueryExpression> List<QueryExpression> Pointer
    public partial class CompositeExpression : DataModel
    {
        public List<QueryExpression>?                   Expressions                             { get; set; }

        public static CompositeExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompositeExpression() { Pointer= p0 };

            value.Expressions                               = GetObjectList<QueryExpression>(new IntPtr(p + 0x018), ReversePrism.DataModels.QueryExpression.FromPointer); // 0246688A1180 0x18 Expressions                 ( 000185CFEED8 ModelClassListType List`1<QueryExpression> List`1<QueryExpression> List<QueryExpression> Pointer )

            return value;
        }
    }
}
