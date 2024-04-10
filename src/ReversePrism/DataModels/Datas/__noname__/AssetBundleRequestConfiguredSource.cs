using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<AssetBundleRequestConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 00018671D1E0 ModelClassType AssetBundleRequestConfiguredSource AssetBundleRequestConfiguredSource AssetBundleRequestConfiguredSource Pointer
    // 018 AsyncOperation                           0001866E4080 ModelClassType AssetBundleRequest AssetBundleRequest AssetBundleRequest Pointer
    // 020 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 core                                     UniTaskCompletionSourceCore`1<Object> IL2CPP_TYPE_GENERICINST
    public partial class AssetBundleRequestConfiguredSource : DataModel
    {
        public AssetBundleRequestConfiguredSource?      NextNode                                { get; set; }
        public AssetBundleRequest?                      AsyncOperation                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static AssetBundleRequestConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetBundleRequestConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<AssetBundleRequestConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundleRequestConfiguredSource.FromPointer); // 024669000D70 0x10 NextNode                    ( 00018671D1E0 ModelClassType AssetBundleRequestConfiguredSource AssetBundleRequestConfiguredSource AssetBundleRequestConfiguredSource Pointer )
            value.AsyncOperation                            = GetObject<AssetBundleRequest>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetBundleRequest.FromPointer); // 024669000D90 0x18 AsyncOperation              ( 0001866E4080 ModelClassType AssetBundleRequest AssetBundleRequest AssetBundleRequest Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 024669000DD0 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
