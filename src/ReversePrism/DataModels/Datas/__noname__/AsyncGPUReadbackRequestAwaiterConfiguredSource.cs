using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AsyncGPUReadbackRequestAwaiterConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671D9C0 ModelClassType AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource Pointer
    // 018 AsyncOperation                           00018658D8A0 ModelEnumType AsyncGPUReadbackRequest AsyncGPUReadbackRequest AsyncGPUReadbackRequest Int32
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<AsyncGPUReadbackRequest> IL2CPP_TYPE_GENERICINST
    public partial class AsyncGPUReadbackRequestAwaiterConfiguredSource : DataModel
    {
        public AsyncGPUReadbackRequestAwaiterConfiguredSource? NextNode                                { get; set; }
        public AsyncGPUReadbackRequest                  AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static AsyncGPUReadbackRequestAwaiterConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncGPUReadbackRequestAwaiterConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<AsyncGPUReadbackRequestAwaiterConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncGPUReadbackRequestAwaiterConfiguredSource.FromPointer); // 024668FECA50 0x10 NextNode                    ( 00018671D9C0 ModelClassType AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource Pointer )
            value.AsyncOperation                            = (AsyncGPUReadbackRequest)GetInt32(new IntPtr(p + 0x018)); // 024668FECA70 0x18 AsyncOperation              ( 00018658D8A0 ModelEnumType AsyncGPUReadbackRequest AsyncGPUReadbackRequest AsyncGPUReadbackRequest Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 024668FECA90 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
