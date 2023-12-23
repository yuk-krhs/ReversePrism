using System.IO;

namespace ReversePrism
{
    partial class MasterData77
    {
        public int          Id;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 1);
            Read(r, ref Id);
        }
    }
}
