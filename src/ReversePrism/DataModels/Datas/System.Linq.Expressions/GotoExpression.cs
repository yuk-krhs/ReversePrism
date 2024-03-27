using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 018 Value                                    0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 020 Target                                   000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 028 Kind                                     00018668D710 ModelEnumType GotoExpressionKind GotoExpressionKind GotoExpressionKind Int32
    public partial class GotoExpression
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
            var value   = new GotoExpression();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D9F30F30 0x10 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.Value                                     = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F30F50 0x18 Value                       ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Target                                    = GetObject<LabelTarget>(new IntPtr(p + 0x020), ReversePrism.DataModels.LabelTarget.FromPointer); // 0270D9F30F70 0x20 Target                      ( 000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.Kind                                      = (GotoExpressionKind)GetInt32(new IntPtr(p + 0x028)); // 0270D9F30F90 0x28 Kind                        ( 00018668D710 ModelEnumType GotoExpressionKind GotoExpressionKind GotoExpressionKind Int32 )

            return value;
        }
    }
}
