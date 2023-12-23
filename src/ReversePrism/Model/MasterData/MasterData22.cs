using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData22
    {
        public int          Id;
        public int          TextIndex1;
        public string?      Token1;
        public string?      Token2;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 3);
            Read(r, ref TextIndex1);
            Read(r, ref Token1);
            Read(r, ref Token2);

            Assert(Id == TextIndex1);
        }
    }
}
