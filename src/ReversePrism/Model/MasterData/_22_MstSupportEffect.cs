using System;

namespace ReversePrism
{
    public partial class MstSupportEffect : MasterDataItem
    {
        public int                              Id;
        public int                              EffectId;
        public int[]?                           MstProducePassiveEffectIdList;
        public int                              EntrustAppealType;
        public int                              EntrustScore;
        public int                              ChoiceWeight;
    }
}
