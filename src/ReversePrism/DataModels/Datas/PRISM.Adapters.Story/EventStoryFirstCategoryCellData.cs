using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  ModelPrimitiveType int int int Int32
    // 014 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 015 IsUnread                                 ModelPrimitiveType bool bool bool Bool
    // 018 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 EndDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class EventStoryFirstCategoryCellData : DataModel
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
            var value   = new EventStoryFirstCategoryCellData() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x014)); // 0x14 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x015)); // 0x15 IsUnread                    ( ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x018)); // 0x18 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
