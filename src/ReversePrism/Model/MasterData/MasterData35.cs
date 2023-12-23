using System.IO;

namespace ReversePrism
{
    partial class MasterData35
    {
        public int          Id;
        public int          Value1;
        public int          Value2;
        public byte         Value3;
        public byte         Value4;
        public byte         Value5;
        public long         Value6;
        public long         Value7;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 8);
            Read(r, ref Id);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);
            Read(r, ref Value4);
            Read(r, ref Value5);
            Read(r, ref Value6);
            Read(r, ref Value7);
        }
    }
}
