using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _59_MstMainStorie
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public int[]?       Values1;
        public int          Value3;
        public string?[]?   Tokens1;
        public long         Value4;
        public int          Value5;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 8);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Values1);
            Read(r, ref Value3);
            Read(r, ref Tokens1);
            Read(r, ref Value4);
            Read(r, ref Value5);

            Assert(Id == Id2);
        }
    }
}
