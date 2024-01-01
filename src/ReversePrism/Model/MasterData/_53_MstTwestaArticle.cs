using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _53_MstTwestaArticle
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public byte         Value3;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 4);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);

            Assert(Id == Id2);
        }
    }
}
