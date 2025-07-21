using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAutoPlaySettingsStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScheduleSelectionTypeFieldNumber         int IL2CPP_TYPE_I4
    // 018 ScheduleSelectionType                    ModelPrimitiveType int int int Int32
    // 000 SystemTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 01C SystemType                               ModelPrimitiveType int int int Int32
    // 000 VitalityRecoveryTimingTypeFieldNumber    int IL2CPP_TYPE_I4
    // 020 VitalityRecoveryTimingType               ModelPrimitiveType int int int Int32
    // 000 CardRankUpBalanceTypeFieldNumber         int IL2CPP_TYPE_I4
    // 024 CardRankUpBalanceType                    ModelPrimitiveType int int int Int32
    // 000 CardDeleteTypeFieldNumber                int IL2CPP_TYPE_I4
    // 028 CardDeleteType                           ModelPrimitiveType int int int Int32
    // 000 CardCostBalanceTypeFieldNumber           int IL2CPP_TYPE_I4
    // 02C CardCostBalanceType                      ModelPrimitiveType int int int Int32
    // 000 DeckPolicyTypeFieldNumber                int IL2CPP_TYPE_I4
    // 030 DeckPolicyType                           ModelPrimitiveType int int int Int32
    // 000 SubSeasonSettingListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_subSeasonSettingList_codec     FieldCodec`1<ProduceAutoPlaySubSeasonSettingStatus> IL2CPP_TYPE_GENERICINST
    // 038 SubSeasonSettingList                     ModelClassListType RepeatedField`1<ProduceAutoPlaySubSeasonSettingStatus> RepeatedField`1<ProduceAutoPlaySubSeasonSettingStatus> List<ProduceAutoPlaySubSeasonSettingStatus> Pointer
    public partial class ProduceAutoPlaySettingsStatus : DataModel
    {
        public int                                      ScheduleSelectionType                   { get; set; }
        public int                                      SystemType                              { get; set; }
        public int                                      VitalityRecoveryTimingType              { get; set; }
        public int                                      CardRankUpBalanceType                   { get; set; }
        public int                                      CardDeleteType                          { get; set; }
        public int                                      CardCostBalanceType                     { get; set; }
        public int                                      DeckPolicyType                          { get; set; }
        public List<ProduceAutoPlaySubSeasonSettingStatus>? SubSeasonSettingList                    { get; set; }

        public static ProduceAutoPlaySettingsStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoPlaySettingsStatus() { Pointer= p0 };

            value.ScheduleSelectionType                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleSelectionType       ( ModelPrimitiveType int int int Int32 )
            value.SystemType                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SystemType                  ( ModelPrimitiveType int int int Int32 )
            value.VitalityRecoveryTimingType                = GetInt32(new IntPtr(p + 0x020)); // 0x20 VitalityRecoveryTimingType  ( ModelPrimitiveType int int int Int32 )
            value.CardRankUpBalanceType                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 CardRankUpBalanceType       ( ModelPrimitiveType int int int Int32 )
            value.CardDeleteType                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 CardDeleteType              ( ModelPrimitiveType int int int Int32 )
            value.CardCostBalanceType                       = GetInt32(new IntPtr(p + 0x02C)); // 0x2C CardCostBalanceType         ( ModelPrimitiveType int int int Int32 )
            value.DeckPolicyType                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 DeckPolicyType              ( ModelPrimitiveType int int int Int32 )
            value.SubSeasonSettingList                      = GetObjectList<ProduceAutoPlaySubSeasonSettingStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceAutoPlaySubSeasonSettingStatus.FromPointer); // 0x38 SubSeasonSettingList        ( ModelClassListType RepeatedField`1<ProduceAutoPlaySubSeasonSettingStatus> RepeatedField`1<ProduceAutoPlaySubSeasonSettingStatus> List<ProduceAutoPlaySubSeasonSettingStatus> Pointer )

            return value;
        }
    }
}
