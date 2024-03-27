using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Block                                    000186765D00 ModelClassType BlockExpression BlockExpression BlockExpression Pointer
    // 018 Arg0                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class BlockExpressionList
    {
        public BlockExpression?                         Block                                   { get; set; }
        public Expression?                              Arg0                                    { get; set; }

        public static BlockExpressionList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlockExpressionList();

            value.Block                                     = GetObject<BlockExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.BlockExpression.FromPointer); // 0270D9F39F08 0x10 Block                       ( 000186765D00 ModelClassType BlockExpression BlockExpression BlockExpression Pointer )
            value.Arg0                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F39F28 0x18 Arg0                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
