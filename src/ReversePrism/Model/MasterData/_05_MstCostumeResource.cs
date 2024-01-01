using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _05_MstCostumeResource
    {
        public int          Id;
        public int          ClothId;
        public string?      ModelNameToken;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 2);
            Read(r, ref ClothId);
            Read(r, ref ModelNameToken);

            Assert(Id == ClothId);
        }
    }
}
