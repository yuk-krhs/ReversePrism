using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _52_MstProduceIdol
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public int          Value3;
        public int          Value4;
        public int          Value5;
        public int          Value6;
        public int          Value7;
        public int          Value8;
        public int          Value9;
        public int          Value10;
        public int          Value11;
        public int          Value12;
        public int          Value13;
        public int[]?       Values1;
        public int[]?       Values2;
        public int[]?       Values3;
        public int[]?       Values4;
        public int[]?       Values5;
        public int[]?       Values6;
        public long         Value14;
        public string?      Token1;
        public int          Value15;
        public string?[]?   Tokens1;
        public string?[]?   Tokens2;
        public string?[]?   Tokens3;
        public int          Value16;
        public int          Value17;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 28);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);
            Read(r, ref Value4);
            Read(r, ref Value5);
            Read(r, ref Value6);
            Read(r, ref Value7);
            Read(r, ref Value8);
            Read(r, ref Value9);
            Read(r, ref Value10);
            Read(r, ref Value11);
            Read(r, ref Value12);
            Read(r, ref Value13);
            Read(r, ref Values1);
            Read(r, ref Values2);
            Read(r, ref Values3);
            Read(r, ref Values4);
            Read(r, ref Values5);
            Read(r, ref Values6);
            Read(r, ref Value14);
            Read(r, ref Token1);
            Read(r, ref Value15);
            Read(r, ref Tokens1);
            Read(r, ref Tokens2);
            Read(r, ref Tokens3);
            Read(r, ref Value16);
            Read(r, ref Value17);

            Assert(Id == Id2);
        }
    }
}
