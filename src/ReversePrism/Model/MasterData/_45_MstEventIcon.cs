using System;

namespace ReversePrism
{
    public partial class MstEventIcon : MasterDataItem
    {
        public int                              Id;
        public int                              Place;
        public string?                          ImageResourceId;
        public string?                          Text;
        public int                              DisplayCondition;
        public int                              Priority;
    }
}
