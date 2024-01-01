using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _43_MstBannerGenr
    {
        public int          Id;
        public int          Id2;
        public string?      Name;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 2);
            Read(r, ref Id2);
            Read(r, ref Name);

            Assert(Id == Id2);
        }
    }
}
