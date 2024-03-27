using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reply                                    0001865E7030 ModelClassType IProduceFailureResultReply IProduceFailureResultReply IProduceFailureResultReply Pointer
    // 018 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 01C ScheduleDetailType                       000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 020 ScheduleLevel                            0001865F4940 ModelPrimitiveType int int int Int32
    // 024 ProduceProgress                          0001865F4940 ModelPrimitiveType int int int Int32
    // 028 ProduceProgressMax                       0001865F4940 ModelPrimitiveType int int int Int32
    // 030 Rewards                                  000185D07738 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 038 CharacterIds                             000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 040 IdolBaseRewards                          000185CFD1E8 ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer
    // 048 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 050 NextOrder                                00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    public partial class LegacyProduceFailureResultParameter
    {
        public IProduceFailureResultReply?              Reply                                   { get; set; }
        public int                                      UnitID                                  { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public int                                      ProduceProgress                         { get; set; }
        public int                                      ProduceProgressMax                      { get; set; }
        public List<IProductWithAmountStatus>?          Rewards                                 { get; set; }
        public List<int>?                               CharacterIds                            { get; set; }
        public List<IIdolBaseRewardStatus>?             IdolBaseRewards                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public ProduceNextOrderType                     NextOrder                               { get; set; }

        public static LegacyProduceFailureResultParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyProduceFailureResultParameter();

            value.Reply                                     = GetObject<IProduceFailureResultReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceFailureResultReply.FromPointer); // 0270D55D6EE0 0x10 Reply                       ( 0001865E7030 ModelClassType IProduceFailureResultReply IProduceFailureResultReply IProduceFailureResultReply Pointer )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D55D6F00 0x18 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x01C)); // 0270D55D6F20 0x1C ScheduleDetailType          ( 000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x020)); // 0270D55D6F40 0x20 ScheduleLevel               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceProgress                           = GetInt32(new IntPtr(p + 0x024)); // 0270D55D6F60 0x24 ProduceProgress             ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceProgressMax                        = GetInt32(new IntPtr(p + 0x028)); // 0270D55D6F80 0x28 ProduceProgressMax          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Rewards                                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D55D6FA0 0x30 Rewards                     ( 000185D07738 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x038)); // 0270D55D6FC0 0x38 CharacterIds                ( 000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IdolBaseRewards                           = GetObjectList<IIdolBaseRewardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0270D55D6FE0 0x40 IdolBaseRewards             ( 000185CFD1E8 ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D55D7000 0x48 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x050)); // 0270D55D7020 0x50 NextOrder                   ( 00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )

            return value;
        }
    }
}
