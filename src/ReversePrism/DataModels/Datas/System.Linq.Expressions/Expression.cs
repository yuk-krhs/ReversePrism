using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_lambdaDelegateCache                    CacheDict`2<Type, MethodInfo> IL2CPP_TYPE_GENERICINST
    // 008 s_lambdaFactories                        CacheDict`2<Type, Func`5<Expression, string, bool, ReadOnlyCollection`1<ParameterExpression>, LambdaExpression>> IL2CPP_TYPE_GENERICINST
    // 010 s_legacyCtorSupportTable                 ConditionalWeakTable`2<Expression, ExtensionInfo> IL2CPP_TYPE_GENERICINST
    public partial class Expression
    {

        public static Expression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Expression();


            return value;
        }
    }
}
