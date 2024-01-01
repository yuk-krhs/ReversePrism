using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _22_MstSupportEffect
    {
        public int          Id;
        public int          TextIndex1;
        public int          TextIndex2;
        public int[]?       TextIndices1;
        public int          Value1;
        public int          Value2;
        public int          Value3;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 6);
            Read(r, ref TextIndex1);
            Read(r, ref TextIndex2);
            Read(r, ref TextIndices1);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);

            Assert(Id == TextIndex1);
        }
    }
}
