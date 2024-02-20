using System;

namespace ReversePrism
{
    public partial class MstStreamProgram : MasterDataItem
    {
        public int                              Id;
        public string?                          Name;
        public string?                          Description;
        public DateTime                         BeginDate;
        public DateTime                         ArchiveBeginDate;
        public DateTime                         ArchiveEndDate;
        public int                              Second;
        public string?                          RoomName;
        public string?                          Url;
        public string?                          PModeUrl;
        public string?                          YUrl;
        public int[]?                           CastList;
    }
}
