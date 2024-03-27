using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AsyncOperation                           0001866E4080 ModelClassType AssetBundleRequest AssetBundleRequest AssetBundleRequest Pointer
    // 018 continuationAction                       Action`1<AsyncOperation> IL2CPP_TYPE_GENERICINST
    public partial class AssetBundleRequestAwaiter
    {
        public AssetBundleRequest?                      AsyncOperation                          { get; set; }

        public static AssetBundleRequestAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetBundleRequestAwaiter();

            value.AsyncOperation                            = GetObject<AssetBundleRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundleRequest.FromPointer); // 0270D8F8B1C0 0x10 AsyncOperation              ( 0001866E4080 ModelClassType AssetBundleRequest AssetBundleRequest AssetBundleRequest Pointer )

            return value;
        }
    }
}
