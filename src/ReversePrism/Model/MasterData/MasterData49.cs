using System.IO;

namespace ReversePrism
{
    partial class MasterData49
    {
        public int          Value1;
        public int          Value2;
        public int          Value3;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 3);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);
        }
    }
}
