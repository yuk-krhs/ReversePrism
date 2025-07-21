using System;

namespace ReversePrism
{
    public partial class MstProduceIdolEvolutionRecipe : MasterDataItem
    {
        public int                              Id;
        public int                              GroupId;
        public int                              EvolutionLevel;
        public string[]?                        ProductIdWithAmountList;
        public int                              Money;
    }
}
