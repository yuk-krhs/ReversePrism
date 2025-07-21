using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 6C8 IsLateLatchEnabled                       ModelPrimitiveType bool bool bool Bool
    // 6C9 CanMarkLateLatch                         ModelPrimitiveType bool bool bool Bool
    // 6CA HasMarkedLateLatch                       ModelPrimitiveType bool bool bool Bool
    public partial class XRPassUniversal : DataModel
    {
        public bool                                     IsLateLatchEnabled                      { get; set; }
        public bool                                     CanMarkLateLatch                        { get; set; }
        public bool                                     HasMarkedLateLatch                      { get; set; }

        public static XRPassUniversal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRPassUniversal() { Pointer= p0 };

            value.IsLateLatchEnabled                        = GetBool(new IntPtr(p + 0x6C8)); // 0x6C8 IsLateLatchEnabled          ( ModelPrimitiveType bool bool bool Bool )
            value.CanMarkLateLatch                          = GetBool(new IntPtr(p + 0x6C9)); // 0x6C9 CanMarkLateLatch            ( ModelPrimitiveType bool bool bool Bool )
            value.HasMarkedLateLatch                        = GetBool(new IntPtr(p + 0x6CA)); // 0x6CA HasMarkedLateLatch          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
