using System;

namespace ReversePrism
{
    public partial class MstLiveCutScene : MasterDataItem
    {
        public int                              Id;
        public int                              MstSongId;
        public string?                          CutSceneName;
        public LiveCutSceneConditionType        ConditionType;
    }
}
