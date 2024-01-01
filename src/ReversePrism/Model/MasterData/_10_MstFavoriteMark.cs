using System.IO;

namespace ReversePrism
{
    partial class _10_MstFavoriteMark
    {
        public int          Value1;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 1);
            Read(r, ref Value1);
        }
    }
}
