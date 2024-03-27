using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsStaminaRecoveryNotification            000186595960 ModelPrimitiveType bool bool bool Bool
    // 021 IsLiveBonusRecoveryNotification          000186595960 ModelPrimitiveType bool bool bool Bool
    // 022 IsMissionNotClearNotification            000186595960 ModelPrimitiveType bool bool bool Bool
    // 023 IsNotMidnightNotification                000186595960 ModelPrimitiveType bool bool bool Bool
    // 024 IsContinuousLaunch                       000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class NotificationSettingsSaveData
    {
        public bool                                     IsStaminaRecoveryNotification           { get; set; }
        public bool                                     IsLiveBonusRecoveryNotification         { get; set; }
        public bool                                     IsMissionNotClearNotification           { get; set; }
        public bool                                     IsNotMidnightNotification               { get; set; }
        public bool                                     IsContinuousLaunch                      { get; set; }

        public static NotificationSettingsSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationSettingsSaveData();

            value.IsStaminaRecoveryNotification             = GetBool(new IntPtr(p + 0x020)); // 027003A74C10 0x20 IsStaminaRecoveryNotification ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsLiveBonusRecoveryNotification           = GetBool(new IntPtr(p + 0x021)); // 027003A74C30 0x21 IsLiveBonusRecoveryNotification ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsMissionNotClearNotification             = GetBool(new IntPtr(p + 0x022)); // 027003A74C50 0x22 IsMissionNotClearNotification ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNotMidnightNotification                 = GetBool(new IntPtr(p + 0x023)); // 027003A74C70 0x23 IsNotMidnightNotification   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsContinuousLaunch                        = GetBool(new IntPtr(p + 0x024)); // 027003A74C90 0x24 IsContinuousLaunch          ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
