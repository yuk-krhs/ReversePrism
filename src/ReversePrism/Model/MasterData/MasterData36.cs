using System.IO;

namespace ReversePrism
{
    partial class MasterData36
    {
        public int          Id;
        public int          TextIndex1;
        public long         Value1;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 3);
            Read(r, ref Id);
            Read(r, ref TextIndex1);
            Read(r, ref Value1);
        }
    }
}
