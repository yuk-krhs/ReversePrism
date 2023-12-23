using System.IO;

namespace ReversePrism
{
    partial class MasterData26
    {
        public int          Id;
        public int          Value1;
        public int          Value2;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 3);
            Read(r, ref Id);
            Read(r, ref Value1);
            Read(r, ref Value2);
        }
    }
}
