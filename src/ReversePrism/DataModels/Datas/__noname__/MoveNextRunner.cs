using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_context                                0001865CCF60 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 018 M_stateMachine                           000186709D10 ModelClassType IAsyncStateMachine IAsyncStateMachine IAsyncStateMachine Pointer
    // 000 s_invokeMoveNext                         ContextCallback IL2CPP_TYPE_CLASS
    public partial class MoveNextRunner : DataModel
    {
        public ExecutionContext?                        M_context                               { get; set; }
        public IAsyncStateMachine?                      M_stateMachine                          { get; set; }

        public static MoveNextRunner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoveNextRunner() { Pointer= p0 };

            value.M_context                                 = GetObject<ExecutionContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExecutionContext.FromPointer); // 024660EAD0B0 0x10 M_context                   ( 0001865CCF60 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.M_stateMachine                            = GetObject<IAsyncStateMachine>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAsyncStateMachine.FromPointer); // 024660EAD0D0 0x18 M_stateMachine              ( 000186709D10 ModelClassType IAsyncStateMachine IAsyncStateMachine IAsyncStateMachine Pointer )

            return value;
        }
    }
}
