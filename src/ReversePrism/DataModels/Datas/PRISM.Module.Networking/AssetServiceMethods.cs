using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetAssetVersion                          Method`2<IGetAssetVersionArgs, IGetAssetVersionReply> IL2CPP_TYPE_GENERICINST
    public partial class AssetServiceMethods : DataModel
    {

        public static AssetServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
