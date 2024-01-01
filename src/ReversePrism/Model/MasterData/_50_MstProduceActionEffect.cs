using System.IO;

namespace ReversePrism
{
    partial class _50_MstProduceActionEffect
    {
        public int          Value1;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 1);
            Read(r, ref Value1);
        }
    }
}
