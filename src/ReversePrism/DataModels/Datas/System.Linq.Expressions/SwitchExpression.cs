using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SwitchValue                              0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 018 <Cases>k__BackingField                   ReadOnlyCollection`1<SwitchCase> IL2CPP_TYPE_GENERICINST
    // 020 DefaultBody                              0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 028 Comparison                               000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class SwitchExpression
    {
        public Expression?                              SwitchValue                             { get; set; }
        public Expression?                              DefaultBody                             { get; set; }
        public MethodInfo?                              Comparison                              { get; set; }

        public static SwitchExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchExpression();

            value.SwitchValue                               = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F80650 0x10 SwitchValue                 ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.DefaultBody                               = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F80690 0x20 DefaultBody                 ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Comparison                                = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D9F806B0 0x28 Comparison                  ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
