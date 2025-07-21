using System;

namespace ReversePrism
{
    public partial class MstProduceIdol : MasterDataItem
    {
        public int                              Id;
        public int                              ProduceIdolType;
        public int                              MstIdolId;
        public int                              InitialStar;
        public int                              InitialVocal;
        public int                              InitialDance;
        public int                              InitialVisual;
        public int                              InitialMental;
        public int                              LimitVocal;
        public int                              LimitDance;
        public int                              LimitVisual;
        public int                              LimitMental;
        public int                              MstStarGrowthId;
        public int                              MaxLevelVocal;
        public int                              MaxLevelDance;
        public int                              MaxLevelVisual;
        public int                              MaxLevelMental;
        public int                              Attribute;
        public int[]?                           MstIdolSkillIdList;
        public int[]?                           IdolSkillPremiseEvolutionLevelList;
        public int                              MstLiveCenterEffectId;
        public int                              MstLiveSkillId;
        public int[]?                           CostumeSetIdList;
        public int[]?                           CostumeSetPremiseStarList;
        public DateTime                         ReleaseDate;
        public string?                          LimitBreakRecipeProductId;
        public int                              EvolutionRecipeGroupId;
        public int                              GashaVoiceMstVoiceResourceId;
        public int                              SignPositionIndex;
    }
}
