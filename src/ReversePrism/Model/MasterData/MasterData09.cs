using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData09
    {
        public int          Id;
        public int          TextIndex1;
        public int          Value1;
        public int          Value2;
        public int          Value3;
        public int          TextIndex2;
        public int          Value4;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 6);
            Read(r, ref TextIndex1);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);
            Read(r, ref TextIndex2);
            Read(r, ref Value4);

            Assert(Id == TextIndex1);
        }
    }
}
