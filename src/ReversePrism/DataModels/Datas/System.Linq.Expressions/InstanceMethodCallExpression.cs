using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Instance                                 ModelClassType Expression Expression Expression Pointer
    public partial class InstanceMethodCallExpression : DataModel
    {
        public Expression?                              Instance                                { get; set; }

        public static InstanceMethodCallExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstanceMethodCallExpression() { Pointer= p0 };

            value.Instance                                  = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Instance                    ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
