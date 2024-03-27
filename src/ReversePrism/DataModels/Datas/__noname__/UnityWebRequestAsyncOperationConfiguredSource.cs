using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<UnityWebRequestAsyncOperationConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671EFA0 ModelClassType UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource Pointer
    // 018 AsyncOperation                           00018672EB90 ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<UnityWebRequest> IL2CPP_TYPE_GENERICINST
    public partial class UnityWebRequestAsyncOperationConfiguredSource
    {
        public UnityWebRequestAsyncOperationConfiguredSource? NextNode                                { get; set; }
        public UnityWebRequestAsyncOperation?           AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static UnityWebRequestAsyncOperationConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityWebRequestAsyncOperationConfiguredSource();

            value.NextNode                                  = GetObject<UnityWebRequestAsyncOperationConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityWebRequestAsyncOperationConfiguredSource.FromPointer); // 027004E31058 0x10 NextNode                    ( 00018671EFA0 ModelClassType UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<UnityWebRequestAsyncOperation>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityWebRequestAsyncOperation.FromPointer); // 027004E31078 0x18 AsyncOperation              ( 00018672EB90 ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 027004E310B8 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
