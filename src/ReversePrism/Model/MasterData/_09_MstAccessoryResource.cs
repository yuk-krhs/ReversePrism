using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _09_MstAccessoryResource
    {
        public int          Id;
        public int          AccessoryId;
        public string?      ModelNameToken;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 2);
            Read(r, ref AccessoryId);
            Read(r, ref ModelNameToken);

            Assert(Id == AccessoryId);
        }
    }
}
