using System.IO;

namespace ReversePrism
{
    partial class MasterData41
    {
        public string?      Token1;

        protected override void Deserialize(BinaryReader r)
        {
            ReadFieldCount(r, 1);
            Read(r, ref Token1);
        }
    }
}
