using System.IO;

namespace ReversePrism
{
    partial class _18_MstItemProvider
    {
        public int          Id;
        public string?      Token1;
        public int          Value1;
        public string?      Token2;
        public long         Value2;
        public long         Value3;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 6);
            Read(r, ref Id);
            Read(r, ref Token1);
            Read(r, ref Value1);
            Read(r, ref Token2);
            Read(r, ref Value2);
            Read(r, ref Value3);
        }
    }
}
