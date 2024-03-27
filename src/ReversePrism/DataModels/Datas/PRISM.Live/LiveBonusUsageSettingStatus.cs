using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LbModel                                  000186565050 ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 018 SaveData                                 00018658A720 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer
    // 020 MinUsageCount                            0001865F4260 ModelPrimitiveType int int int Int32
    // 024 MaxUsageCount                            0001865F4260 ModelPrimitiveType int int int Int32
    public partial class LiveBonusUsageSettingStatus
    {
        public StaminaModel?                            LbModel                                 { get; set; }
        public LiveUnitConfirmationSaveData?            SaveData                                { get; set; }
        public int                                      MinUsageCount                           { get; set; }
        public int                                      MaxUsageCount                           { get; set; }

        public static LiveBonusUsageSettingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveBonusUsageSettingStatus();

            value.LbModel                                   = GetObject<StaminaModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StaminaModel.FromPointer); // 0270D526DA30 0x10 LbModel                     ( 000186565050 ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.SaveData                                  = GetObject<LiveUnitConfirmationSaveData>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveUnitConfirmationSaveData.FromPointer); // 0270D526DA50 0x18 SaveData                    ( 00018658A720 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer )
            value.MinUsageCount                             = GetInt32(new IntPtr(p + 0x020)); // 0270D526DA70 0x20 MinUsageCount               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MaxUsageCount                             = GetInt32(new IntPtr(p + 0x024)); // 0270D526DA90 0x24 MaxUsageCount               ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
