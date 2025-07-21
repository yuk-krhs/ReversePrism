using System;

namespace ReversePrism
{
    public partial class MstSupportCharacter : MasterDataItem
    {
        public int                              Id;
        public int                              MstCharacterId;
        public int                              Rarity;
        public int                              GoodScheduleDetailType;
        public int[]?                           MstPotentialSupportSkillIdList;
        public int[]?                           MstSupportEffectIdList;
        public int[]?                           UnlockPremiseLevelList;
        public DateTime                         ReleaseDate;
        public string?                          LimitBreakRecipeProductId;
        public int                              SignPositionIndex;
        public int                              InitialVocal;
        public int                              InitialDance;
        public int                              InitialVisual;
        public int                              InitialMental;
        public int                              MaxLevelVocal;
        public int                              MaxLevelDance;
        public int                              MaxLevelVisual;
        public int                              MaxLevelMental;
        public int                              MstLiveSupportEffectId;
    }
}
