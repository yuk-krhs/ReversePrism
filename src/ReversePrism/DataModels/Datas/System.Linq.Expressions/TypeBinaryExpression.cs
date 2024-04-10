using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NodeType                                 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 018 Expression                               0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 020 TypeOperand                              0001866936B0 ModelClassType Type Type Type Pointer
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

            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x010)); // 024669F94918 0x10 NodeType                    ( 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 024669F94938 0x18 Expression                  ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.TypeOperand                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024669F94958 0x20 TypeOperand                 ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
