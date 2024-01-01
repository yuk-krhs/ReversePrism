using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _11_MstProductType
    {
        public int          Id;
        public int          Id2;
        public byte         Value1;
        public byte         Value2;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 3);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);

            Assert(Id == Id2);
        }
    }
}
