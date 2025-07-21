using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AssetBundleCreateRequestConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource Pointer
    // 018 AsyncOperation                           ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 CancellationTokenRegistration            ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 048 Completed                                ModelPrimitiveType bool bool bool Bool
    // 050 core                                     UniTaskCompletionSourceCore`1<AssetBundle> IL2CPP_TYPE_GENERICINST
    // 078 continuationAction                       Action`1<AsyncOperation> IL2CPP_TYPE_GENERICINST
    public partial class AssetBundleCreateRequestConfiguredSource : DataModel
    {
        public AssetBundleCreateRequestConfiguredSource? NextNode                                { get; set; }
        public AssetBundleCreateRequest?                AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationTokenRegistration           { get; set; }
        public bool                                     Completed                               { get; set; }

        public static AssetBundleCreateRequestConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetBundleCreateRequestConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<AssetBundleCreateRequestConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundleCreateRequestConfiguredSource.FromPointer); // 0x10 NextNode                    ( ModelClassType AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<AssetBundleCreateRequest>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetBundleCreateRequest.FromPointer); // 0x18 AsyncOperation              ( ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationTokenRegistration             = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x030)); // 0x30 CancellationTokenRegistration ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )
            value.Completed                                 = GetBool(new IntPtr(p + 0x048)); // 0x48 Completed                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
