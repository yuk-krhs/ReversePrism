using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 018 NodeType                                 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 020 Operand                                  0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 028 Method                                   000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
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

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024669F95050 0x10 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x018)); // 024669F95070 0x18 NodeType                    ( 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Operand                                   = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 024669F95090 0x20 Operand                     ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F950B0 0x28 Method                      ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
