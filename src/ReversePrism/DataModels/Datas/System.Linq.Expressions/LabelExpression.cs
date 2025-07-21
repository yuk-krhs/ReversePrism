using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 018 DefaultValue                             ModelClassType Expression Expression Expression Pointer
    public partial class LabelExpression : DataModel
    {
        public LabelTarget?                             Target                                  { get; set; }
        public Expression?                              DefaultValue                            { get; set; }

        public static LabelExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LabelExpression() { Pointer= p0 };

            value.Target                                    = GetObject<LabelTarget>(new IntPtr(p + 0x010), ReversePrism.DataModels.LabelTarget.FromPointer); // 0x10 Target                      ( ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.DefaultValue                              = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 DefaultValue                ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
