using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WantsMouseMove                           ModelPrimitiveType bool bool bool Bool
    // 011 WantsMouseEnterLeaveWindow               ModelPrimitiveType bool bool bool Bool
    // 012 WantsLessLayoutEvents                    ModelPrimitiveType bool bool bool Bool
    public partial class EventInterests : DataModel
    {
        public bool                                     WantsMouseMove                          { get; set; }
        public bool                                     WantsMouseEnterLeaveWindow              { get; set; }
        public bool                                     WantsLessLayoutEvents                   { get; set; }

        public static EventInterests? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventInterests() { Pointer= p0 };

            value.WantsMouseMove                            = GetBool(new IntPtr(p + 0x010)); // 0x10 WantsMouseMove              ( ModelPrimitiveType bool bool bool Bool )
            value.WantsMouseEnterLeaveWindow                = GetBool(new IntPtr(p + 0x011)); // 0x11 WantsMouseEnterLeaveWindow  ( ModelPrimitiveType bool bool bool Bool )
            value.WantsLessLayoutEvents                     = GetBool(new IntPtr(p + 0x012)); // 0x12 WantsLessLayoutEvents       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
