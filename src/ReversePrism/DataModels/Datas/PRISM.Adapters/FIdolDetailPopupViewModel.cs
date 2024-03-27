using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FesIdol                                  000186779130 ModelClassType IFesIdolStatus IFesIdolStatus IFesIdolStatus Pointer
    // 018 ForReference                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 FIdolIcon                                000186544DF0 ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer
    // 028 MstFesIdolId                             000186671910 ModelPrimitiveType string string string String
    // 030 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Parameter                                0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 040 BaseParameter                            000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 048 LiveSkillViewModel                       00018657FCC0 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 050 IdolSkillId                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 IdolSkillPp                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 IdolSkillAppealTypeList                  000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 060 IdolSkillActionEffectList                000185CFDBC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 068 IdolSkillActionCondition                 000186576230 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    // 070 IdolSkillLv                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 IdolSkillIconId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 UnitName                                 000186671910 ModelPrimitiveType string string string String
    // 088 UnitRank                                 00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 090 UnitParameter                            0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 098 UnitMemberIcons                          000185B7E340 ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer
    // 0A0 MstEpisodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A4 DifficultyLevel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A8 CreateDate                               0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 0B0 IsAutoProduce                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B8 <StrategyList>k__BackingField            ValueTuple`2<int, int>[] IL2CPP_TYPE_SZARRAY
    // 0C0 InitialTabIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FIdolDetailPopupViewModel
    {
        public IFesIdolStatus?                          FesIdol                                 { get; set; }
        public bool                                     ForReference                            { get; set; }
        public FIdolIcon?                               FIdolIcon                               { get; set; }
        public string                                   MstFesIdolId                            { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public IProduceParameterStatus?                 Parameter                               { get; set; }
        public IIdolParameterStatus?                    BaseParameter                           { get; set; }
        public LiveSkillViewModel?                      LiveSkillViewModel                      { get; set; }
        public int                                      IdolSkillId                             { get; set; }
        public int                                      IdolSkillPp                             { get; set; }
        public List<ProduceParameterType>?              IdolSkillAppealTypeList                 { get; set; }
        public List<IIdolSkillActionEffectStatus>?      IdolSkillActionEffectList               { get; set; }
        public IIdolSkillActionConditionStatus?         IdolSkillActionCondition                { get; set; }
        public int                                      IdolSkillLv                             { get; set; }
        public int                                      IdolSkillIconId                         { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   UnitName                                { get; set; }
        public ProduceParameterRank                     UnitRank                                { get; set; }
        public IProduceParameterStatus?                 UnitParameter                           { get; set; }
        public List<FIdolIcon>?                         UnitMemberIcons                         { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      DifficultyLevel                         { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public bool                                     IsAutoProduce                           { get; set; }
        public int                                      InitialTabIndex                         { get; set; }

        public static FIdolDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailPopupViewModel();

            value.FesIdol                                   = GetObject<IFesIdolStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFesIdolStatus.FromPointer); // 0270D5EF5E70 0x10 FesIdol                     ( 000186779130 ModelClassType IFesIdolStatus IFesIdolStatus IFesIdolStatus Pointer )
            value.ForReference                              = GetBool(new IntPtr(p + 0x018)); // 0270D5EF5E90 0x18 ForReference                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FIdolIcon                                 = GetObject<FIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0270D5EF5EB0 0x20 FIdolIcon                   ( 000186544DF0 ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer )
            value.MstFesIdolId                              = GetString(new IntPtr(p + 0x028)); // 0270D5EF5ED0 0x28 MstFesIdolId                ( 000186671910 ModelPrimitiveType string string string String )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x030)); // 0270D5EF5EF0 0x30 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D5EF5F10 0x38 Parameter                   ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.BaseParameter                             = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 0270D5EF5F30 0x40 BaseParameter               ( 000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.LiveSkillViewModel                        = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 0270D5EF5F50 0x48 LiveSkillViewModel          ( 00018657FCC0 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.IdolSkillId                               = GetInt32(new IntPtr(p + 0x050)); // 0270D5EF5F70 0x50 IdolSkillId                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillPp                               = GetInt32(new IntPtr(p + 0x054)); // 0270D5EF5F90 0x54 IdolSkillPp                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillAppealTypeList                   = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x058)); // 0270D5EF5FB0 0x58 IdolSkillAppealTypeList     ( 000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.IdolSkillActionEffectList                 = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 0270D5EF5FD0 0x60 IdolSkillActionEffectList   ( 000185CFDBC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.IdolSkillActionCondition                  = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 0270D5EF5FF0 0x68 IdolSkillActionCondition    ( 000186576230 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )
            value.IdolSkillLv                               = GetInt32(new IntPtr(p + 0x070)); // 0270D5EF6010 0x70 IdolSkillLv                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillIconId                           = GetInt32(new IntPtr(p + 0x074)); // 0270D5EF6030 0x74 IdolSkillIconId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x078)); // 0270D5EF6050 0x78 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x080)); // 0270D5EF6070 0x80 UnitName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.UnitRank                                  = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x088)); // 0270D5EF6090 0x88 UnitRank                    ( 00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.UnitParameter                             = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D5EF60B0 0x90 UnitParameter               ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.UnitMemberIcons                           = GetObjectList<FIdolIcon>(new IntPtr(p + 0x098), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0270D5EF60D0 0x98 UnitMemberIcons             ( 000185B7E340 ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x0A0)); // 0270D5EF60F0 0xA0 MstEpisodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = GetInt32(new IntPtr(p + 0x0A4)); // 0270D5EF6110 0xA4 DifficultyLevel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x0A8)); // 0270D5EF6130 0xA8 CreateDate                  ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.IsAutoProduce                             = GetBool(new IntPtr(p + 0x0B0)); // 0270D5EF6150 0xB0 IsAutoProduce               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x0C0)); // 0270D5EF6190 0xC0 InitialTabIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
