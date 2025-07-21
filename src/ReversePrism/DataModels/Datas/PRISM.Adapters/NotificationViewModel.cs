using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Notification                             ModelClassType IHomeNotificationStatus IHomeNotificationStatus IHomeNotificationStatus Pointer
    // 018 BadgeViewModel                           ModelClassType BadgeViewModel BadgeViewModel BadgeViewModel Pointer
    // 020 EventIconViewModel                       ModelClassType EventIconViewModel EventIconViewModel EventIconViewModel Pointer
    // 028 ButtonBadgeType                          ModelEnumType ButtonBadgeType ButtonBadgeType ButtonBadgeType Int32
    public partial class NotificationViewModel : DataModel
    {
        public IHomeNotificationStatus?                 Notification                            { get; set; }
        public BadgeViewModel?                          BadgeViewModel                          { get; set; }
        public EventIconViewModel?                      EventIconViewModel                      { get; set; }
        public ButtonBadgeType                          ButtonBadgeType                         { get; set; }

        public static NotificationViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationViewModel() { Pointer= p0 };

            value.Notification                              = GetObject<IHomeNotificationStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeNotificationStatus.FromPointer); // 0x10 Notification                ( ModelClassType IHomeNotificationStatus IHomeNotificationStatus IHomeNotificationStatus Pointer )
            value.BadgeViewModel                            = GetObject<BadgeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.BadgeViewModel.FromPointer); // 0x18 BadgeViewModel              ( ModelClassType BadgeViewModel BadgeViewModel BadgeViewModel Pointer )
            value.EventIconViewModel                        = GetObject<EventIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventIconViewModel.FromPointer); // 0x20 EventIconViewModel          ( ModelClassType EventIconViewModel EventIconViewModel EventIconViewModel Pointer )
            value.ButtonBadgeType                           = (ButtonBadgeType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ButtonBadgeType             ( ModelEnumType ButtonBadgeType ButtonBadgeType ButtonBadgeType Int32 )

            return value;
        }
    }
}
