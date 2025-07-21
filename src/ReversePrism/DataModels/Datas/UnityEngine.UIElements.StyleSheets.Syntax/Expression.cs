using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 014 Multiplier                               ModelEnumType ExpressionMultiplier ExpressionMultiplier ExpressionMultiplier Int32
    // 020 DataType                                 ModelEnumType DataType DataType DataType Int32
    // 024 Combinator                               ModelEnumType ExpressionCombinator ExpressionCombinator ExpressionCombinator Int32
    // 028 SubExpressions                           ModelClassListType Expression[] Expression[] List<Expression> Pointer
    // 030 Keyword                                  ModelPrimitiveType string string string String
    public partial class Expression : DataModel
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
            var value   = new Expression() { Pointer= p0 };

            value.Type                                      = (ExpressionType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Multiplier                                = (ExpressionMultiplier)GetInt32(new IntPtr(p + 0x014)); // 0x14 Multiplier                  ( ModelEnumType ExpressionMultiplier ExpressionMultiplier ExpressionMultiplier Int32 )
            value.DataType                                  = (DataType)GetInt32(new IntPtr(p + 0x020)); // 0x20 DataType                    ( ModelEnumType DataType DataType DataType Int32 )
            value.Combinator                                = (ExpressionCombinator)GetInt32(new IntPtr(p + 0x024)); // 0x24 Combinator                  ( ModelEnumType ExpressionCombinator ExpressionCombinator ExpressionCombinator Int32 )
            value.SubExpressions                            = GetObjectList<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0x28 SubExpressions              ( ModelClassListType Expression[] Expression[] List<Expression> Pointer )
            value.Keyword                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Keyword                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
