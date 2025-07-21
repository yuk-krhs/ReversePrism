using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleSelection                        ModelEnumType ScheduleSelectionType ScheduleSelectionType ScheduleSelectionType Int32
    // 014 System                                   ModelEnumType SystemType SystemType SystemType Int32
    // 018 RecoveryTiming                           ModelEnumType RecoveryTimingType RecoveryTimingType RecoveryTimingType Int32
    // 01C RankUpBalance                            ModelEnumType RankUpBalanceType RankUpBalanceType RankUpBalanceType Int32
    // 020 CardDelete                               ModelEnumType CardDeleteType CardDeleteType CardDeleteType Int32
    // 024 CardCostBalance                          ModelEnumType CardCostBalanceType CardCostBalanceType CardCostBalanceType Int32
    // 028 DeckPolicy                               ModelEnumType DeckPolicyType DeckPolicyType DeckPolicyType Int32
    // 030 SelectSubSeasonDictionary                Dictionary`2<ValueTuple`2<int, int>, ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 038 SelectSubSeasonDatas                     ModelClassListType SelectSubSeasonData[] SelectSubSeasonData[] List<SelectSubSeasonData> Pointer
    public partial class ProduceAutoSettingModel : DataModel
    {
        public ScheduleSelectionType                    ScheduleSelection                       { get; set; }
        public SystemType                               System                                  { get; set; }
        public RecoveryTimingType                       RecoveryTiming                          { get; set; }
        public RankUpBalanceType                        RankUpBalance                           { get; set; }
        public CardDeleteType                           CardDelete                              { get; set; }
        public CardCostBalanceType                      CardCostBalance                         { get; set; }
        public DeckPolicyType                           DeckPolicy                              { get; set; }
        public List<SelectSubSeasonData>?               SelectSubSeasonDatas                    { get; set; }

        public static ProduceAutoSettingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoSettingModel() { Pointer= p0 };

            value.ScheduleSelection                         = (ScheduleSelectionType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScheduleSelection           ( ModelEnumType ScheduleSelectionType ScheduleSelectionType ScheduleSelectionType Int32 )
            value.System                                    = (SystemType)GetInt32(new IntPtr(p + 0x014)); // 0x14 System                      ( ModelEnumType SystemType SystemType SystemType Int32 )
            value.RecoveryTiming                            = (RecoveryTimingType)GetInt32(new IntPtr(p + 0x018)); // 0x18 RecoveryTiming              ( ModelEnumType RecoveryTimingType RecoveryTimingType RecoveryTimingType Int32 )
            value.RankUpBalance                             = (RankUpBalanceType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C RankUpBalance               ( ModelEnumType RankUpBalanceType RankUpBalanceType RankUpBalanceType Int32 )
            value.CardDelete                                = (CardDeleteType)GetInt32(new IntPtr(p + 0x020)); // 0x20 CardDelete                  ( ModelEnumType CardDeleteType CardDeleteType CardDeleteType Int32 )
            value.CardCostBalance                           = (CardCostBalanceType)GetInt32(new IntPtr(p + 0x024)); // 0x24 CardCostBalance             ( ModelEnumType CardCostBalanceType CardCostBalanceType CardCostBalanceType Int32 )
            value.DeckPolicy                                = (DeckPolicyType)GetInt32(new IntPtr(p + 0x028)); // 0x28 DeckPolicy                  ( ModelEnumType DeckPolicyType DeckPolicyType DeckPolicyType Int32 )
            value.SelectSubSeasonDatas                      = GetObjectList<SelectSubSeasonData>(new IntPtr(p + 0x038), ReversePrism.DataModels.SelectSubSeasonData.FromPointer); // 0x38 SelectSubSeasonDatas        ( ModelClassListType SelectSubSeasonData[] SelectSubSeasonData[] List<SelectSubSeasonData> Pointer )

            return value;
        }
    }
}
