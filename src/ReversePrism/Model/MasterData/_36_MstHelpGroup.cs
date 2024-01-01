using System.IO;

namespace ReversePrism
{
    partial class _36_MstHelpGroup
    {
        public int          Value1;
        public int          Value2;
        public int          Value3;
        public long         Value4;
        public long         Value5;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 5);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);
            Read(r, ref Value4);
            Read(r, ref Value5);
        }
    }
}
