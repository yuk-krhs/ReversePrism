using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FesIdol                                  ModelClassType IFesIdolStatus IFesIdolStatus IFesIdolStatus Pointer
    // 018 ForReference                             ModelPrimitiveType bool bool bool Bool
    // 020 FIdolIcon                                ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer
    // 028 MstFesIdolId                             ModelPrimitiveType string string string String
    // 030 MstFavoriteMarkId                        ModelPrimitiveType int int int Int32
    // 038 Parameter                                ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 040 BaseParameter                            ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 048 LiveSkillViewModel                       ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 050 IdolSkillId                              ModelPrimitiveType int int int Int32
    // 054 IdolSkillPp                              ModelPrimitiveType int int int Int32
    // 058 IdolSkillAppealTypeList                  ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 060 IdolSkillActionEffectList                ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 068 IdolSkillActionCondition                 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    // 070 IdolSkillLv                              ModelPrimitiveType int int int Int32
    // 074 IdolSkillIconId                          ModelPrimitiveType int int int Int32
    // 078 MstUnitId                                ModelPrimitiveType int int int Int32
    // 080 UnitName                                 ModelPrimitiveType string string string String
    // 088 UnitRank                                 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 090 UnitParameter                            ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 098 UnitMemberIcons                          ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer
    // 0A0 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 0A4 DifficultyLevel                          ModelPrimitiveType int int int Int32
    // 0A8 CreateDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 0B0 IsAutoProduce                            ModelPrimitiveType bool bool bool Bool
    // 0B8 <StrategyList>k__BackingField            ValueTuple`2<int, int>[] IL2CPP_TYPE_SZARRAY
    // 0C0 InitialTabIndex                          ModelPrimitiveType int int int Int32
    public partial class FIdolDetailPopupViewModel : DataModel
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
            var value   = new FIdolDetailPopupViewModel() { Pointer= p0 };

            value.FesIdol                                   = GetObject<IFesIdolStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFesIdolStatus.FromPointer); // 0x10 FesIdol                     ( ModelClassType IFesIdolStatus IFesIdolStatus IFesIdolStatus Pointer )
            value.ForReference                              = GetBool(new IntPtr(p + 0x018)); // 0x18 ForReference                ( ModelPrimitiveType bool bool bool Bool )
            value.FIdolIcon                                 = GetObject<FIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0x20 FIdolIcon                   ( ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer )
            value.MstFesIdolId                              = GetString(new IntPtr(p + 0x028)); // 0x28 MstFesIdolId                ( ModelPrimitiveType string string string String )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstFavoriteMarkId           ( ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x38 Parameter                   ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.BaseParameter                             = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 0x40 BaseParameter               ( ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.LiveSkillViewModel                        = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 0x48 LiveSkillViewModel          ( ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.IdolSkillId                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 IdolSkillId                 ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillPp                               = GetInt32(new IntPtr(p + 0x054)); // 0x54 IdolSkillPp                 ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillAppealTypeList                   = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x058)); // 0x58 IdolSkillAppealTypeList     ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.IdolSkillActionEffectList                 = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 0x60 IdolSkillActionEffectList   ( ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.IdolSkillActionCondition                  = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 0x68 IdolSkillActionCondition    ( ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )
            value.IdolSkillLv                               = GetInt32(new IntPtr(p + 0x070)); // 0x70 IdolSkillLv                 ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillIconId                           = GetInt32(new IntPtr(p + 0x074)); // 0x74 IdolSkillIconId             ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x078)); // 0x78 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x080)); // 0x80 UnitName                    ( ModelPrimitiveType string string string String )
            value.UnitRank                                  = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x088)); // 0x88 UnitRank                    ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.UnitParameter                             = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x90 UnitParameter               ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.UnitMemberIcons                           = GetObjectList<FIdolIcon>(new IntPtr(p + 0x098), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0x98 UnitMemberIcons             ( ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 DifficultyLevel             ( ModelPrimitiveType int int int Int32 )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x0A8)); // 0xA8 CreateDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.IsAutoProduce                             = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsAutoProduce               ( ModelPrimitiveType bool bool bool Bool )
            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 InitialTabIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
