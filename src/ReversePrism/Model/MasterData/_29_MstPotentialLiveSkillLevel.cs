using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _29_MstPotentialLiveSkillLevel
    {
        public int          Id;
        public int          Id2;
        public int          Value1;
        public int          Value2;
        public int[]?       Values1;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 4);
            Read(r, ref Id2);
            Read(r, ref Value1);
            Read(r, ref Value2);
            Read(r, ref Values1);

            Assert(Id == Id2);
        }
    }
}
