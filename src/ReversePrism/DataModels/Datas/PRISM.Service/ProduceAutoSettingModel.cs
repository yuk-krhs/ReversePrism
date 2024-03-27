using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleSelection                        0001865C7930 ModelEnumType ScheduleSelectionType ScheduleSelectionType ScheduleSelectionType Int32
    // 014 System                                   0001865C80A0 ModelEnumType SystemType SystemType SystemType Int32
    // 018 RecoveryTiming                           0001865C7210 ModelEnumType RecoveryTimingType RecoveryTimingType RecoveryTimingType Int32
    // 01C RankUpBalance                            0001865C6AC0 ModelEnumType RankUpBalanceType RankUpBalanceType RankUpBalanceType Int32
    // 020 CardDelete                               0001865C5CA0 ModelEnumType CardDeleteType CardDeleteType CardDeleteType Int32
    // 024 CardCostBalance                          0001865C5580 ModelEnumType CardCostBalanceType CardCostBalanceType CardCostBalanceType Int32
    // 028 DeckPolicy                               0001865C63B0 ModelEnumType DeckPolicyType DeckPolicyType DeckPolicyType Int32
    public partial class ProduceAutoSettingModel
    {
        public ScheduleSelectionType                    ScheduleSelection                       { get; set; }
        public SystemType                               System                                  { get; set; }
        public RecoveryTimingType                       RecoveryTiming                          { get; set; }
        public RankUpBalanceType                        RankUpBalance                           { get; set; }
        public CardDeleteType                           CardDelete                              { get; set; }
        public CardCostBalanceType                      CardCostBalance                         { get; set; }
        public DeckPolicyType                           DeckPolicy                              { get; set; }

        public static ProduceAutoSettingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoSettingModel();

            value.ScheduleSelection                         = (ScheduleSelectionType)GetInt32(new IntPtr(p + 0x010)); // 027003A6E460 0x10 ScheduleSelection           ( 0001865C7930 ModelEnumType ScheduleSelectionType ScheduleSelectionType ScheduleSelectionType Int32 )
            value.System                                    = (SystemType)GetInt32(new IntPtr(p + 0x014)); // 027003A6E480 0x14 System                      ( 0001865C80A0 ModelEnumType SystemType SystemType SystemType Int32 )
            value.RecoveryTiming                            = (RecoveryTimingType)GetInt32(new IntPtr(p + 0x018)); // 027003A6E4A0 0x18 RecoveryTiming              ( 0001865C7210 ModelEnumType RecoveryTimingType RecoveryTimingType RecoveryTimingType Int32 )
            value.RankUpBalance                             = (RankUpBalanceType)GetInt32(new IntPtr(p + 0x01C)); // 027003A6E4C0 0x1C RankUpBalance               ( 0001865C6AC0 ModelEnumType RankUpBalanceType RankUpBalanceType RankUpBalanceType Int32 )
            value.CardDelete                                = (CardDeleteType)GetInt32(new IntPtr(p + 0x020)); // 027003A6E4E0 0x20 CardDelete                  ( 0001865C5CA0 ModelEnumType CardDeleteType CardDeleteType CardDeleteType Int32 )
            value.CardCostBalance                           = (CardCostBalanceType)GetInt32(new IntPtr(p + 0x024)); // 027003A6E500 0x24 CardCostBalance             ( 0001865C5580 ModelEnumType CardCostBalanceType CardCostBalanceType CardCostBalanceType Int32 )
            value.DeckPolicy                                = (DeckPolicyType)GetInt32(new IntPtr(p + 0x028)); // 027003A6E520 0x28 DeckPolicy                  ( 0001865C63B0 ModelEnumType DeckPolicyType DeckPolicyType DeckPolicyType Int32 )

            return value;
        }
    }
}
