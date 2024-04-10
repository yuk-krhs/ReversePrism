using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Op                                       0001865F44E0 ModelPrimitiveType int int int Int32
    // 020 Right                                    00018652D4A0 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer
    public partial class UnaryNode : DataModel
    {
        public int                                      Op                                      { get; set; }
        public ExpressionNode?                          Right                                   { get; set; }

        public static UnaryNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnaryNode() { Pointer= p0 };

            value.Op                                        = GetInt32(new IntPtr(p + 0x018)); // 0246689A8D38 0x18 Op                          ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.Right                                     = GetObject<ExpressionNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExpressionNode.FromPointer); // 0246689A8D58 0x20 Right                       ( 00018652D4A0 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer )

            return value;
        }
    }
}
