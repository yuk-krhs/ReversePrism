using System.IO;

namespace ReversePrism
{
    partial class MasterData50
    {
        public int          Value1;
        public int          Value2;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 2);
            Read(r, ref Value1);
            Read(r, ref Value2);
        }
    }
}
