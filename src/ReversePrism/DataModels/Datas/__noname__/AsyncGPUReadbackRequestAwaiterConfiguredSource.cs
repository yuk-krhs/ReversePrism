using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AsyncGPUReadbackRequestAwaiterConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource Pointer
    // 018 AsyncOperation                           ModelEnumType AsyncGPUReadbackRequest AsyncGPUReadbackRequest AsyncGPUReadbackRequest Int32
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 048 core                                     UniTaskCompletionSourceCore`1<AsyncGPUReadbackRequest> IL2CPP_TYPE_GENERICINST
    public partial class AsyncGPUReadbackRequestAwaiterConfiguredSource : DataModel
    {
        public AsyncGPUReadbackRequestAwaiterConfiguredSource? NextNode                                { get; set; }
        public AsyncGPUReadbackRequest                  AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }

        public static AsyncGPUReadbackRequestAwaiterConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncGPUReadbackRequestAwaiterConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<AsyncGPUReadbackRequestAwaiterConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncGPUReadbackRequestAwaiterConfiguredSource.FromPointer); // 0x10 NextNode                    ( ModelClassType AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource AsyncGPUReadbackRequestAwaiterConfiguredSource Pointer )
            value.AsyncOperation                            = (AsyncGPUReadbackRequest)GetInt32(new IntPtr(p + 0x018)); // 0x18 AsyncOperation              ( ModelEnumType AsyncGPUReadbackRequest AsyncGPUReadbackRequest AsyncGPUReadbackRequest Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x030)); // 0x30 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
