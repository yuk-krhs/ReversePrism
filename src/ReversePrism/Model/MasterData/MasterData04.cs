using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class MasterData04
    {
        public int          Id;
        public int          TextIndexStyle;
        public int          Value1;
        public int          TextIndexCloth;
        public int          TextIndexHairStyle;
        public int[]?       TextIndexAccessory;
        public int          Value2;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 6);
            Read(r, ref TextIndexStyle);
            Read(r, ref Value1);
            Read(r, ref TextIndexCloth);
            Read(r, ref TextIndexHairStyle);
            Read(r, ref TextIndexAccessory);
            Read(r, ref Value2);

            Assert(Id == TextIndexStyle);
        }
    }
}
