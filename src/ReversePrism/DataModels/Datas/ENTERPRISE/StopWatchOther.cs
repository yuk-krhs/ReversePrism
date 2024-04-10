using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConstructedTimeFromApplicationLaunched   0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class StopWatchOther : DataModel
    {
        public DateTime                                 ConstructedTimeFromApplicationLaunched  { get; set; }

        public static StopWatchOther? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StopWatchOther() { Pointer= p0 };

            value.ConstructedTimeFromApplicationLaunched    = GetDateTime(new IntPtr(p + 0x010)); // 024660EBD520 0x10 ConstructedTimeFromApplicationLaunched ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
