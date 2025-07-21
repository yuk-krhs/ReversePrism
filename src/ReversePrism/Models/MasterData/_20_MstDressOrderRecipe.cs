using System;

namespace ReversePrism
{
    public partial class MstDressOrderRecipe : MasterDataItem
    {
        public int                              Id;
        public int                              MstUnitId;
        public int                              CostumeType;
        public string[]?                        RecipeList;
    }
}
