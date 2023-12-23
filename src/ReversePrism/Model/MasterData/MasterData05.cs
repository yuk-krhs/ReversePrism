using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData05
    {
        public int          Id;
        public int          TextIndexCostume;
        public int          IdolId;
        public int          Value2;
        public int          DressId;
        public int          Value4;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 5);
            Read(r, ref TextIndexCostume);
            Read(r, ref IdolId);
            Read(r, ref Value2);
            Read(r, ref DressId);
            Read(r, ref Value4);

            Assert(Id == TextIndexCostume);
        }
    }
}
