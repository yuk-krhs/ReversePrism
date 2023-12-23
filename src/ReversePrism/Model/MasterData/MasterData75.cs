using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData75
    {
        public int          Id;
        public int          Id2;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 1);
            Read(r, ref Id2);

            Assert(Id == Id2);
        }
    }
}
