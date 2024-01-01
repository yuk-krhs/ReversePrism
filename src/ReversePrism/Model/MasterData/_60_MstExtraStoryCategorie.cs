using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _60_MstExtraStoryCategorie
    {
        public int          Id;
        public int          Id2;
        public long         Value1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 2);
            Read(r, ref Id2);
            Read(r, ref Value1);

            Assert(Id == Id2);
        }
    }
}
