using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Arguments                                000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer
    public partial class MethodCallExpressionN : DataModel
    {
        public List<Expression>?                        Arguments                               { get; set; }

        public static MethodCallExpressionN? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodCallExpressionN() { Pointer= p0 };

            value.Arguments                                 = GetObjectList<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 024669FD1D88 0x18 Arguments                   ( 000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer )

            return value;
        }
    }
}
