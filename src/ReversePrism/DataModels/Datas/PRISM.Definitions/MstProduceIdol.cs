using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstIdolId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 InitialStar                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C CardId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 InitialVocal                             0001865F4260 ModelPrimitiveType int int int Int32
    // 024 InitialDance                             0001865F4260 ModelPrimitiveType int int int Int32
    // 028 InitialVisual                            0001865F4260 ModelPrimitiveType int int int Int32
    // 02C InitialMental                            0001865F4260 ModelPrimitiveType int int int Int32
    // 030 LimitVocal                               0001865F4260 ModelPrimitiveType int int int Int32
    // 034 LimitDance                               0001865F4260 ModelPrimitiveType int int int Int32
    // 038 LimitVisual                              0001865F4260 ModelPrimitiveType int int int Int32
    // 03C LimitMental                              0001865F4260 ModelPrimitiveType int int int Int32
    // 040 MstStarGrowthId                          0001865F4260 ModelPrimitiveType int int int Int32
    // 044 Cost                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 048 MstIdolSkillIdList                       000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 IdolSkillPremiseEvolutionLevelList       000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 MstPotentialLiveSkillIdList              000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 PotentialLiveSkillPremiseStarList        000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 CostumeSetIdList                         000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 CostumeSetPremiseStarList                000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 080 LimitBreakRecipeProductId                000186672F10 ModelPrimitiveType string string string String
    // 088 EvolutionRecipeGroupId                   0001865F4260 ModelPrimitiveType int int int Int32
    // 090 MstIdolSkillForMstProduceIdolList        000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 098 MstPotentialLiveSkillForMstProduceIdolList 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 MstDressSetForMstProduceIdolList         000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 GashaVoiceMstVoiceResourceId             0001865F4260 ModelPrimitiveType int int int Int32
    // 0AC GashaSeMstVoiceResourceId                0001865F4260 ModelPrimitiveType int int int Int32
    // 0B0 SignPositionIndex                        0001865F4260 ModelPrimitiveType int int int Int32
    // 0B8 CharacterInfo                            00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    public partial class MstProduceIdol
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      InitialVocal                            { get; set; }
        public int                                      InitialDance                            { get; set; }
        public int                                      InitialVisual                           { get; set; }
        public int                                      InitialMental                           { get; set; }
        public int                                      LimitVocal                              { get; set; }
        public int                                      LimitDance                              { get; set; }
        public int                                      LimitVisual                             { get; set; }
        public int                                      LimitMental                             { get; set; }
        public int                                      MstStarGrowthId                         { get; set; }
        public int                                      Cost                                    { get; set; }
        public List<int>?                               MstIdolSkillIdList                      { get; set; }
        public List<int>?                               IdolSkillPremiseEvolutionLevelList      { get; set; }
        public List<int>?                               MstPotentialLiveSkillIdList             { get; set; }
        public List<int>?                               PotentialLiveSkillPremiseStarList       { get; set; }
        public List<int>?                               CostumeSetIdList                        { get; set; }
        public List<int>?                               CostumeSetPremiseStarList               { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public string                                   LimitBreakRecipeProductId               { get; set; }
        public int                                      EvolutionRecipeGroupId                  { get; set; }
        public List<string>?                            MstIdolSkillForMstProduceIdolList       { get; set; }
        public List<string>?                            MstPotentialLiveSkillForMstProduceIdolList { get; set; }
        public List<string>?                            MstDressSetForMstProduceIdolList        { get; set; }
        public int                                      GashaVoiceMstVoiceResourceId            { get; set; }
        public int                                      GashaSeMstVoiceResourceId               { get; set; }
        public int                                      SignPositionIndex                       { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }

        public static MstProduceIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProduceIdol();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700463D768 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x014)); // 02700463D788 0x14 MstIdolId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x018)); // 02700463D7A8 0x18 InitialStar                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x01C)); // 02700463D7C8 0x1C CardId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InitialVocal                              = GetInt32(new IntPtr(p + 0x020)); // 02700463D7E8 0x20 InitialVocal                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InitialDance                              = GetInt32(new IntPtr(p + 0x024)); // 02700463D808 0x24 InitialDance                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InitialVisual                             = GetInt32(new IntPtr(p + 0x028)); // 02700463D828 0x28 InitialVisual               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InitialMental                             = GetInt32(new IntPtr(p + 0x02C)); // 02700463D848 0x2C InitialMental               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LimitVocal                                = GetInt32(new IntPtr(p + 0x030)); // 02700463D868 0x30 LimitVocal                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LimitDance                                = GetInt32(new IntPtr(p + 0x034)); // 02700463D888 0x34 LimitDance                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LimitVisual                               = GetInt32(new IntPtr(p + 0x038)); // 02700463D8A8 0x38 LimitVisual                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LimitMental                               = GetInt32(new IntPtr(p + 0x03C)); // 02700463D8C8 0x3C LimitMental                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstStarGrowthId                           = GetInt32(new IntPtr(p + 0x040)); // 02700463D8E8 0x40 MstStarGrowthId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x044)); // 02700463D908 0x44 Cost                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstIdolSkillIdList                        = GetInt32List(new IntPtr(p + 0x048)); // 02700463D928 0x48 MstIdolSkillIdList          ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IdolSkillPremiseEvolutionLevelList        = GetInt32List(new IntPtr(p + 0x050)); // 02700463D948 0x50 IdolSkillPremiseEvolutionLevelList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstPotentialLiveSkillIdList               = GetInt32List(new IntPtr(p + 0x058)); // 02700463D968 0x58 MstPotentialLiveSkillIdList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PotentialLiveSkillPremiseStarList         = GetInt32List(new IntPtr(p + 0x060)); // 02700463D988 0x60 PotentialLiveSkillPremiseStarList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CostumeSetIdList                          = GetInt32List(new IntPtr(p + 0x068)); // 02700463D9A8 0x68 CostumeSetIdList            ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CostumeSetPremiseStarList                 = GetInt32List(new IntPtr(p + 0x070)); // 02700463D9C8 0x70 CostumeSetPremiseStarList   ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x078)); // 02700463D9E8 0x78 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LimitBreakRecipeProductId                 = GetString(new IntPtr(p + 0x080)); // 02700463DA08 0x80 LimitBreakRecipeProductId   ( 000186672F10 ModelPrimitiveType string string string String )
            value.EvolutionRecipeGroupId                    = GetInt32(new IntPtr(p + 0x088)); // 02700463DA28 0x88 EvolutionRecipeGroupId      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstIdolSkillForMstProduceIdolList         = GetStringList(new IntPtr(p + 0x090)); // 02700463DA48 0x90 MstIdolSkillForMstProduceIdolList ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MstPotentialLiveSkillForMstProduceIdolList = GetStringList(new IntPtr(p + 0x098)); // 02700463DA68 0x98 MstPotentialLiveSkillForMstProduceIdolList ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MstDressSetForMstProduceIdolList          = GetStringList(new IntPtr(p + 0x0A0)); // 02700463DA88 0xA0 MstDressSetForMstProduceIdolList ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.GashaVoiceMstVoiceResourceId              = GetInt32(new IntPtr(p + 0x0A8)); // 02700463DAA8 0xA8 GashaVoiceMstVoiceResourceId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GashaSeMstVoiceResourceId                 = GetInt32(new IntPtr(p + 0x0AC)); // 02700463DAC8 0xAC GashaSeMstVoiceResourceId   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SignPositionIndex                         = GetInt32(new IntPtr(p + 0x0B0)); // 02700463DAE8 0xB0 SignPositionIndex           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 02700463DB08 0xB8 CharacterInfo               ( 00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )

            return value;
        }
    }
}
