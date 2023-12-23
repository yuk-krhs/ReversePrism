using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData08
    {
        public long         Id;
        public long         Id2;
        public ushort       Value1;
        public ushort       Value2;
        public int          Value3;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 4);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);

            Assert(Id == Id2);
        }
    }
}
