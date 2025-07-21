using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StaminaNotificationId                    ModelPrimitiveType string string string String
    // 028 LiveBonusNotificationId                  ModelPrimitiveType string string string String
    // 030 DailyMissionNotificationId               ModelPrimitiveType string string string String
    // 038 DailyMissionNotificationDay              ModelPrimitiveType int int int Int32
    // 040 UserBirthdayNotificationId               ModelPrimitiveType string string string String
    // 048 ComebackNotificationId                   ModelPrimitiveType string string string String
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

            value.StaminaNotificationId                     = GetString(new IntPtr(p + 0x020)); // 0x20 StaminaNotificationId       ( ModelPrimitiveType string string string String )
            value.LiveBonusNotificationId                   = GetString(new IntPtr(p + 0x028)); // 0x28 LiveBonusNotificationId     ( ModelPrimitiveType string string string String )
            value.DailyMissionNotificationId                = GetString(new IntPtr(p + 0x030)); // 0x30 DailyMissionNotificationId  ( ModelPrimitiveType string string string String )
            value.DailyMissionNotificationDay               = GetInt32(new IntPtr(p + 0x038)); // 0x38 DailyMissionNotificationDay ( ModelPrimitiveType int int int Int32 )
            value.UserBirthdayNotificationId                = GetString(new IntPtr(p + 0x040)); // 0x40 UserBirthdayNotificationId  ( ModelPrimitiveType string string string String )
            value.ComebackNotificationId                    = GetString(new IntPtr(p + 0x048)); // 0x48 ComebackNotificationId      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
