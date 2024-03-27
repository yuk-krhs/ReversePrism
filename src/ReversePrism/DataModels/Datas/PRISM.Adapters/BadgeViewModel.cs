using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Notification                             00018656A590 ModelClassType IHomeNotificationStatus IHomeNotificationStatus IHomeNotificationStatus Pointer
    // 018 IsCircleBadge                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 IsBuleCircleBadge                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BadgeViewModel
    {
        public IHomeNotificationStatus?                 Notification                            { get; set; }
        public bool                                     IsCircleBadge                           { get; set; }
        public bool                                     IsBuleCircleBadge                       { get; set; }

        public static BadgeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeViewModel();

            value.Notification                              = GetObject<IHomeNotificationStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeNotificationStatus.FromPointer); // 0270D327EF10 0x10 Notification                ( 00018656A590 ModelClassType IHomeNotificationStatus IHomeNotificationStatus IHomeNotificationStatus Pointer )
            value.IsCircleBadge                             = GetBool(new IntPtr(p + 0x018)); // 0270D327EF30 0x18 IsCircleBadge               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsBuleCircleBadge                         = GetBool(new IntPtr(p + 0x019)); // 0270D327EF50 0x19 IsBuleCircleBadge           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
