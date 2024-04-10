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
    // 018 ScheduleSelectionType                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SystemTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 01C SystemType                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VitalityRecoveryTimingTypeFieldNumber    int IL2CPP_TYPE_I4
    // 020 VitalityRecoveryTimingType               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardRankUpBalanceTypeFieldNumber         int IL2CPP_TYPE_I4
    // 024 CardRankUpBalanceType                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardDeleteTypeFieldNumber                int IL2CPP_TYPE_I4
    // 028 CardDeleteType                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardCostBalanceTypeFieldNumber           int IL2CPP_TYPE_I4
    // 02C CardCostBalanceType                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DeckPolicyTypeFieldNumber                int IL2CPP_TYPE_I4
    // 030 DeckPolicyType                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceAutoPlaySettingsStatus : DataModel
    {
        public int                                      ScheduleSelectionType                   { get; set; }
        public int                                      SystemType                              { get; set; }
        public int                                      VitalityRecoveryTimingType              { get; set; }
        public int                                      CardRankUpBalanceType                   { get; set; }
        public int                                      CardDeleteType                          { get; set; }
        public int                                      CardCostBalanceType                     { get; set; }
        public int                                      DeckPolicyType                          { get; set; }

        public static ProduceAutoPlaySettingsStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoPlaySettingsStatus() { Pointer= p0 };

            value.ScheduleSelectionType                     = GetInt32(new IntPtr(p + 0x018)); // 024661091428 0x18 ScheduleSelectionType       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SystemType                                = GetInt32(new IntPtr(p + 0x01C)); // 024661091468 0x1C SystemType                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VitalityRecoveryTimingType                = GetInt32(new IntPtr(p + 0x020)); // 0246610914A8 0x20 VitalityRecoveryTimingType  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardRankUpBalanceType                     = GetInt32(new IntPtr(p + 0x024)); // 0246610914E8 0x24 CardRankUpBalanceType       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardDeleteType                            = GetInt32(new IntPtr(p + 0x028)); // 024661091528 0x28 CardDeleteType              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardCostBalanceType                       = GetInt32(new IntPtr(p + 0x02C)); // 024661091568 0x2C CardCostBalanceType         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DeckPolicyType                            = GetInt32(new IntPtr(p + 0x030)); // 0246610915A8 0x30 DeckPolicyType              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
