using System;

namespace ReversePrism
{
    public partial class MstIdolSkillEffect : MasterDataItem
    {
        public int                              Id;
        public int                              MstIdolSkillId;
        public int                              Level;
        public int                              Cost;
        public int                              UnlockPremiseStar;
        public int                              UsableCount;
        public int[]?                           MstProduceActionEffectIdList;
        public int                              MstProduceActionConditionTypeId;
        public int                              ConditionValue;
        public int                              StrengthScore;
    }
}
