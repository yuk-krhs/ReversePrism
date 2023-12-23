using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData10
    {
        public int          Id;
        public int          Id2;
        public string?      Token1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 2);
            Read(r, ref Id2);
            Read(r, ref Token1);

            Assert(Id == Id2);
        }
    }
}
