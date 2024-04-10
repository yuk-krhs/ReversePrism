using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Arguments                                000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer
    // 018 Constructor                              00018660FE70 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    public partial class NewExpression : DataModel
    {
        public List<Expression>?                        Arguments                               { get; set; }
        public ConstructorInfo?                         Constructor                             { get; set; }

        public static NewExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NewExpression() { Pointer= p0 };

            value.Arguments                                 = GetObjectList<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 024669FCC2B0 0x10 Arguments                   ( 000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer )
            value.Constructor                               = GetObject<ConstructorInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 024669FCC2D0 0x18 Constructor                 ( 00018660FE70 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )

            return value;
        }
    }
}
