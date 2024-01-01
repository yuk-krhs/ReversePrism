using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _02_MstIdolStandingPosition
    {
        public int          Id;
        public int          UnitId;
        public int[]?       IdolId;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 2);
            Read(r, ref UnitId);
            Read(r, ref IdolId);

            Assert(Id == UnitId);
        }
    }
}
