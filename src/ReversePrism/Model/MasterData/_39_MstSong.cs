using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _39_MstSong
    {
        public int          Id;
        public int          SongId;
        public int          SongType;   // 0:全体 50:ソロ 1-9:ユニット
        public int          UnitId;
        public int          PresetUnit; // 個人は1000+IdolId?
        public int          SortIndex;
        public int          Value5;     // BPM?
        public byte         Value6;     // All 1
        public byte         Value7;     // 歌い分け？(全体局のツバサグラビティ以外)
        public byte         Value8;     // 初期解放? ツバサグラビティ(アニメ版)のみ0
        public byte         Value9;     // Value8と同じ
        public byte         Value10;    // ツバサグラビティ(アニメ版)のみ1(シリアルで解放)
        public string?      Url;
        public long         Value11;
        public byte         Value12;    // 初期解放? 星の声(Another)ツバサグラビティ(アニメ版)のみ0
        public long         Value13;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 15);
            Read(r, ref SongId);
            Read(r, ref SongType);
            Read(r, ref UnitId);
            Read(r, ref PresetUnit);
            Read(r, ref SortIndex);
            Read(r, ref Value5);
            Read(r, ref Value6);
            Read(r, ref Value7);
            Read(r, ref Value8);
            Read(r, ref Value9);
            Read(r, ref Value10);
            Read(r, ref Url);
            Read(r, ref Value11);
            Read(r, ref Value12);
            Read(r, ref Value13);

            Assert(Id == SongId);
        }
    }
}
