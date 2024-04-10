using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AssetBundleCreateRequestConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671C380 ModelClassType AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource Pointer
    // 018 AsyncOperation                           0001866E39D0 ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<AssetBundle> IL2CPP_TYPE_GENERICINST
    public partial class AssetBundleCreateRequestConfiguredSource : DataModel
    {
        public AssetBundleCreateRequestConfiguredSource? NextNode                                { get; set; }
        public AssetBundleCreateRequest?                AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static AssetBundleCreateRequestConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetBundleCreateRequestConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<AssetBundleCreateRequestConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundleCreateRequestConfiguredSource.FromPointer); // 024669001B18 0x10 NextNode                    ( 00018671C380 ModelClassType AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource AssetBundleCreateRequestConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<AssetBundleCreateRequest>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetBundleCreateRequest.FromPointer); // 024669001B38 0x18 AsyncOperation              ( 0001866E39D0 ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 024669001B78 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
