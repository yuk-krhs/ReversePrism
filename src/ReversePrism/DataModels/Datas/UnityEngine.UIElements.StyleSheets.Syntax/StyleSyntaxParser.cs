using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ProcessExpressionList                  000185CDBDF8 ModelClassListType List`1<Expression> List`1<Expression> List<Expression> Pointer
    // 018 m_ExpressionStack                        Stack`1<Expression> IL2CPP_TYPE_GENERICINST
    // 020 m_CombinatorStack                        Stack`1<ExpressionCombinator> IL2CPP_TYPE_GENERICINST
    // 028 m_ParsedExpressionCache                  Dictionary`2<string, Expression> IL2CPP_TYPE_GENERICINST
    public partial class StyleSyntaxParser : DataModel
    {
        public List<Expression>?                        M_ProcessExpressionList                 { get; set; }

        public static StyleSyntaxParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSyntaxParser() { Pointer= p0 };

            value.M_ProcessExpressionList                   = GetObjectList<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0245A684B618 0x10 M_ProcessExpressionList     ( 000185CDBDF8 ModelClassListType List`1<Expression> List`1<Expression> List<Expression> Pointer )

            return value;
        }
    }
}
