using System.IO;

namespace ReversePrism
{
    // todo Count == 0
    partial class _38_MstTitleImage
    {
        public int          Id;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 0);
        }
    }
}
