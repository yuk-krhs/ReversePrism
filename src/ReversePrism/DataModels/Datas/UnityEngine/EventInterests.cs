using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WantsMouseMove                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 WantsMouseEnterLeaveWindow               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 012 WantsLessLayoutEvents                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EventInterests
    {
        public bool                                     WantsMouseMove                          { get; set; }
        public bool                                     WantsMouseEnterLeaveWindow              { get; set; }
        public bool                                     WantsLessLayoutEvents                   { get; set; }

        public static EventInterests? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventInterests();

            value.WantsMouseMove                            = GetBool(new IntPtr(p + 0x010)); // 027003E9F368 0x10 WantsMouseMove              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WantsMouseEnterLeaveWindow                = GetBool(new IntPtr(p + 0x011)); // 027003E9F388 0x11 WantsMouseEnterLeaveWindow  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WantsLessLayoutEvents                     = GetBool(new IntPtr(p + 0x012)); // 027003E9F3A8 0x12 WantsLessLayoutEvents       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
