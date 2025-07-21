using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NodeType                                 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 018 Expression                               ModelClassType Expression Expression Expression Pointer
    // 020 TypeOperand                              ModelClassType Type Type Type Pointer
    public partial class TypeBinaryExpression : DataModel
    {
        public ExpressionType                           NodeType                                { get; set; }
        public Expression?                              Expression                              { get; set; }
        public Type?                                    TypeOperand                             { get; set; }

        public static TypeBinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeBinaryExpression() { Pointer= p0 };

            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x010)); // 0x10 NodeType                    ( ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Expression                  ( ModelClassType Expression Expression Expression Pointer )
            value.TypeOperand                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 TypeOperand                 ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
