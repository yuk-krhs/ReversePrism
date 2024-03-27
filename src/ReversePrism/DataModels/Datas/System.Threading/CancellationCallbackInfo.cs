using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Callback                                 Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 018 StateForCallback                         <object> IL2CPP_TYPE_OBJECT
    // 020 TargetExecutionContext                   0001865CD210 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 028 CancellationTokenSource                  0001865A4590 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 000 s_executionContextCallback               ContextCallback IL2CPP_TYPE_CLASS
    public partial class CancellationCallbackInfo
    {
        public ExecutionContext?                        TargetExecutionContext                  { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static CancellationCallbackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancellationCallbackInfo();

            value.TargetExecutionContext                    = GetObject<ExecutionContext>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0270D1A51348 0x20 TargetExecutionContext      ( 0001865CD210 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D1A51368 0x28 CancellationTokenSource     ( 0001865A4590 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
