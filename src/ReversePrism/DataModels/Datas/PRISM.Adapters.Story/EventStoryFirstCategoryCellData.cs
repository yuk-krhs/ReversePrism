using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 014 IsNew                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 015 IsUnread                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 BeginDate                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 EndDate                                  0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class EventStoryFirstCategoryCellData
    {
        public int                                      EventId                                 { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static EventStoryFirstCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryFirstCategoryCellData();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D67E1CF0 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x014)); // 0270D67E1D10 0x14 IsNew                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x015)); // 0270D67E1D30 0x15 IsUnread                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x018)); // 0270D67E1D50 0x18 BeginDate                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D67E1D70 0x20 EndDate                     ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
