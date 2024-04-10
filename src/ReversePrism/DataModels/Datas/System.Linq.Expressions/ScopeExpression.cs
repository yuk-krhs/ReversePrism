using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Variables                                000185D13CA8 ModelClassListType IReadOnlyList`1<ParameterExpression> IReadOnlyList`1<ParameterExpression> List<ParameterExpression> Pointer
    public partial class ScopeExpression : DataModel
    {
        public List<ParameterExpression>?               Variables                               { get; set; }

        public static ScopeExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScopeExpression() { Pointer= p0 };

            value.Variables                                 = GetObjectList<ParameterExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.ParameterExpression.FromPointer); // 024669F95F08 0x10 Variables                   ( 000185D13CA8 ModelClassListType IReadOnlyList`1<ParameterExpression> IReadOnlyList`1<ParameterExpression> List<ParameterExpression> Pointer )

            return value;
        }
    }
}
