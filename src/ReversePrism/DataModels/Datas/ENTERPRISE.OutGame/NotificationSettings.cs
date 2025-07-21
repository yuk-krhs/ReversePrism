using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 StaminaRecoveryButton                    ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 038 LiveBonusRecoveryButton                  ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 040 MissionNotClearButton                    ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 048 NotMidnightNotificationButton            ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 050 SettingsResetButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 058 _NotificationSettings                    ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer
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

            value.StaminaRecoveryButton                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x30 StaminaRecoveryButton       ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.LiveBonusRecoveryButton                   = GetObject<ToggleSwitch>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x38 LiveBonusRecoveryButton     ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.MissionNotClearButton                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x40 MissionNotClearButton       ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.NotMidnightNotificationButton             = GetObject<ToggleSwitch>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x48 NotMidnightNotificationButton ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.SettingsResetButton                       = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 SettingsResetButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value._NotificationSettings                     = GetObject<NotificationSettingsSaveData>(new IntPtr(p + 0x058), ReversePrism.DataModels.NotificationSettingsSaveData.FromPointer); // 0x58 _NotificationSettings       ( ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer )

            return value;
        }
    }
}
