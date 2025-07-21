using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LbModel                                  ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 018 SaveData                                 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer
    // 020 MinUsageCount                            ModelPrimitiveType int int int Int32
    // 024 MaxUsageCount                            ModelPrimitiveType int int int Int32
    public partial class LiveBonusUsageSettingStatus : DataModel
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
            var value   = new LiveBonusUsageSettingStatus() { Pointer= p0 };

            value.LbModel                                   = GetObject<StaminaModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StaminaModel.FromPointer); // 0x10 LbModel                     ( ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.SaveData                                  = GetObject<LiveUnitConfirmationSaveData>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveUnitConfirmationSaveData.FromPointer); // 0x18 SaveData                    ( ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer )
            value.MinUsageCount                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 MinUsageCount               ( ModelPrimitiveType int int int Int32 )
            value.MaxUsageCount                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 MaxUsageCount               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
