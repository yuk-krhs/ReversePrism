using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SaveData                                 00018658A200 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer
    // 018 LiveBonusUsageSettingStatus              0001866A88D0 ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer
    // 020 RemainingCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AutoLiveStatus
    {
        public LiveUnitConfirmationSaveData?            SaveData                                { get; set; }
        public NormalLiveLiveBonusUsageSettingStatus?   LiveBonusUsageSettingStatus             { get; set; }
        public int                                      RemainingCount                          { get; set; }

        public static AutoLiveStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoLiveStatus();

            value.SaveData                                  = GetObject<LiveUnitConfirmationSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveUnitConfirmationSaveData.FromPointer); // 0270D526D4D0 0x10 SaveData                    ( 00018658A200 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer )
            value.LiveBonusUsageSettingStatus               = GetObject<NormalLiveLiveBonusUsageSettingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.NormalLiveLiveBonusUsageSettingStatus.FromPointer); // 0270D526D4F0 0x18 LiveBonusUsageSettingStatus ( 0001866A88D0 ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer )
            value.RemainingCount                            = GetInt32(new IntPtr(p + 0x020)); // 0270D526D510 0x20 RemainingCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
