using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 NodeType                                 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 020 Operand                                  ModelClassType Expression Expression Expression Pointer
    // 028 Method                                   ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class UnaryExpression : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public ExpressionType                           NodeType                                { get; set; }
        public Expression?                              Operand                                 { get; set; }
        public MethodInfo?                              Method                                  { get; set; }

        public static UnaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnaryExpression() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x018)); // 0x18 NodeType                    ( ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Operand                                   = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0x20 Operand                     ( ModelClassType Expression Expression Expression Pointer )
            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x28 Method                      ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
