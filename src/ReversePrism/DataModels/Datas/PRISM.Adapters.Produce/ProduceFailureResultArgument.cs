using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   ModelPrimitiveType int int int Int32
    // 014 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 018 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 01C ProduceProgress                          ModelPrimitiveType int int int Int32
    // 020 ProduceProgressMax                       ModelPrimitiveType int int int Int32
    // 028 Rewards                                  ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 030 CharacterIds                             ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 038 IdolBaseRewards                          ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer
    // 040 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 048 NextOrder                                ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    public partial class ProduceFailureResultArgument : DataModel
    {
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

        public static ProduceFailureResultArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultArgument() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.ProduceProgress                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ProduceProgress             ( ModelPrimitiveType int int int Int32 )
            value.ProduceProgressMax                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 ProduceProgressMax          ( ModelPrimitiveType int int int Int32 )
            value.Rewards                                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x28 Rewards                     ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x030)); // 0x30 CharacterIds                ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IdolBaseRewards                           = GetObjectList<IIdolBaseRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0x38 IdolBaseRewards             ( ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x40 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x048)); // 0x48 NextOrder                   ( ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )

            return value;
        }
    }
}
