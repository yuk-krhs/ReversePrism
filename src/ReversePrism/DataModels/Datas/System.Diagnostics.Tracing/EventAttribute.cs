using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Level                                    00018675B470 ModelEnumType EventLevel EventLevel EventLevel Int32
    // 018 Keywords                                 00018675AD10 ModelEnumType EventKeywords EventKeywords EventKeywords Int32
    // 020 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class EventAttribute
    {
        public int                                      EventId                                 { get; set; }
        public EventLevel                               Level                                   { get; set; }
        public EventKeywords                            Keywords                                { get; set; }
        public string                                   Message                                 { get; set; }

        public static EventAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventAttribute();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D6D3B0A8 0x10 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Level                                     = (EventLevel)GetInt32(new IntPtr(p + 0x014)); // 0270D6D3B0C8 0x14 Level                       ( 00018675B470 ModelEnumType EventLevel EventLevel EventLevel Int32 )
            value.Keywords                                  = (EventKeywords)GetInt32(new IntPtr(p + 0x018)); // 0270D6D3B0E8 0x18 Keywords                    ( 00018675AD10 ModelEnumType EventKeywords EventKeywords EventKeywords Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0270D6D3B108 0x20 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
