using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData48
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public string?[]?   Tokens1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 3);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Tokens1);

            Assert(Id == Id2);
        }
    }
}
