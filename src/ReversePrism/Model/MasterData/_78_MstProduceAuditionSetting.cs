using System.IO;

namespace ReversePrism
{
    partial class _78_MstProduceAuditionSetting
    {
        public string?      Token1;
        public int          Value1;
        public int          Value2;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 3);
            Read(r, ref Token1);
            Read(r, ref Value1);
            Read(r, ref Value2);
        }
    }
}
