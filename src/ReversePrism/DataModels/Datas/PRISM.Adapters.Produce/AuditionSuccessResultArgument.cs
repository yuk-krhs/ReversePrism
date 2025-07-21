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
    // 018 ClearRank                                ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    // 01C ClearSecond                              ModelPrimitiveType int int int Int32
    // 020 FanVariation                             ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer
    // 028 UnitIdolCount                            ModelPrimitiveType int int int Int32
    // 030 UnitParameterVariation                   ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 038 NextOrder                                ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 040 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class AuditionSuccessResultArgument : DataModel
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
            var value   = new AuditionSuccessResultArgument() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x018)); // 0x18 ClearRank                   ( ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ClearSecond                 ( ModelPrimitiveType int int int Int32 )
            value.FanVariation                              = GetObject<IFanVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IFanVariationStatus.FromPointer); // 0x20 FanVariation                ( ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnitIdolCount               ( ModelPrimitiveType int int int Int32 )
            value.UnitParameterVariation                    = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x30 UnitParameterVariation      ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x038)); // 0x38 NextOrder                   ( ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x40 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
