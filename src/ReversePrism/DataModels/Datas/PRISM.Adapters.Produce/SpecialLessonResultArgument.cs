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
    // 01C GetAppealPoint                           ModelPrimitiveType int int int Int32
    // 020 TargetAppealPoint                        ModelPrimitiveType int int int Int32
    // 028 AppealPointMilestones                    IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 030 UnitIdolCount                            ModelPrimitiveType int int int Int32
    // 038 UnitParameterVariation                   ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 040 IsUnitParameterUp                        ModelPrimitiveType bool bool bool Bool
    // 044 NextOrder                                ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 048 RankUpCount                              ModelPrimitiveType int int int Int32
    // 050 DeckProduceCards                         ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 058 ScheduleVariation                        ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer
    // 060 ProduceBaseInfo                          ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 068 ExertSupportEffectList                   ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    // 070 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
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
        public List<IProduceCardStatus>?                DeckProduceCards                        { get; set; }
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

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.GetAppealPoint                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C GetAppealPoint              ( ModelPrimitiveType int int int Int32 )
            value.TargetAppealPoint                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 TargetAppealPoint           ( ModelPrimitiveType int int int Int32 )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 UnitIdolCount               ( ModelPrimitiveType int int int Int32 )
            value.UnitParameterVariation                    = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x38 UnitParameterVariation      ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.IsUnitParameterUp                         = GetBool(new IntPtr(p + 0x040)); // 0x40 IsUnitParameterUp           ( ModelPrimitiveType bool bool bool Bool )
            value.NextOrder                                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x044)); // 0x44 NextOrder                   ( ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.RankUpCount                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 RankUpCount                 ( ModelPrimitiveType int int int Int32 )
            value.DeckProduceCards                          = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x50 DeckProduceCards            ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.ScheduleVariation                         = GetObject<IScheduleVariationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IScheduleVariationStatus.FromPointer); // 0x58 ScheduleVariation           ( ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x60 ProduceBaseInfo             ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 0x68 ExertSupportEffectList      ( ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x070), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x70 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
