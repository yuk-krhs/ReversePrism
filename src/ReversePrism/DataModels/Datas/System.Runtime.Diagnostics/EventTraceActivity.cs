using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActivityId                               0001865DC380 ModelEnumType Guid Guid Guid Int32
    public partial class EventTraceActivity : DataModel
    {
        public Guid                                     ActivityId                              { get; set; }

        public static EventTraceActivity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventTraceActivity() { Pointer= p0 };

            value.ActivityId                                = (Guid)GetInt32(new IntPtr(p + 0x010)); // 024667E2D7B0 0x10 ActivityId                  ( 0001865DC380 ModelEnumType Guid Guid Guid Int32 )

            return value;
        }
    }
}
