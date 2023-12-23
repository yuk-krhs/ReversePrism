using System.IO;

namespace ReversePrism
{
    // todo Count == 0
    partial class MasterData39
    {
        public int          Id;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 0);
        }
    }
}
