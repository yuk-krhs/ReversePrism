using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _31_MstChainGroup
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int[]?       Values1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 3);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Values1);

            Assert(Id == Id2);
        }
    }
}
