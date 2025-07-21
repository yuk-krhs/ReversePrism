using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 loadingKeys                              HashSet`1<ulong> IL2CPP_TYPE_GENERICINST
    // 018 objectCache                              Dictionary`2<ulong, Object> IL2CPP_TYPE_GENERICINST
    public partial class AssetContainer : DataModel
    {

        public static AssetContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetContainer() { Pointer= p0 };


            return value;
        }
    }
}
