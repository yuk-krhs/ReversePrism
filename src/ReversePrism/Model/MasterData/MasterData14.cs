using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData14
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public string?[]?   Tokens1;
        public int          Value3;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 5);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Tokens1);
            Read(r, ref Value3);

            Assert(Id == Id2);
        }
    }
}
