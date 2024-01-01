using System.IO;

namespace ReversePrism
{
    partial class _76_MstProduceStrategyType
    {
        public int          Id;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 1);
            Read(r, ref Id);
        }
    }
}
