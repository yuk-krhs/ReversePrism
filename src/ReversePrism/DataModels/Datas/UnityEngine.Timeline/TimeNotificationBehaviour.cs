using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Notifications                          ModelEnumListType List`1<NotificationEntry> List`1<NotificationEntry> List<NotificationEntry> Pointer
    // 018 M_PreviousTime                           ModelPrimitiveType double double double Double
    // 020 M_NeedSortNotifications                  ModelPrimitiveType bool bool bool Bool
    // 028 M_TimeSource                             ModelEnumType Playable Playable Playable Int32
    public partial class TimeNotificationBehaviour : DataModel
    {
        public List<NotificationEntry>?                 M_Notifications                         { get; set; }
        public double                                   M_PreviousTime                          { get; set; }
        public bool                                     M_NeedSortNotifications                 { get; set; }
        public Playable                                 M_TimeSource                            { get; set; }

        public static TimeNotificationBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeNotificationBehaviour() { Pointer= p0 };

            value.M_Notifications                           = GetEnumList<NotificationEntry>(new IntPtr(p + 0x010)); // 0x10 M_Notifications             ( ModelEnumListType List`1<NotificationEntry> List`1<NotificationEntry> List<NotificationEntry> Pointer )
            value.M_PreviousTime                            = GetDouble(new IntPtr(p + 0x018)); // 0x18 M_PreviousTime              ( ModelPrimitiveType double double double Double )
            value.M_NeedSortNotifications                   = GetBool(new IntPtr(p + 0x020)); // 0x20 M_NeedSortNotifications     ( ModelPrimitiveType bool bool bool Bool )
            value.M_TimeSource                              = (Playable)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_TimeSource                ( ModelEnumType Playable Playable Playable Int32 )

            return value;
        }
    }
}
