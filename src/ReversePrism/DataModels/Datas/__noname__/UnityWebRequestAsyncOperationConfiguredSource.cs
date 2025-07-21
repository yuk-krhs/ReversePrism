using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<UnityWebRequestAsyncOperationConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource Pointer
    // 018 AsyncOperation                           ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 048 Completed                                ModelPrimitiveType bool bool bool Bool
    // 050 core                                     UniTaskCompletionSourceCore`1<UnityWebRequest> IL2CPP_TYPE_GENERICINST
    // 078 continuationAction                       Action`1<AsyncOperation> IL2CPP_TYPE_GENERICINST
    public partial class UnityWebRequestAsyncOperationConfiguredSource : DataModel
    {
        public UnityWebRequestAsyncOperationConfiguredSource? NextNode                                { get; set; }
        public UnityWebRequestAsyncOperation?           AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }
        public bool                                     Completed                               { get; set; }

        public static UnityWebRequestAsyncOperationConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityWebRequestAsyncOperationConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<UnityWebRequestAsyncOperationConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityWebRequestAsyncOperationConfiguredSource.FromPointer); // 0x10 NextNode                    ( ModelClassType UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource UnityWebRequestAsyncOperationConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<UnityWebRequestAsyncOperation>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityWebRequestAsyncOperation.FromPointer); // 0x18 AsyncOperation              ( ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x030)); // 0x30 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )
            value.Completed                                 = GetBool(new IntPtr(p + 0x048)); // 0x48 Completed                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
