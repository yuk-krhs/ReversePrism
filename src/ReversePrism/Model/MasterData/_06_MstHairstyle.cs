using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _06_MstHairstyle
    {
        public int          Id;
        public int          TextIndex1;
        public int          CharaId;
        public int          ClothId;
        public int          HairId;
        public int[]?       AccessoryIds;
        public int          IconId;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 6);
            Read(r, ref TextIndex1);
            Read(r, ref CharaId);
            Read(r, ref ClothId);
            Read(r, ref HairId);
            Read(r, ref AccessoryIds);
            Read(r, ref IconId);

            Assert(Id == TextIndex1);
        }
    }
}
