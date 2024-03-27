using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 bottomTypeRP                             ReactiveProperty`1<Bottom> IL2CPP_TYPE_GENERICINST
    // 048 TrainingDisplayPermit                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 MasterTrainingDisplayPermit              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 IconId                                   000186671910 ModelPrimitiveType string string string String
    // 058 Rarity                                   00018661FD00 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 05C GoodSchedule                             000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 060 Diamond                                  0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 068 CharaLv                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C MasterTrainingLv                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 Slot                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 SupportEffectPassiveEffects              000185D10CF8 ModelClassListType List`1<SupportEffectPassiveEffect> List`1<SupportEffectPassiveEffect> List<SupportEffectPassiveEffect> Pointer
    // 080 CanTraining                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 081 CanMasterTraining                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 PotentialSupportSkillGroupIdList         000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class SCharaIcon
    {
        public bool                                     TrainingDisplayPermit                   { get; set; }
        public bool                                     MasterTrainingDisplayPermit             { get; set; }
        public string                                   IconId                                  { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public ScheduleDetailType                       GoodSchedule                            { get; set; }
        public ILimitedValueStatus?                     Diamond                                 { get; set; }
        public int                                      CharaLv                                 { get; set; }
        public int                                      MasterTrainingLv                        { get; set; }
        public int                                      Slot                                    { get; set; }
        public List<SupportEffectPassiveEffect>?        SupportEffectPassiveEffects             { get; set; }
        public bool                                     CanTraining                             { get; set; }
        public bool                                     CanMasterTraining                       { get; set; }
        public List<int>?                               PotentialSupportSkillGroupIdList        { get; set; }

        public static SCharaIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaIcon();

            value.TrainingDisplayPermit                     = GetBool(new IntPtr(p + 0x048)); // 0270D4C94B18 0x48 TrainingDisplayPermit       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MasterTrainingDisplayPermit               = GetBool(new IntPtr(p + 0x049)); // 0270D4C94B38 0x49 MasterTrainingDisplayPermit ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IconId                                    = GetString(new IntPtr(p + 0x050)); // 0270D4C94B58 0x50 IconId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x058)); // 0270D4C94B78 0x58 Rarity                      ( 00018661FD00 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.GoodSchedule                              = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x05C)); // 0270D4C94B98 0x5C GoodSchedule                ( 000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.Diamond                                   = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0270D4C94BB8 0x60 Diamond                     ( 0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.CharaLv                                   = GetInt32(new IntPtr(p + 0x068)); // 0270D4C94BD8 0x68 CharaLv                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MasterTrainingLv                          = GetInt32(new IntPtr(p + 0x06C)); // 0270D4C94BF8 0x6C MasterTrainingLv            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Slot                                      = GetInt32(new IntPtr(p + 0x070)); // 0270D4C94C18 0x70 Slot                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportEffectPassiveEffects               = GetObjectList<SupportEffectPassiveEffect>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportEffectPassiveEffect.FromPointer); // 0270D4C94C38 0x78 SupportEffectPassiveEffects ( 000185D10CF8 ModelClassListType List`1<SupportEffectPassiveEffect> List`1<SupportEffectPassiveEffect> List<SupportEffectPassiveEffect> Pointer )
            value.CanTraining                               = GetBool(new IntPtr(p + 0x080)); // 0270D4C94C58 0x80 CanTraining                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanMasterTraining                         = GetBool(new IntPtr(p + 0x081)); // 0270D4C94C78 0x81 CanMasterTraining           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PotentialSupportSkillGroupIdList          = GetInt32List(new IntPtr(p + 0x088)); // 0270D4C94C98 0x88 PotentialSupportSkillGroupIdList ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
