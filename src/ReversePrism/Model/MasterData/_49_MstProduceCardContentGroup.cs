using System.IO;

namespace ReversePrism
{
    partial class _49_MstProduceCardContentGroup
    {
        public int          Value1;
        public int          Value2;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 2);
            Read(r, ref Value1);
            Read(r, ref Value2);
        }
    }
}
