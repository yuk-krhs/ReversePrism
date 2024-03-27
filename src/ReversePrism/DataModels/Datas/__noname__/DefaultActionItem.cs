using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 callback                                 Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 020 state                                    <object> IL2CPP_TYPE_OBJECT
    // 028 FlowLegacyActivityId                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C ActivityId                               0001865DBED0 ModelEnumType Guid Guid Guid Int32
    // 040 EventTraceActivity                       00018676C8E0 ModelClassType EventTraceActivity EventTraceActivity EventTraceActivity Pointer
    public partial class DefaultActionItem
    {
        public bool                                     FlowLegacyActivityId                    { get; set; }
        public Guid                                     ActivityId                              { get; set; }
        public EventTraceActivity?                      EventTraceActivity                      { get; set; }

        public static DefaultActionItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultActionItem();

            value.FlowLegacyActivityId                      = GetBool(new IntPtr(p + 0x028)); // 0270DBA29968 0x28 FlowLegacyActivityId        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActivityId                                = (Guid)GetInt32(new IntPtr(p + 0x02C)); // 0270DBA29988 0x2C ActivityId                  ( 0001865DBED0 ModelEnumType Guid Guid Guid Int32 )
            value.EventTraceActivity                        = GetObject<EventTraceActivity>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventTraceActivity.FromPointer); // 0270DBA299A8 0x40 EventTraceActivity          ( 00018676C8E0 ModelClassType EventTraceActivity EventTraceActivity EventTraceActivity Pointer )

            return value;
        }
    }
}
