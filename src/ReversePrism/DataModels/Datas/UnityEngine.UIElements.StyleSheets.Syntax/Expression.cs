using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018652E850 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 014 Multiplier                               0001865CF910 ModelEnumType ExpressionMultiplier ExpressionMultiplier ExpressionMultiplier Int32
    // 020 DataType                                 000186684B70 ModelEnumType DataType DataType DataType Int32
    // 024 Combinator                               00018652B570 ModelEnumType ExpressionCombinator ExpressionCombinator ExpressionCombinator Int32
    // 028 SubExpressions                           000185B7D840 ModelClassListType Expression[] Expression[] List<Expression> Pointer
    // 030 Keyword                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class Expression
    {
        public ExpressionType                           Type                                    { get; set; }
        public ExpressionMultiplier                     Multiplier                              { get; set; }
        public DataType                                 DataType                                { get; set; }
        public ExpressionCombinator                     Combinator                              { get; set; }
        public List<Expression>?                        SubExpressions                          { get; set; }
        public string                                   Keyword                                 { get; set; }

        public static Expression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Expression();

            value.Type                                      = (ExpressionType)GetInt32(new IntPtr(p + 0x010)); // 027006888960 0x10 Type                        ( 00018652E850 ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Multiplier                                = (ExpressionMultiplier)GetInt32(new IntPtr(p + 0x014)); // 027006888980 0x14 Multiplier                  ( 0001865CF910 ModelEnumType ExpressionMultiplier ExpressionMultiplier ExpressionMultiplier Int32 )
            value.DataType                                  = (DataType)GetInt32(new IntPtr(p + 0x020)); // 0270068889A0 0x20 DataType                    ( 000186684B70 ModelEnumType DataType DataType DataType Int32 )
            value.Combinator                                = (ExpressionCombinator)GetInt32(new IntPtr(p + 0x024)); // 0270068889C0 0x24 Combinator                  ( 00018652B570 ModelEnumType ExpressionCombinator ExpressionCombinator ExpressionCombinator Int32 )
            value.SubExpressions                            = GetObjectList<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0270068889E0 0x28 SubExpressions              ( 000185B7D840 ModelClassListType Expression[] Expression[] List<Expression> Pointer )
            value.Keyword                                   = GetString(new IntPtr(p + 0x030)); // 027006888A00 0x30 Keyword                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
