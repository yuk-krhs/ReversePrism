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
    // 01C GetAppealPoint                           0001865F4940 ModelPrimitiveType int int int Int32
    // 020 TargetAppealPoint                        0001865F4940 ModelPrimitiveType int int int Int32
    // 028 AppealPointMilestones                    IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 030 UnitIdolCount                            0001865F4940 ModelPrimitiveType int int int Int32
    // 038 UnitParameterVariation                   0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 040 IsUnitParameterUp                        000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 044 NextOrder                                00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 048 RankUpCount                              0001865F4940 ModelPrimitiveType int int int Int32
    // 050 DeckProduceCards                         IEnumerable`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 058 ScheduleVariation                        000186628820 ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer
    // 060 ProduceBaseInfo                          0001865E3840 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 068 ExertSupportEffectList                   000185CE3508 ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    // 070 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class SpecialLessonResultArgument : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public int                                      GetAppealPoint                          { get; set; }
        public int                                      TargetAppealPoint                       { get; set; }
        public int                                      UnitIdolCount                           { get; set; }
        public IParameterVariationStatus?               UnitParameterVariation                  { get; set; }
        public bool                                     IsUnitParameterUp                       { get; set; }
        public ProduceNextOrderType                     NextOrder                               { get; set; }
        public int                                      RankUpCount                             { get; set; }
        public IScheduleVariationStatus?                ScheduleVariation                       { get; set; }
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public List<IExertSupportEffectStatus>?         ExertSupportEffectList                  { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }

        public static SpecialLessonResultArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLessonResultArgument() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 02466689C678 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 02466689C698 0x14 ScheduleDetailType          ( 000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 02466689C6B8 0x18 ScheduleLevel               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.GetAppealPoint                            = GetInt32(new IntPtr(p + 0x01C)); // 02466689C6D8 0x1C GetAppealPoint              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.TargetAppealPoint                         = GetInt32(new IntPtr(p + 0x020)); // 02466689C6F8 0x20 TargetAppealPoint           ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x030)); // 02466689C738 0x30 UnitIdolCount               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UnitParameterVariation                    = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 02466689C758 0x38 UnitParameterVariation      ( 0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.IsUnitParameterUp                         = GetBool(new IntPtr(p + 0x040)); // 02466689C778 0x40 IsUnitParameterUp           ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x044)); // 02466689C798 0x44 NextOrder                   ( 00018660D1D0 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.RankUpCount                               = GetInt32(new IntPtr(p + 0x048)); // 02466689C7B8 0x48 RankUpCount                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ScheduleVariation                         = GetObject<IScheduleVariationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IScheduleVariationStatus.FromPointer); // 02466689C7F8 0x58 ScheduleVariation           ( 000186628820 ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 02466689C818 0x60 ProduceBaseInfo             ( 0001865E3840 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 02466689C838 0x68 ExertSupportEffectList      ( 000185CE3508 ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x070), ReversePrism.DataModels.UnitIdol.FromPointer); // 02466689C858 0x70 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
