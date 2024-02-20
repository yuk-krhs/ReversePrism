using System;

namespace ReversePrism
{
    public partial class MstSupportCharacter : MasterDataItem
    {
        public int                              Id;
        public int                              MstCharacterId;
        public int                              Rarity;
        public int                              CardId;
        public int                              GoodScheduleDetailType;
        public int[]?                           MstPotentialSupportSkillIdList;
        public int[]?                           MstSupportCharacterEventIdList;
        public int[]?                           MstSupportEffectIdList;
        public int[]?                           UnlockPremiseLevelList;
        public DateTime                         ReleaseDate;
        public string?                          LimitBreakRecipeProductId;
        public int                              SignPositionIndex;
    }
}
