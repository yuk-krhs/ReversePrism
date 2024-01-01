using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _04_MstCostume
    {
        public int          Id;
        public int          TextIndexCostume;
        public int          IdolId;
        public int          Category;   // 0:システム 1:ライブ 2:私服
        public int          ClothId;
        public int          SortIndex;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 5);
            Read(r, ref TextIndexCostume);
            Read(r, ref IdolId);
            Read(r, ref Category);
            Read(r, ref ClothId);
            Read(r, ref SortIndex);

            Assert(Id == TextIndexCostume);
        }
    }
}
