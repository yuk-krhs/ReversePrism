using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Conversion                               0001867781F0 ModelClassType LambdaExpression LambdaExpression LambdaExpression Pointer
    public partial class OpAssignMethodConversionBinaryExpression
    {
        public LambdaExpression?                        Conversion                              { get; set; }

        public static OpAssignMethodConversionBinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpAssignMethodConversionBinaryExpression();

            value.Conversion                                = GetObject<LambdaExpression>(new IntPtr(p + 0x038), ReversePrism.DataModels.LambdaExpression.FromPointer); // 0270D9F17468 0x38 Conversion                  ( 0001867781F0 ModelClassType LambdaExpression LambdaExpression LambdaExpression Pointer )

            return value;
        }
    }
}
