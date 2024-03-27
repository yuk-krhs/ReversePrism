using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 014 ScheduleDetailType                       000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 018 ScheduleLevel                            0001865F4940 ModelPrimitiveType int int int Int32
    // 01C ProduceProgress                          0001865F4940 ModelPrimitiveType int int int Int32
    // 020 ProduceProgressMax                       0001865F4940 ModelPrimitiveType int int int Int32
    // 028 Rewards                                  000185D07738 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 030 CharacterIds                             000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 038 IdolBaseRewards                          000185CFD1E8 ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer
    // 040 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 048 NextOrder                                00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    public partial class ProduceFailureResultArgument
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
            var value   = new ProduceFailureResultArgument();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D681E3D8 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 0270D681E3F8 0x14 ScheduleDetailType          ( 000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0270D681E418 0x18 ScheduleLevel               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceProgress                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D681E438 0x1C ProduceProgress             ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceProgressMax                        = GetInt32(new IntPtr(p + 0x020)); // 0270D681E458 0x20 ProduceProgressMax          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Rewards                                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D681E478 0x28 Rewards                     ( 000185D07738 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x030)); // 0270D681E498 0x30 CharacterIds                ( 000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IdolBaseRewards                           = GetObjectList<IIdolBaseRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0270D681E4B8 0x38 IdolBaseRewards             ( 000185CFD1E8 ModelClassListType IReadOnlyList`1<IIdolBaseRewardStatus> IReadOnlyList`1<IIdolBaseRewardStatus> List<IIdolBaseRewardStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D681E4D8 0x40 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x048)); // 0270D681E4F8 0x48 NextOrder                   ( 00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )

            return value;
        }
    }
}
