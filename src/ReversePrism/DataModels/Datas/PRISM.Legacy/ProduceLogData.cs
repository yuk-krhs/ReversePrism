using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001865D6D40 ModelEnumType LogItemType LogItemType LogItemType Int32
    // 018 Info                                     0001865E3190 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 ProducePolicyId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 ProducePolicyTypeId                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Season                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C ScheduleType                             0001866160F0 ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 030 ScheduleDetailType                       000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 034 ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 ClearRank                                00018660B5B0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    // 03C IsExistChallengeMission                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03D IsClearChallengeMission                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 IdolId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 ScenarioId                               0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 050 ScenarioSelectNo                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 IsSupportBonus                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 055 IsSupportChara                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 056 IsTrouble                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 VitalityVariation                        0001866986D0 ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer
    // 060 FanVariation                             0001867754D0 ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer
    // 068 ScheduleVariation                        0001866285D0 ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer
    // 070 IdolParamVariation                       0001865D2450 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 078 UnitParamVariation                       0001865D2450 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 080 ExertSupportEffectList                   000185CE34A8 ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    // 088 IsExistGetProduceCard                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 090 GetProduceCards                          000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 IsExistDeleteProduceCard                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A0 DeleteProduceCards                       000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 0A8 RankUpProduceCardIds                     000185D16FD8 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 0B0 IsExistGetSupportSkill                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B8 GetSupportSkill                          000186633B70 ModelClassType ISelectionSupportSkillStatus ISelectionSupportSkillStatus ISelectionSupportSkillStatus Pointer
    // 0C0 IsInheritanceSkill                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceLogData
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
        public ISelectionSupportSkillStatus?            GetSupportSkill                         { get; set; }
        public bool                                     IsInheritanceSkill                      { get; set; }

        public static ProduceLogData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceLogData();

            value.Type                                      = (LogItemType)GetInt32(new IntPtr(p + 0x010)); // 027004B083E8 0x10 Type                        ( 0001865D6D40 ModelEnumType LogItemType LogItemType LogItemType Int32 )
            value.Info                                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 027004B08408 0x18 Info                        ( 0001865E3190 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ProducePolicyId                           = GetInt32(new IntPtr(p + 0x020)); // 027004B08428 0x20 ProducePolicyId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProducePolicyTypeId                       = GetInt32(new IntPtr(p + 0x024)); // 027004B08448 0x24 ProducePolicyTypeId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x028)); // 027004B08468 0x28 Season                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x02C)); // 027004B08488 0x2C ScheduleType                ( 0001866160F0 ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 027004B084A8 0x30 ScheduleDetailType          ( 000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x034)); // 027004B084C8 0x34 ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x038)); // 027004B084E8 0x38 ClearRank                   ( 00018660B5B0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )
            value.IsExistChallengeMission                   = GetBool(new IntPtr(p + 0x03C)); // 027004B08508 0x3C IsExistChallengeMission     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsClearChallengeMission                   = GetBool(new IntPtr(p + 0x03D)); // 027004B08528 0x3D IsClearChallengeMission     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IdolId                                    = GetInt32(new IntPtr(p + 0x040)); // 027004B08548 0x40 IdolId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScenarioID.FromPointer); // 027004B08568 0x48 ScenarioId                  ( 0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.ScenarioSelectNo                          = GetInt32(new IntPtr(p + 0x050)); // 027004B08588 0x50 ScenarioSelectNo            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x054)); // 027004B085A8 0x54 IsSupportBonus              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSupportChara                            = GetBool(new IntPtr(p + 0x055)); // 027004B085C8 0x55 IsSupportChara              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x056)); // 027004B085E8 0x56 IsTrouble                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.VitalityVariation                         = GetObject<IVitalityVariationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IVitalityVariationStatus.FromPointer); // 027004B08608 0x58 VitalityVariation           ( 0001866986D0 ModelClassType IVitalityVariationStatus IVitalityVariationStatus IVitalityVariationStatus Pointer )
            value.FanVariation                              = GetObject<IFanVariationStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IFanVariationStatus.FromPointer); // 027004B08628 0x60 FanVariation                ( 0001867754D0 ModelClassType IFanVariationStatus IFanVariationStatus IFanVariationStatus Pointer )
            value.ScheduleVariation                         = GetObject<IScheduleVariationStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IScheduleVariationStatus.FromPointer); // 027004B08648 0x68 ScheduleVariation           ( 0001866285D0 ModelClassType IScheduleVariationStatus IScheduleVariationStatus IScheduleVariationStatus Pointer )
            value.IdolParamVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 027004B08668 0x70 IdolParamVariation          ( 0001865D2450 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.UnitParamVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 027004B08688 0x78 UnitParamVariation          ( 0001865D2450 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 027004B086A8 0x80 ExertSupportEffectList      ( 000185CE34A8 ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )
            value.IsExistGetProduceCard                     = GetBool(new IntPtr(p + 0x088)); // 027004B086C8 0x88 IsExistGetProduceCard       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.GetProduceCards                           = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 027004B086E8 0x90 GetProduceCards             ( 000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.IsExistDeleteProduceCard                  = GetBool(new IntPtr(p + 0x098)); // 027004B08708 0x98 IsExistDeleteProduceCard    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DeleteProduceCards                        = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 027004B08728 0xA0 DeleteProduceCards          ( 000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.RankUpProduceCardIds                      = GetStringList(new IntPtr(p + 0x0A8)); // 027004B08748 0xA8 RankUpProduceCardIds        ( 000185D16FD8 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.IsExistGetSupportSkill                    = GetBool(new IntPtr(p + 0x0B0)); // 027004B08768 0xB0 IsExistGetSupportSkill      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.GetSupportSkill                           = GetObject<ISelectionSupportSkillStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ISelectionSupportSkillStatus.FromPointer); // 027004B08788 0xB8 GetSupportSkill             ( 000186633B70 ModelClassType ISelectionSupportSkillStatus ISelectionSupportSkillStatus ISelectionSupportSkillStatus Pointer )
            value.IsInheritanceSkill                        = GetBool(new IntPtr(p + 0x0C0)); // 027004B087A8 0xC0 IsInheritanceSkill          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
