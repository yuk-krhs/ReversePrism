using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _26_MstTipsCategor
    {
        public int          Id;
        public int          Id2;
        public string?      Color1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 2);
            Read(r, ref Id2);
            Read(r, ref Color1);

            Assert(Id == Id2);
        }
    }
}
