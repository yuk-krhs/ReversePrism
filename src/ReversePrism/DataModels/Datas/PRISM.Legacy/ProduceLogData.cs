using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType LogItemType LogItemType LogItemType Int32
    // 018 Info                                     ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 ProducePolicyId                          ModelPrimitiveType int int int Int32
    // 024 ProducePolicyTypeId                      ModelPrimitiveType int int int Int32
    // 028 Season                                   ModelPrimitiveType int int int Int32
    // 02C ScheduleType                             ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 030 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 034 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 038 ClearRank                                ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    // 03C IsExistChallengeMission                  ModelPrimitiveType bool bool bool Bool
    // 03D IsClearChallengeMission                  ModelPrimitiveType bool bool bool Bool
    // 040 IdolId                                   ModelPrimitiveType int int int Int32
    // 048 ScenarioId                               ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 050 ScenarioSelectNo                         ModelPrimitiveType int int int Int32
    // 054 IsSupportBonus                           ModelPrimitiveType bool bool bool Bool
    // 055 IsSupportChara                           ModelPrimitiveType bool bool bool Bool
    // 056 IsTrouble                                ModelPrimitiveType bool bool bool Bool
    // 058 VitalityVariation                        ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer
    // 060 FanVariation                             ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer
    // 068 ScheduleVariation                        ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer
    // 070 IdolParamVariation                       ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 078 UnitParamVariation                       ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 080 ExertSupportEffectList                   ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    // 088 IsExistGetProduceCard                    ModelPrimitiveType bool bool bool Bool
    // 090 GetProduceCards                          ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 IsExistDeleteProduceCard                 ModelPrimitiveType bool bool bool Bool
    // 0A0 DeleteProduceCards                       ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 0A8 RankUpProduceCardIds                     ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 0B0 IsExistGetSupportSkill                   ModelPrimitiveType bool bool bool Bool
    // 0B8 GetSupportSkillList                      ModelClassListType IReadOnlyList`1<ISelectionSupportSkillStatus> IReadOnlyList`1<ISelectionSupportSkillStatus> List<ISelectionSupportSkillStatus> Pointer
    // 0C0 IsInheritanceSkill                       ModelPrimitiveType bool bool bool Bool
    // 0C8 DeckList                                 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    public partial class ProduceLogData : DataModel
    {
        public LogItemType                              Type                                    { get; set; }
        public IProduceBaseInfoStatus?                  Info                                    { get; set; }
        public int                                      ProducePolicyId                         { get; set; }
        public int                                      ProducePolicyTypeId                     { get; set; }
        public int                                      Season                                  { get; set; }
        public ScheduleType                             ScheduleType                            { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public ProduceClearRank                         ClearRank                               { get; set; }
        public bool                                     IsExistChallengeMission                 { get; set; }
        public bool                                     IsClearChallengeMission                 { get; set; }
        public int                                      IdolId                                  { get; set; }
        public ScenarioID?                              ScenarioId                              { get; set; }
        public int                                      ScenarioSelectNo                        { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public bool                                     IsSupportChara                          { get; set; }
        public bool                                     IsTrouble                               { get; set; }
        public IVitalityVariationStatus?                VitalityVariation                       { get; set; }
        public IFanVariationStatus?                     FanVariation                            { get; set; }
        public IScheduleVariationStatus?                ScheduleVariation                       { get; set; }
        public IParameterVariationStatus?               IdolParamVariation                      { get; set; }
        public IParameterVariationStatus?               UnitParamVariation                      { get; set; }
        public List<IExertSupportEffectStatus>?         ExertSupportEffectList                  { get; set; }
        public bool                                     IsExistGetProduceCard                   { get; set; }
        public List<IProduceCardStatus>?                GetProduceCards                         { get; set; }
        public bool                                     IsExistDeleteProduceCard                { get; set; }
        public List<IProduceCardStatus>?                DeleteProduceCards                      { get; set; }
        public List<string>?                            RankUpProduceCardIds                    { get; set; }
        public bool                                     IsExistGetSupportSkill                  { get; set; }
        public List<ISelectionSupportSkillStatus>?      GetSupportSkillList                     { get; set; }
        public bool                                     IsInheritanceSkill                      { get; set; }
        public List<IProduceCardStatus>?                DeckList                                { get; set; }

        public static ProduceLogData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceLogData() { Pointer= p0 };

            value.Type                                      = (LogItemType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType LogItemType LogItemType LogItemType Int32 )
            value.Info                                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x18 Info                        ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ProducePolicyId                           = GetInt32(new IntPtr(p + 0x020)); // 0x20 ProducePolicyId             ( ModelPrimitiveType int int int Int32 )
            value.ProducePolicyTypeId                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 ProducePolicyTypeId         ( ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Season                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C ScheduleType                ( ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x034)); // 0x34 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x038)); // 0x38 ClearRank                   ( ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )
            value.IsExistChallengeMission                   = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsExistChallengeMission     ( ModelPrimitiveType bool bool bool Bool )
            value.IsClearChallengeMission                   = GetBool(new IntPtr(p + 0x03D)); // 0x3D IsClearChallengeMission     ( ModelPrimitiveType bool bool bool Bool )
            value.IdolId                                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 IdolId                      ( ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x48 ScenarioId                  ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.ScenarioSelectNo                          = GetInt32(new IntPtr(p + 0x050)); // 0x50 ScenarioSelectNo            ( ModelPrimitiveType int int int Int32 )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x054)); // 0x54 IsSupportBonus              ( ModelPrimitiveType bool bool bool Bool )
            value.IsSupportChara                            = GetBool(new IntPtr(p + 0x055)); // 0x55 IsSupportChara              ( ModelPrimitiveType bool bool bool Bool )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x056)); // 0x56 IsTrouble                   ( ModelPrimitiveType bool bool bool Bool )
            value.VitalityVariation                         = GetObject<IVitalityVariationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IVitalityVariationStatus.FromPointer); // 0x58 VitalityVariation           ( ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer )
            value.FanVariation                              = GetObject<IFanVariationStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IFanVariationStatus.FromPointer); // 0x60 FanVariation                ( ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer )
            value.ScheduleVariation                         = GetObject<IScheduleVariationStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IScheduleVariationStatus.FromPointer); // 0x68 ScheduleVariation           ( ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer )
            value.IdolParamVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x70 IdolParamVariation          ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.UnitParamVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x78 UnitParamVariation          ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 0x80 ExertSupportEffectList      ( ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )
            value.IsExistGetProduceCard                     = GetBool(new IntPtr(p + 0x088)); // 0x88 IsExistGetProduceCard       ( ModelPrimitiveType bool bool bool Bool )
            value.GetProduceCards                           = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x90 GetProduceCards             ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.IsExistDeleteProduceCard                  = GetBool(new IntPtr(p + 0x098)); // 0x98 IsExistDeleteProduceCard    ( ModelPrimitiveType bool bool bool Bool )
            value.DeleteProduceCards                        = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0xA0 DeleteProduceCards          ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.RankUpProduceCardIds                      = GetStringList(new IntPtr(p + 0x0A8)); // 0xA8 RankUpProduceCardIds        ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.IsExistGetSupportSkill                    = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsExistGetSupportSkill      ( ModelPrimitiveType bool bool bool Bool )
            value.GetSupportSkillList                       = GetObjectList<ISelectionSupportSkillStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ISelectionSupportSkillStatus.FromPointer); // 0xB8 GetSupportSkillList         ( ModelClassListType IReadOnlyList`1<ISelectionSupportSkillStatus> IReadOnlyList`1<ISelectionSupportSkillStatus> List<ISelectionSupportSkillStatus> Pointer )
            value.IsInheritanceSkill                        = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 IsInheritanceSkill          ( ModelPrimitiveType bool bool bool Bool )
            value.DeckList                                  = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0xC8 DeckList                    ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
