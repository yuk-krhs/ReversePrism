using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LayoutName                               0001865FE620 ModelEnumType InternedString InternedString InternedString Int32
    // 020 DeviceMatcher                            0001865EE090 ModelEnumType InputDeviceMatcher InputDeviceMatcher InputDeviceMatcher Int32
    public partial class LayoutMatcher
    {
        public InternedString                           LayoutName                              { get; set; }
        public InputDeviceMatcher                       DeviceMatcher                           { get; set; }

        public static LayoutMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutMatcher();

            value.LayoutName                                = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 027002E5D8B0 0x10 LayoutName                  ( 0001865FE620 ModelEnumType InternedString InternedString InternedString Int32 )
            value.DeviceMatcher                             = (InputDeviceMatcher)GetInt32(new IntPtr(p + 0x020)); // 027002E5D8D0 0x20 DeviceMatcher               ( 0001865EE090 ModelEnumType InputDeviceMatcher InputDeviceMatcher InputDeviceMatcher Int32 )

            return value;
        }
    }
}
