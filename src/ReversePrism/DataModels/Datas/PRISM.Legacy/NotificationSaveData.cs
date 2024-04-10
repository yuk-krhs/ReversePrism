using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StaminaNotificationId                    0001866722E0 ModelPrimitiveType string string string String
    // 028 LiveBonusNotificationId                  0001866722E0 ModelPrimitiveType string string string String
    // 030 DailyMissionNotificationId               0001866722E0 ModelPrimitiveType string string string String
    // 038 DailyMissionNotificationDay              0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 UserBirthdayNotificationId               0001866722E0 ModelPrimitiveType string string string String
    // 048 ComebackNotificationId                   0001866722E0 ModelPrimitiveType string string string String
    public partial class NotificationSaveData : DataModel
    {
        public string                                   StaminaNotificationId                   { get; set; }
        public string                                   LiveBonusNotificationId                 { get; set; }
        public string                                   DailyMissionNotificationId              { get; set; }
        public int                                      DailyMissionNotificationDay             { get; set; }
        public string                                   UserBirthdayNotificationId              { get; set; }
        public string                                   ComebackNotificationId                  { get; set; }

        public static NotificationSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationSaveData() { Pointer= p0 };

            value.StaminaNotificationId                     = GetString(new IntPtr(p + 0x020)); // 0245A3A7F960 0x20 StaminaNotificationId       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LiveBonusNotificationId                   = GetString(new IntPtr(p + 0x028)); // 0245A3A7F980 0x28 LiveBonusNotificationId     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DailyMissionNotificationId                = GetString(new IntPtr(p + 0x030)); // 0245A3A7F9A0 0x30 DailyMissionNotificationId  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DailyMissionNotificationDay               = GetInt32(new IntPtr(p + 0x038)); // 0245A3A7F9C0 0x38 DailyMissionNotificationDay ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UserBirthdayNotificationId                = GetString(new IntPtr(p + 0x040)); // 0245A3A7F9E0 0x40 UserBirthdayNotificationId  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ComebackNotificationId                    = GetString(new IntPtr(p + 0x048)); // 0245A3A7FA00 0x48 ComebackNotificationId      ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
