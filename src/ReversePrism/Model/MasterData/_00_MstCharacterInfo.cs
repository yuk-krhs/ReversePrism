using System.IO;

namespace ReversePrism
{
    using static System.Diagnostics.Debug;

    partial class _00_MstCharacterInfo
    {
        [ID] public int     Id;
        public int          MstUnitId;
        public string?      NameEng;
        public string?      SurnameEng;
        public string?      Name;
        public string?      Surname;
        public int          Age;
        public string?      BloodType;
        public string?      Birthday;
        public string?      Constellation;
        public string?      DominantHand;
        public string?      Birthplace;
        public string?      Height;
        public string?      Weight;
        public string?      ThreeSize;
        public string?      Favorites;
        public string?      Talents;
        public string?      Description;
        public string?      Color1;
        public int          TextIndex1;
        public int          TextIndex2;
        public int          TextIndex3;
        public float        Value5;
        public float        Value6;
        public int          Value7;
        public string?      Color2;

        protected override void Deserialize(BinaryReader r)
        {
            Read(r, ref Id);
            ReadFieldCount(r, 26);
            Read(r, ref Id);
            Read(r, ref MstUnitId);
            Read(r, ref NameEng);
            Read(r, ref SurnameEng);
            Read(r, ref Name);
            Read(r, ref Surname);
            Read(r, ref Age);
            Read(r, ref BloodType);
            Read(r, ref Birthday);
            Read(r, ref Constellation);
            Read(r, ref DominantHand);
            Read(r, ref Birthplace);
            Read(r, ref Height);
            Read(r, ref Weight);
            Read(r, ref ThreeSize);
            Read(r, ref Favorites);
            Read(r, ref Talents);
            Read(r, ref Description);
            Read(r, ref Color1);
            Read(r, ref TextIndex1);
            Read(r, ref TextIndex2);
            Read(r, ref TextIndex3);
            Read(r, ref Value5);
            Read(r, ref Value6);
            Read(r, ref Value7);
            Read(r, ref Color2);

            Assert(Id == MstUnitId);
        }
    }
}
