using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 Value                                    ModelClassType Expression Expression Expression Pointer
    // 020 Target                                   ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 028 Kind                                     ModelEnumType GotoExpressionKind GotoExpressionKind GotoExpressionKind Int32
    public partial class GotoExpression : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public Expression?                              Value                                   { get; set; }
        public LabelTarget?                             Target                                  { get; set; }
        public GotoExpressionKind                       Kind                                    { get; set; }

        public static GotoExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GotoExpression() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.Value                                     = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Value                       ( ModelClassType Expression Expression Expression Pointer )
            value.Target                                    = GetObject<LabelTarget>(new IntPtr(p + 0x020), ReversePrism.DataModels.LabelTarget.FromPointer); // 0x20 Target                      ( ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.Kind                                      = (GotoExpressionKind)GetInt32(new IntPtr(p + 0x028)); // 0x28 Kind                        ( ModelEnumType GotoExpressionKind GotoExpressionKind GotoExpressionKind Int32 )

            return value;
        }
    }
}
