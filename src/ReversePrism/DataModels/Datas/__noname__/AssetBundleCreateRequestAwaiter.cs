using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AsyncOperation                           0001866E39D0 ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer
    // 018 continuationAction                       Action`1<AsyncOperation> IL2CPP_TYPE_GENERICINST
    public partial class AssetBundleCreateRequestAwaiter : DataModel
    {
        public AssetBundleCreateRequest?                AsyncOperation                          { get; set; }

        public static AssetBundleCreateRequestAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetBundleCreateRequestAwaiter() { Pointer= p0 };

            value.AsyncOperation                            = GetObject<AssetBundleCreateRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundleCreateRequest.FromPointer); // 0246690012A0 0x10 AsyncOperation              ( 0001866E39D0 ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer )

            return value;
        }
    }
}
