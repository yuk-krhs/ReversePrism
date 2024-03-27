using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AsyncOperationConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671E0C0 ModelClassType AsyncOperationConfiguredSource AsyncOperationConfiguredSource AsyncOperationConfiguredSource Pointer
    // 018 AsyncOperation                           0001866FAA20 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class AsyncOperationConfiguredSource
    {
        public AsyncOperationConfiguredSource?          NextNode                                { get; set; }
        public AsyncOperation?                          AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static AsyncOperationConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncOperationConfiguredSource();

            value.NextNode                                  = GetObject<AsyncOperationConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncOperationConfiguredSource.FromPointer); // 027003F86E38 0x10 NextNode                    ( 00018671E0C0 ModelClassType AsyncOperationConfiguredSource AsyncOperationConfiguredSource AsyncOperationConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<AsyncOperation>(new IntPtr(p + 0x018), ReversePrism.DataModels.AsyncOperation.FromPointer); // 027003F86E58 0x18 AsyncOperation              ( 0001866FAA20 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 027003F86E98 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
