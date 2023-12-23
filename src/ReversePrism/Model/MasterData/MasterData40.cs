using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData40
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public int          Value3;
        public int          Value4;
        public int          Value5;
        public byte         Value6;
        public byte         Value7;
        public byte         Value8;
        public byte         Value9;
        public byte         Value10;
        public string?      Url;
        public long         Value11;
        public byte         Value12;
        public long         Value13;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 15);
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
            Read(r, ref Url);
            Read(r, ref Value11);
            Read(r, ref Value12);
            Read(r, ref Value13);

            Assert(Id == Id2);
        }
    }
}
