using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_capturedContext                        0001865CCF60 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 018 M_action                                 00018667A860 ModelClassType Action Action Action Pointer
    // 000 s_invokeActionCallback                   ContextCallback IL2CPP_TYPE_CLASS
    public partial class AwaitTaskContinuation
    {
        public ExecutionContext?                        M_capturedContext                       { get; set; }
        public Action?                                  M_action                                { get; set; }

        public static AwaitTaskContinuation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwaitTaskContinuation();

            value.M_capturedContext                         = GetObject<ExecutionContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0270D0EE1E98 0x10 M_capturedContext           ( 0001865CCF60 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.M_action                                  = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D0EE1EB8 0x18 M_action                    ( 00018667A860 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
