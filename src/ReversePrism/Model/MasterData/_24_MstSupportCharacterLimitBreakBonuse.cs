using System.IO;

namespace ReversePrism
{
    partial class _24_MstSupportCharacterLimitBreakBonuse
    {
        public int          Value1;
        public int          Value2;
        public int          Value3;
        public int          Value4;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 4);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);
            Read(r, ref Value4);
        }
    }
}
