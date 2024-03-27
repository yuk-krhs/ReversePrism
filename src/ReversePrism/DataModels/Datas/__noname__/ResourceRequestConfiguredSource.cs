using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<ResourceRequestConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671E870 ModelClassType ResourceRequestConfiguredSource ResourceRequestConfiguredSource ResourceRequestConfiguredSource Pointer
    // 018 AsyncOperation                           000186671E40 ModelClassType ResourceRequest ResourceRequest ResourceRequest Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<Object> IL2CPP_TYPE_GENERICINST
    public partial class ResourceRequestConfiguredSource
    {
        public ResourceRequestConfiguredSource?         NextNode                                { get; set; }
        public ResourceRequest?                         AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static ResourceRequestConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceRequestConfiguredSource();

            value.NextNode                                  = GetObject<ResourceRequestConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceRequestConfiguredSource.FromPointer); // 0270D8F8A448 0x10 NextNode                    ( 00018671E870 ModelClassType ResourceRequestConfiguredSource ResourceRequestConfiguredSource ResourceRequestConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<ResourceRequest>(new IntPtr(p + 0x018), ReversePrism.DataModels.ResourceRequest.FromPointer); // 0270D8F8A468 0x18 AsyncOperation              ( 000186671E40 ModelClassType ResourceRequest ResourceRequest ResourceRequest Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0270D8F8A4A8 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
