using System;

namespace ReversePrism
{
    public partial class MstProduceIdolReleaseCostumeSet : MasterDataItem
    {
        public int                              Id;
        public int                              MstProduceIdolId;
        public int                              MstCostumeSetId;
        public int                              Star;
        public DateTime                         ReleaseDate;
    }
}
