using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 Body                                     ModelClassType Expression Expression Expression Pointer
    // 020 <Handlers>k__BackingField                ReadOnlyCollection`1<CatchBlock> IL2CPP_TYPE_GENERICINST
    // 028 Finally                                  ModelClassType Expression Expression Expression Pointer
    // 030 Fault                                    ModelClassType Expression Expression Expression Pointer
    public partial class TryExpression : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public Expression?                              Body                                    { get; set; }
        public Expression?                              Finally                                 { get; set; }
        public Expression?                              Fault                                   { get; set; }

        public static TryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TryExpression() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.Body                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Body                        ( ModelClassType Expression Expression Expression Pointer )
            value.Finally                                   = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0x28 Finally                     ( ModelClassType Expression Expression Expression Pointer )
            value.Fault                                     = GetObject<Expression>(new IntPtr(p + 0x030), ReversePrism.DataModels.Expression.FromPointer); // 0x30 Fault                       ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
