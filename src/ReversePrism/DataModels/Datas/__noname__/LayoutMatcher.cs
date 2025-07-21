using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LayoutName                               ModelEnumType InternedString InternedString InternedString Int32
    // 020 DeviceMatcher                            ModelEnumType InputDeviceMatcher InputDeviceMatcher InputDeviceMatcher Int32
    public partial class LayoutMatcher : DataModel
    {
        public InternedString                           LayoutName                              { get; set; }
        public InputDeviceMatcher                       DeviceMatcher                           { get; set; }

        public static LayoutMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutMatcher() { Pointer= p0 };

            value.LayoutName                                = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 0x10 LayoutName                  ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.DeviceMatcher                             = (InputDeviceMatcher)GetInt32(new IntPtr(p + 0x020)); // 0x20 DeviceMatcher               ( ModelEnumType InputDeviceMatcher InputDeviceMatcher InputDeviceMatcher Int32 )

            return value;
        }
    }
}
