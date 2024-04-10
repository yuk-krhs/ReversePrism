using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Cache                                    Dictionary`2<Type, EnumCacheInfo> IL2CPP_TYPE_GENERICINST
    public partial class EnumCache : DataModel
    {

        public static EnumCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumCache() { Pointer= p0 };


            return value;
        }
    }
}
