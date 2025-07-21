using System;

namespace ReversePrism
{
    public partial class MstCharacterInfo : MasterDataItem
    {
        public int                              Id;
        public int                              MstUnitId;
        public string?                          FirstNameRoma;
        public string?                          LastNameRoma;
        public string?                          FirstNameKana;
        public string?                          LastNameKana;
        public int                              Age;
        public string?                          BloodType;
        public string?                          Birthday;
        public string?                          ZodiacSign;
        public string?                          DominantHand;
        public string?                          Birthplace;
        public string?                          Height;
        public string?                          Weight;
        public string?                          Hobby;
        public string?                          SpecialAbility;
        public string?                          Description;
        public string?                          ColorCode;
        public string?                          ProfileFontColorCode;
        public string?                          ProfileBgColorCode;
        public int                              MstDefaultCasualCostumeSetId;
        public int                              MstTracksuitLifeSizeCostumeSetId;
        public int                              MstTracksuitCbCostumeSetId;
        public float                            Shape;
        public float                            HeadShape;
        public int                              MotionType;
        public string?                          LightColorCode;
        public int                              Order;
    }
}
