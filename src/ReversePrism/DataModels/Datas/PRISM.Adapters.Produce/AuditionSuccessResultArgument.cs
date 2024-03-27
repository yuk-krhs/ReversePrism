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
    // 018 ClearRank                                00018660B7E0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    // 01C ClearSecond                              0001865F4940 ModelPrimitiveType int int int Int32
    // 020 FanVariation                             000186775720 ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer
    // 028 UnitIdolCount                            0001865F4940 ModelPrimitiveType int int int Int32
    // 030 UnitParameterVariation                   0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 038 NextOrder                                00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 040 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class AuditionSuccessResultArgument
    {
        public int                                      UnitID                                  { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public ProduceClearRank                         ClearRank                               { get; set; }
        public int                                      ClearSecond                             { get; set; }
        public IFanVariationStatus?                     FanVariation                            { get; set; }
        public int                                      UnitIdolCount                           { get; set; }
        public IParameterVariationStatus?               UnitParameterVariation                  { get; set; }
        public ProduceNextOrderType                     NextOrder                               { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }

        public static AuditionSuccessResultArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionSuccessResultArgument();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D681C438 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 0270D681C458 0x14 ScheduleDetailType          ( 000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x018)); // 0270D681C478 0x18 ClearRank                   ( 00018660B7E0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D681C498 0x1C ClearSecond                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.FanVariation                              = GetObject<IFanVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IFanVariationStatus.FromPointer); // 0270D681C4B8 0x20 FanVariation                ( 000186775720 ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x028)); // 0270D681C4D8 0x28 UnitIdolCount               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UnitParameterVariation                    = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0270D681C4F8 0x30 UnitParameterVariation      ( 0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x038)); // 0270D681C518 0x38 NextOrder                   ( 00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D681C538 0x40 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
