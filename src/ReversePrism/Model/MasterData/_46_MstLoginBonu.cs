using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _46_MstLoginBonu
    {
        public int          Id;
        public int          Id2;
        public string?      Text;
        public int          Value1;
        public int          Value2;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 4);
            Read(r, ref Id2);
            Read(r, ref Text);
            Read(r, ref Value1);
            Read(r, ref Value2);

            Assert(Id == Id2);
        }
    }
}
