using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Reserved                                 AwaitableSocketAsyncEventArgs IL2CPP_TYPE_CLASS
    // 008 s_completedSentinel                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 s_availableSentinel                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 080 _continuation                            Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 088 ExecutionContext                         0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 090 _scheduler                               <object> IL2CPP_TYPE_OBJECT
    // 098 Token                                    0001865F1060 ModelPrimitiveType short short short Int16
    // 09A WrapExceptionsInIOExceptions             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AwaitableSocketAsyncEventArgs
    {
        public ExecutionContext?                        ExecutionContext                        { get; set; }
        public short                                    Token                                   { get; set; }
        public bool                                     WrapExceptionsInIOExceptions            { get; set; }

        public static AwaitableSocketAsyncEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwaitableSocketAsyncEventArgs();

            value.ExecutionContext                          = GetObject<ExecutionContext>(new IntPtr(p + 0x088), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0270D7AE6DF0 0x88 ExecutionContext            ( 0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.Token                                     = GetInt16(new IntPtr(p + 0x098)); // 0270D7AE6E30 0x98 Token                       ( 0001865F1060 ModelPrimitiveType short short short Int16 )
            value.WrapExceptionsInIOExceptions              = GetBool(new IntPtr(p + 0x09A)); // 0270D7AE6E50 0x9A WrapExceptionsInIOExceptions ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
