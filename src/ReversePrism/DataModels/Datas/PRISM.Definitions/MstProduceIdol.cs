using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 ProduceIdolType                          ModelPrimitiveType int int int Int32
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 01C InitialStar                              ModelPrimitiveType int int int Int32
    // 020 CardId                                   ModelPrimitiveType int int int Int32
    // 024 InitialVocal                             ModelPrimitiveType int int int Int32
    // 028 InitialDance                             ModelPrimitiveType int int int Int32
    // 02C InitialVisual                            ModelPrimitiveType int int int Int32
    // 030 InitialMental                            ModelPrimitiveType int int int Int32
    // 034 LimitVocal                               ModelPrimitiveType int int int Int32
    // 038 LimitDance                               ModelPrimitiveType int int int Int32
    // 03C LimitVisual                              ModelPrimitiveType int int int Int32
    // 040 LimitMental                              ModelPrimitiveType int int int Int32
    // 044 MstStarGrowthId                          ModelPrimitiveType int int int Int32
    // 048 Cost                                     ModelPrimitiveType int int int Int32
    // 050 MstIdolSkillIdList                       ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 IdolSkillPremiseEvolutionLevelList       ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 MstPotentialLiveSkillIdList              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 PotentialLiveSkillPremiseStarList        ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 CostumeSetIdList                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 CostumeSetPremiseStarList                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 080 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 088 LimitBreakRecipeProductId                ModelPrimitiveType string string string String
    // 090 EvolutionRecipeGroupId                   ModelPrimitiveType int int int Int32
    // 098 MstIdolSkillForMstProduceIdolList        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 MstPotentialLiveSkillForMstProduceIdolList ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 MstDressSetForMstProduceIdolList         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0B0 GashaVoiceMstVoiceResourceId             ModelPrimitiveType int int int Int32
    // 0B4 GashaSeMstVoiceResourceId                ModelPrimitiveType int int int Int32
    // 0B8 SignPositionIndex                        ModelPrimitiveType int int int Int32
    // 0C0 CharacterInfo                            ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    public partial class MstProduceIdol : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      ProduceIdolType                         { get; set; }
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
            var value   = new MstProduceIdol() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.ProduceIdolType                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 ProduceIdolType             ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C InitialStar                 ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 CardId                      ( ModelPrimitiveType int int int Int32 )
            value.InitialVocal                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 InitialVocal                ( ModelPrimitiveType int int int Int32 )
            value.InitialDance                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 InitialDance                ( ModelPrimitiveType int int int Int32 )
            value.InitialVisual                             = GetInt32(new IntPtr(p + 0x02C)); // 0x2C InitialVisual               ( ModelPrimitiveType int int int Int32 )
            value.InitialMental                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 InitialMental               ( ModelPrimitiveType int int int Int32 )
            value.LimitVocal                                = GetInt32(new IntPtr(p + 0x034)); // 0x34 LimitVocal                  ( ModelPrimitiveType int int int Int32 )
            value.LimitDance                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 LimitDance                  ( ModelPrimitiveType int int int Int32 )
            value.LimitVisual                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C LimitVisual                 ( ModelPrimitiveType int int int Int32 )
            value.LimitMental                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 LimitMental                 ( ModelPrimitiveType int int int Int32 )
            value.MstStarGrowthId                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 MstStarGrowthId             ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x048)); // 0x48 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.MstIdolSkillIdList                        = GetInt32List(new IntPtr(p + 0x050)); // 0x50 MstIdolSkillIdList          ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IdolSkillPremiseEvolutionLevelList        = GetInt32List(new IntPtr(p + 0x058)); // 0x58 IdolSkillPremiseEvolutionLevelList ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstPotentialLiveSkillIdList               = GetInt32List(new IntPtr(p + 0x060)); // 0x60 MstPotentialLiveSkillIdList ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PotentialLiveSkillPremiseStarList         = GetInt32List(new IntPtr(p + 0x068)); // 0x68 PotentialLiveSkillPremiseStarList ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CostumeSetIdList                          = GetInt32List(new IntPtr(p + 0x070)); // 0x70 CostumeSetIdList            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CostumeSetPremiseStarList                 = GetInt32List(new IntPtr(p + 0x078)); // 0x78 CostumeSetPremiseStarList   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x080)); // 0x80 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LimitBreakRecipeProductId                 = GetString(new IntPtr(p + 0x088)); // 0x88 LimitBreakRecipeProductId   ( ModelPrimitiveType string string string String )
            value.EvolutionRecipeGroupId                    = GetInt32(new IntPtr(p + 0x090)); // 0x90 EvolutionRecipeGroupId      ( ModelPrimitiveType int int int Int32 )
            value.MstIdolSkillForMstProduceIdolList         = GetStringList(new IntPtr(p + 0x098)); // 0x98 MstIdolSkillForMstProduceIdolList ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MstPotentialLiveSkillForMstProduceIdolList = GetStringList(new IntPtr(p + 0x0A0)); // 0xA0 MstPotentialLiveSkillForMstProduceIdolList ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MstDressSetForMstProduceIdolList          = GetStringList(new IntPtr(p + 0x0A8)); // 0xA8 MstDressSetForMstProduceIdolList ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.GashaVoiceMstVoiceResourceId              = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 GashaVoiceMstVoiceResourceId ( ModelPrimitiveType int int int Int32 )
            value.GashaSeMstVoiceResourceId                 = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 GashaSeMstVoiceResourceId   ( ModelPrimitiveType int int int Int32 )
            value.SignPositionIndex                         = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 SignPositionIndex           ( ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0xC0 CharacterInfo               ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )

            return value;
        }
    }
}
