using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Conversion                               ModelClassType LambdaExpression LambdaExpression LambdaExpression Pointer
    public partial class CoalesceConversionBinaryExpression : DataModel
    {
        public LambdaExpression?                        Conversion                              { get; set; }

        public static CoalesceConversionBinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoalesceConversionBinaryExpression() { Pointer= p0 };

            value.Conversion                                = GetObject<LambdaExpression>(new IntPtr(p + 0x020), ReversePrism.DataModels.LambdaExpression.FromPointer); // 0x20 Conversion                  ( ModelClassType LambdaExpression LambdaExpression LambdaExpression Pointer )

            return value;
        }
    }
}
