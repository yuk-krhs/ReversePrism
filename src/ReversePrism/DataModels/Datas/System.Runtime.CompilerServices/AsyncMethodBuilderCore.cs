using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_stateMachine                           000186709D10 ModelClassType IAsyncStateMachine IAsyncStateMachine IAsyncStateMachine Pointer
    // 018 M_defaultContextAction                   0001866794E0 ModelClassType Action Action Action Pointer
    public partial class AsyncMethodBuilderCore
    {
        public IAsyncStateMachine?                      M_stateMachine                          { get; set; }
        public Action?                                  M_defaultContextAction                  { get; set; }

        public static AsyncMethodBuilderCore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncMethodBuilderCore();

            value.M_stateMachine                            = GetObject<IAsyncStateMachine>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAsyncStateMachine.FromPointer); // 027003C2DD78 0x10 M_stateMachine              ( 000186709D10 ModelClassType IAsyncStateMachine IAsyncStateMachine IAsyncStateMachine Pointer )
            value.M_defaultContextAction                    = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 027003C2DD98 0x18 M_defaultContextAction      ( 0001866794E0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
