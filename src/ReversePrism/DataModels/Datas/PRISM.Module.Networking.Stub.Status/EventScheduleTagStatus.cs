using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventScheduleTagStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TagIdFieldNumber                         int IL2CPP_TYPE_I4
    // 018 TagId                                    000186671910 ModelPrimitiveType string string string String
    // 000 TagNameFieldNumber                       int IL2CPP_TYPE_I4
    // 020 TagName                                  000186671910 ModelPrimitiveType string string string String
    // 000 BodyColorCodeFieldNumber                 int IL2CPP_TYPE_I4
    // 028 BodyColorCode                            000186671910 ModelPrimitiveType string string string String
    // 000 TextColorCodeFieldNumber                 int IL2CPP_TYPE_I4
    // 030 TextColorCode                            000186671910 ModelPrimitiveType string string string String
    public partial class EventScheduleTagStatus
    {
        public string                                   TagId                                   { get; set; }
        public string                                   TagName                                 { get; set; }
        public string                                   BodyColorCode                           { get; set; }
        public string                                   TextColorCode                           { get; set; }

        public static EventScheduleTagStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleTagStatus();

            value.TagId                                     = GetString(new IntPtr(p + 0x018)); // 0270D108F290 0x18 TagId                       ( 000186671910 ModelPrimitiveType string string string String )
            value.TagName                                   = GetString(new IntPtr(p + 0x020)); // 0270D108F2D0 0x20 TagName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.BodyColorCode                             = GetString(new IntPtr(p + 0x028)); // 0270D108F310 0x28 BodyColorCode               ( 000186671910 ModelPrimitiveType string string string String )
            value.TextColorCode                             = GetString(new IntPtr(p + 0x030)); // 0270D108F350 0x30 TextColorCode               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
