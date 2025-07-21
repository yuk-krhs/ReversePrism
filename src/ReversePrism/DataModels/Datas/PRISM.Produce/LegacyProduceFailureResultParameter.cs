using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reply                                    ModelClassType IProduceFailureResultReply IProduceFailureResultReply IProduceFailureResultReply Pointer
    // 018 UnitID                                   ModelPrimitiveType int int int Int32
    // 01C ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 020 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 024 ProduceProgress                          ModelPrimitiveType int int int Int32
    // 028 ProduceProgressMax                       ModelPrimitiveType int int int Int32
    // 030 Rewards                                  ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 038 CharacterIds                             ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 040 IdolBaseRewards                          ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer
    // 048 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 050 NextOrder                                ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    public partial class LegacyProduceFailureResultParameter : DataModel
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
            var value   = new LegacyProduceFailureResultParameter() { Pointer= p0 };

            value.Reply                                     = GetObject<IProduceFailureResultReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceFailureResultReply.FromPointer); // 0x10 Reply                       ( ModelClassType IProduceFailureResultReply IProduceFailureResultReply IProduceFailureResultReply Pointer )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.ProduceProgress                           = GetInt32(new IntPtr(p + 0x024)); // 0x24 ProduceProgress             ( ModelPrimitiveType int int int Int32 )
            value.ProduceProgressMax                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 ProduceProgressMax          ( ModelPrimitiveType int int int Int32 )
            value.Rewards                                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x30 Rewards                     ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x038)); // 0x38 CharacterIds                ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IdolBaseRewards                           = GetObjectList<IIdolBaseRewardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0x40 IdolBaseRewards             ( ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x48 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x050)); // 0x50 NextOrder                   ( ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )

            return value;
        }
    }
}
