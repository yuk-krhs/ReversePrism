using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lambda                                   ModelClassType LambdaExpression LambdaExpression LambdaExpression Pointer
    // 018 Interpreter                              ModelClassType Interpreter Interpreter Interpreter Pointer
    public partial class LightDelegateCreator : DataModel
    {
        public LambdaExpression?                        Lambda                                  { get; set; }
        public Interpreter?                             Interpreter                             { get; set; }

        public static LightDelegateCreator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightDelegateCreator() { Pointer= p0 };

            value.Lambda                                    = GetObject<LambdaExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.LambdaExpression.FromPointer); // 0x10 Lambda                      ( ModelClassType LambdaExpression LambdaExpression LambdaExpression Pointer )
            value.Interpreter                               = GetObject<Interpreter>(new IntPtr(p + 0x018), ReversePrism.DataModels.Interpreter.FromPointer); // 0x18 Interpreter                 ( ModelClassType Interpreter Interpreter Interpreter Pointer )

            return value;
        }
    }
}
