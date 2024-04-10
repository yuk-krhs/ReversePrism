using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Arguments                                000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer
    public partial class InstanceMethodCallExpressionN : DataModel
    {
        public List<Expression>?                        Arguments                               { get; set; }

        public static InstanceMethodCallExpressionN? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstanceMethodCallExpressionN() { Pointer= p0 };

            value.Arguments                                 = GetObjectList<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 024669FD1FD8 0x20 Arguments                   ( 000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer )

            return value;
        }
    }
}
