using System;

namespace ReversePrism
{
    public partial class MstProduceIdol : MasterDataItem
    {
        public int                              Id;
        public int                              MstIdolId;
        public int                              InitialStar;
        public int                              CardId;
        public int                              InitialVocal;
        public int                              InitialDance;
        public int                              InitialVisual;
        public int                              InitialMental;
        public int                              LimitVocal;
        public int                              LimitDance;
        public int                              LimitVisual;
        public int                              LimitMental;
        public int                              MstStarGrowthId;
        public int                              Cost;
        public int[]?                           MstIdolSkillIdList;
        public int[]?                           IdolSkillPremiseEvolutionLevelList;
        public int[]?                           MstPotentialLiveSkillIdList;
        public int[]?                           PotentialLiveSkillPremiseStarList;
        public int[]?                           CostumeSetIdList;
        public int[]?                           CostumeSetPremiseStarList;
        public DateTime                         ReleaseDate;
        public string?                          LimitBreakRecipeProductId;
        public int                              EvolutionRecipeGroupId;
        public string[]?                        MstIdolSkillForMstProduceIdolList;
        public string[]?                        MstPotentialLiveSkillForMstProduceIdolList;
        public string[]?                        MstDressSetForMstProduceIdolList;
        public int                              GashaVoiceMstVoiceResourceId;
        public int                              GashaSeMstVoiceResourceId;
        public int                              SignPositionIndex;
    }
}
