using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 StaminaRecoveryButton                    0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 038 LiveBonusRecoveryButton                  0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 040 MissionNotClearButton                    0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 048 NotMidnightNotificationButton            0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 050 SettingsResetButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 _NotificationSettings                    0001866B5110 ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer
    public partial class NotificationSettings : DataModel
    {
        public ToggleSwitch?                            StaminaRecoveryButton                   { get; set; }
        public ToggleSwitch?                            LiveBonusRecoveryButton                 { get; set; }
        public ToggleSwitch?                            MissionNotClearButton                   { get; set; }
        public ToggleSwitch?                            NotMidnightNotificationButton           { get; set; }
        public UIButton?                                SettingsResetButton                     { get; set; }
        public NotificationSettingsSaveData?            _NotificationSettings                   { get; set; }

        public static NotificationSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationSettings() { Pointer= p0 };

            value.StaminaRecoveryButton                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 024664C6ABD8 0x30 StaminaRecoveryButton       ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.LiveBonusRecoveryButton                   = GetObject<ToggleSwitch>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 024664C6ABF8 0x38 LiveBonusRecoveryButton     ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.MissionNotClearButton                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 024664C6AC18 0x40 MissionNotClearButton       ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.NotMidnightNotificationButton             = GetObject<ToggleSwitch>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 024664C6AC38 0x48 NotMidnightNotificationButton ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.SettingsResetButton                       = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 024664C6AC58 0x50 SettingsResetButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value._NotificationSettings                     = GetObject<NotificationSettingsSaveData>(new IntPtr(p + 0x058), ReversePrism.DataModels.NotificationSettingsSaveData.FromPointer); // 024664C6AC78 0x58 _NotificationSettings       ( 0001866B5110 ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer )

            return value;
        }
    }
}
