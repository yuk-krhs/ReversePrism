using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DEFAULT_DRIVE                            string IL2CPP_TYPE_STRING
    public partial class DiskUtils : DataModel
    {

        public static DiskUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiskUtils() { Pointer= p0 };


            return value;
        }
    }
}
