using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expressions                              000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer
    public partial class BlockN
    {
        public List<Expression>?                        Expressions                             { get; set; }

        public static BlockN? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlockN();

            value.Expressions                               = GetObjectList<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F38C08 0x10 Expressions                 ( 000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer )

            return value;
        }
    }
}
