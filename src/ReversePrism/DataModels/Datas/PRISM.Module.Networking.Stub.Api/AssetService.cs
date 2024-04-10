using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetAssetVersionArgs     Marshaller`1<GetAssetVersionArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetAssetVersionReply    Marshaller`1<GetAssetVersionReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_GetAssetVersion                 Method`2<GetAssetVersionArgs, GetAssetVersionReply> IL2CPP_TYPE_GENERICINST
    public partial class AssetService : DataModel
    {

        public static AssetService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetService() { Pointer= p0 };


            return value;
        }
    }
}
