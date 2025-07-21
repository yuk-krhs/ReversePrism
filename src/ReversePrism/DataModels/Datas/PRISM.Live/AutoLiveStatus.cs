using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SaveData                                 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer
    // 018 LiveBonusUsageSettingStatus              ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer
    // 020 RemainingCount                           ModelPrimitiveType int int int Int32
    public partial class AutoLiveStatus : DataModel
    {
        public LiveUnitConfirmationSaveData?            SaveData                                { get; set; }
        public NormalLiveLiveBonusUsageSettingStatus?   LiveBonusUsageSettingStatus             { get; set; }
        public int                                      RemainingCount                          { get; set; }

        public static AutoLiveStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoLiveStatus() { Pointer= p0 };

            value.SaveData                                  = GetObject<LiveUnitConfirmationSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveUnitConfirmationSaveData.FromPointer); // 0x10 SaveData                    ( ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer )
            value.LiveBonusUsageSettingStatus               = GetObject<NormalLiveLiveBonusUsageSettingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.NormalLiveLiveBonusUsageSettingStatus.FromPointer); // 0x18 LiveBonusUsageSettingStatus ( ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer )
            value.RemainingCount                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 RemainingCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
