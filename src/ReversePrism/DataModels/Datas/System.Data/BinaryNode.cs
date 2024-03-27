using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Op                                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Left                                     00018652D4A0 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer
    // 028 Right                                    00018652D4A0 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer
    public partial class BinaryNode
    {
        public int                                      Op                                      { get; set; }
        public ExpressionNode?                          Left                                    { get; set; }
        public ExpressionNode?                          Right                                   { get; set; }

        public static BinaryNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryNode();

            value.Op                                        = GetInt32(new IntPtr(p + 0x018)); // 0270D8929150 0x18 Op                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Left                                      = GetObject<ExpressionNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExpressionNode.FromPointer); // 0270D8929170 0x20 Left                        ( 00018652D4A0 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer )
            value.Right                                     = GetObject<ExpressionNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExpressionNode.FromPointer); // 0270D8929190 0x28 Right                       ( 00018652D4A0 ModelClassType ExpressionNode ExpressionNode ExpressionNode Pointer )

            return value;
        }
    }
}
