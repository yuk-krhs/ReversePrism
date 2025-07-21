using System;

namespace ReversePrism
{
    public partial class MstProductType : MasterDataItem
    {
        public int                              Id;
        public bool                             UseIndividualIcon;
        public bool                             UseCategoricalIcon;
        public bool                             VisibleItem;
        public bool                             IsPossessionOnlyOne;
        public EnumItemType                     ItemType;
        public int                              SortId;
    }
}
