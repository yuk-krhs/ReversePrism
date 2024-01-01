using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _70_MstPhoneCall
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public int          Value3;
        public int          Value4;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 5);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Value3);
            Read(r, ref Value4);

            Assert(Id == Id2);
        }
    }
}
