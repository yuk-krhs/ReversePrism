using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 WrapExceptionsInIOExceptions             000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class Int32TaskSocketAsyncEventArgs
    {
        public bool                                     WrapExceptionsInIOExceptions            { get; set; }

        public static Int32TaskSocketAsyncEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int32TaskSocketAsyncEventArgs();

            value.WrapExceptionsInIOExceptions              = GetBool(new IntPtr(p + 0x0A0)); // 0270D7AE65E0 0xA0 WrapExceptionsInIOExceptions ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
