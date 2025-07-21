using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 FirstNameRoma                            ModelPrimitiveType string string string String
    // 020 LastNameRoma                             ModelPrimitiveType string string string String
    // 028 ColorCode                                ModelPrimitiveType string string string String
    // 030 MstDefaultCasualCostumeSetId             ModelPrimitiveType int int int Int32
    // 038 FirstName                                ModelPrimitiveType string string string String
    // 040 LastName                                 ModelPrimitiveType string string string String
    // 048 FirstNameKana                            ModelPrimitiveType string string string String
    // 050 LastNameKana                             ModelPrimitiveType string string string String
    // 058 Cv                                       ModelPrimitiveType string string string String
    // 060 Age                                      ModelPrimitiveType int int int Int32
    // 068 BloodType                                ModelPrimitiveType string string string String
    // 070 Birthday                                 ModelPrimitiveType string string string String
    // 078 ZodiacSign                               ModelPrimitiveType string string string String
    // 080 DominantHand                             ModelPrimitiveType string string string String
    // 088 Birthplace                               ModelPrimitiveType string string string String
    // 090 Height                                   ModelPrimitiveType string string string String
    // 098 Weight                                   ModelPrimitiveType string string string String
    // 0A0 Hobby                                    ModelPrimitiveType string string string String
    // 0A8 SpecialAbility                           ModelPrimitiveType string string string String
    // 0B0 Description                              ModelPrimitiveType string string string String
    public partial class IdolBaseDetailProfileViewModel : DataModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   FirstNameRoma                           { get; set; }
        public string                                   LastNameRoma                            { get; set; }
        public string                                   ColorCode                               { get; set; }
        public int                                      MstDefaultCasualCostumeSetId            { get; set; }
        public string                                   FirstName                               { get; set; }
        public string                                   LastName                                { get; set; }
        public string                                   FirstNameKana                           { get; set; }
        public string                                   LastNameKana                            { get; set; }
        public string                                   Cv                                      { get; set; }
        public int                                      Age                                     { get; set; }
        public string                                   BloodType                               { get; set; }
        public string                                   Birthday                                { get; set; }
        public string                                   ZodiacSign                              { get; set; }
        public string                                   DominantHand                            { get; set; }
        public string                                   Birthplace                              { get; set; }
        public string                                   Height                                  { get; set; }
        public string                                   Weight                                  { get; set; }
        public string                                   Hobby                                   { get; set; }
        public string                                   SpecialAbility                          { get; set; }
        public string                                   Description                             { get; set; }

        public static IdolBaseDetailProfileViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailProfileViewModel() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.FirstNameRoma                             = GetString(new IntPtr(p + 0x018)); // 0x18 FirstNameRoma               ( ModelPrimitiveType string string string String )
            value.LastNameRoma                              = GetString(new IntPtr(p + 0x020)); // 0x20 LastNameRoma                ( ModelPrimitiveType string string string String )
            value.ColorCode                                 = GetString(new IntPtr(p + 0x028)); // 0x28 ColorCode                   ( ModelPrimitiveType string string string String )
            value.MstDefaultCasualCostumeSetId              = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstDefaultCasualCostumeSetId ( ModelPrimitiveType int int int Int32 )
            value.FirstName                                 = GetString(new IntPtr(p + 0x038)); // 0x38 FirstName                   ( ModelPrimitiveType string string string String )
            value.LastName                                  = GetString(new IntPtr(p + 0x040)); // 0x40 LastName                    ( ModelPrimitiveType string string string String )
            value.FirstNameKana                             = GetString(new IntPtr(p + 0x048)); // 0x48 FirstNameKana               ( ModelPrimitiveType string string string String )
            value.LastNameKana                              = GetString(new IntPtr(p + 0x050)); // 0x50 LastNameKana                ( ModelPrimitiveType string string string String )
            value.Cv                                        = GetString(new IntPtr(p + 0x058)); // 0x58 Cv                          ( ModelPrimitiveType string string string String )
            value.Age                                       = GetInt32(new IntPtr(p + 0x060)); // 0x60 Age                         ( ModelPrimitiveType int int int Int32 )
            value.BloodType                                 = GetString(new IntPtr(p + 0x068)); // 0x68 BloodType                   ( ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x070)); // 0x70 Birthday                    ( ModelPrimitiveType string string string String )
            value.ZodiacSign                                = GetString(new IntPtr(p + 0x078)); // 0x78 ZodiacSign                  ( ModelPrimitiveType string string string String )
            value.DominantHand                              = GetString(new IntPtr(p + 0x080)); // 0x80 DominantHand                ( ModelPrimitiveType string string string String )
            value.Birthplace                                = GetString(new IntPtr(p + 0x088)); // 0x88 Birthplace                  ( ModelPrimitiveType string string string String )
            value.Height                                    = GetString(new IntPtr(p + 0x090)); // 0x90 Height                      ( ModelPrimitiveType string string string String )
            value.Weight                                    = GetString(new IntPtr(p + 0x098)); // 0x98 Weight                      ( ModelPrimitiveType string string string String )
            value.Hobby                                     = GetString(new IntPtr(p + 0x0A0)); // 0xA0 Hobby                       ( ModelPrimitiveType string string string String )
            value.SpecialAbility                            = GetString(new IntPtr(p + 0x0A8)); // 0xA8 SpecialAbility              ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x0B0)); // 0xB0 Description                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
