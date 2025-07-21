using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <isXRMobile>k__BackingField              bool IL2CPP_TYPE_BOOLEAN
    public partial class PlatformAutoDetect : DataModel
    {

        public static PlatformAutoDetect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlatformAutoDetect() { Pointer= p0 };


            return value;
        }
    }
}
