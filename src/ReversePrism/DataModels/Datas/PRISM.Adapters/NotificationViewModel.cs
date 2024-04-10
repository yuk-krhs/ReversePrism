using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Notification                             00018656A2D0 ModelClassType IHomeNotificationStatus IHomeNotificationStatus IHomeNotificationStatus Pointer
    // 018 BadgeViewModel                           0001867389C0 ModelClassType BadgeViewModel BadgeViewModel BadgeViewModel Pointer
    // 020 EventIconViewModel                       000186759390 ModelClassType EventIconViewModel EventIconViewModel EventIconViewModel Pointer
    // 028 ButtonBadgeType                          000186515030 ModelEnumType ButtonBadgeType ButtonBadgeType ButtonBadgeType Int32
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

            value.Notification                              = GetObject<IHomeNotificationStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeNotificationStatus.FromPointer); // 0245A5B43F48 0x10 Notification                ( 00018656A2D0 ModelClassType IHomeNotificationStatus IHomeNotificationStatus IHomeNotificationStatus Pointer )
            value.BadgeViewModel                            = GetObject<BadgeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.BadgeViewModel.FromPointer); // 0245A5B43F68 0x18 BadgeViewModel              ( 0001867389C0 ModelClassType BadgeViewModel BadgeViewModel BadgeViewModel Pointer )
            value.EventIconViewModel                        = GetObject<EventIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventIconViewModel.FromPointer); // 0245A5B43F88 0x20 EventIconViewModel          ( 000186759390 ModelClassType EventIconViewModel EventIconViewModel EventIconViewModel Pointer )
            value.ButtonBadgeType                           = (ButtonBadgeType)GetInt32(new IntPtr(p + 0x028)); // 0245A5B43FA8 0x28 ButtonBadgeType             ( 000186515030 ModelEnumType ButtonBadgeType ButtonBadgeType ButtonBadgeType Int32 )

            return value;
        }
    }
}
