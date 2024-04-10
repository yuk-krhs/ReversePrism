using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AssetBundleRequestAllAssetsConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671CB20 ModelClassType AssetBundleRequestAllAssetsConfiguredSource AssetBundleRequestAllAssetsConfiguredSource AssetBundleRequestAllAssetsConfiguredSource Pointer
    // 018 AsyncOperation                           0001866E4080 ModelClassType AssetBundleRequest AssetBundleRequest AssetBundleRequest Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<Object[]> IL2CPP_TYPE_GENERICINST
    public partial class AssetBundleRequestAllAssetsConfiguredSource : DataModel
    {
        public AssetBundleRequestAllAssetsConfiguredSource? NextNode                                { get; set; }
        public AssetBundleRequest?                      AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static AssetBundleRequestAllAssetsConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetBundleRequestAllAssetsConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<AssetBundleRequestAllAssetsConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundleRequestAllAssetsConfiguredSource.FromPointer); // 024668FEB6C8 0x10 NextNode                    ( 00018671CB20 ModelClassType AssetBundleRequestAllAssetsConfiguredSource AssetBundleRequestAllAssetsConfiguredSource AssetBundleRequestAllAssetsConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<AssetBundleRequest>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetBundleRequest.FromPointer); // 024668FEB6E8 0x18 AsyncOperation              ( 0001866E4080 ModelClassType AssetBundleRequest AssetBundleRequest AssetBundleRequest Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 024668FEB728 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
