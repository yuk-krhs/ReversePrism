using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData55
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public int[]?       Values1;
        public int[]?       Values2;
        public int[]?       Values3;
        public int[]?       Values4;
        public int[]?       Values5;
        public int          Value3;
        public int          Value4;
        public string?      Token1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 11);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Values1);
            Read(r, ref Values2);
            Read(r, ref Values3);
            Read(r, ref Values4);
            Read(r, ref Values5);
            Read(r, ref Value3);
            Read(r, ref Value4);
            Read(r, ref Token1);

            Assert(Id == Id2);
        }
    }
}
