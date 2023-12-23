using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData70
    {
        public string?      Id;
        public string?      Id2;
        public string?[]?   Strings1;
        public string?[]?   Strings2;
        public string?[]?   Strings3;
        public string?      String1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 5);
            Read(r, ref Id2);
            Read(r, ref Strings1);
            Read(r, ref Strings2);
            Read(r, ref Strings3);
            Read(r, ref String1);

            Assert(Id == Id2);
        }
    }
}
