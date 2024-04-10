using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 FirstNameRoma                            000186672F10 ModelPrimitiveType string string string String
    // 020 LastNameRoma                             000186672F10 ModelPrimitiveType string string string String
    // 028 ColorCode                                000186672F10 ModelPrimitiveType string string string String
    // 030 MstDefaultCasualCostumeSetId             0001865F4260 ModelPrimitiveType int int int Int32
    // 038 FirstName                                000186672F10 ModelPrimitiveType string string string String
    // 040 LastName                                 000186672F10 ModelPrimitiveType string string string String
    // 048 FirstNameKana                            000186672F10 ModelPrimitiveType string string string String
    // 050 LastNameKana                             000186672F10 ModelPrimitiveType string string string String
    // 058 Cv                                       000186672F10 ModelPrimitiveType string string string String
    // 060 Age                                      0001865F4260 ModelPrimitiveType int int int Int32
    // 068 BloodType                                000186672F10 ModelPrimitiveType string string string String
    // 070 Birthday                                 000186672F10 ModelPrimitiveType string string string String
    // 078 ZodiacSign                               000186672F10 ModelPrimitiveType string string string String
    // 080 DominantHand                             000186672F10 ModelPrimitiveType string string string String
    // 088 Birthplace                               000186672F10 ModelPrimitiveType string string string String
    // 090 Height                                   000186672F10 ModelPrimitiveType string string string String
    // 098 Weight                                   000186672F10 ModelPrimitiveType string string string String
    // 0A0 Hobby                                    000186672F10 ModelPrimitiveType string string string String
    // 0A8 SpecialAbility                           000186672F10 ModelPrimitiveType string string string String
    // 0B0 Description                              000186672F10 ModelPrimitiveType string string string String
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

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 024665F00040 0x10 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 024665F00060 0x14 MstUnitId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FirstNameRoma                             = GetString(new IntPtr(p + 0x018)); // 024665F00080 0x18 FirstNameRoma               ( 000186672F10 ModelPrimitiveType string string string String )
            value.LastNameRoma                              = GetString(new IntPtr(p + 0x020)); // 024665F000A0 0x20 LastNameRoma                ( 000186672F10 ModelPrimitiveType string string string String )
            value.ColorCode                                 = GetString(new IntPtr(p + 0x028)); // 024665F000C0 0x28 ColorCode                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.MstDefaultCasualCostumeSetId              = GetInt32(new IntPtr(p + 0x030)); // 024665F000E0 0x30 MstDefaultCasualCostumeSetId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FirstName                                 = GetString(new IntPtr(p + 0x038)); // 024665F00100 0x38 FirstName                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.LastName                                  = GetString(new IntPtr(p + 0x040)); // 024665F00120 0x40 LastName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.FirstNameKana                             = GetString(new IntPtr(p + 0x048)); // 024665F00140 0x48 FirstNameKana               ( 000186672F10 ModelPrimitiveType string string string String )
            value.LastNameKana                              = GetString(new IntPtr(p + 0x050)); // 024665F00160 0x50 LastNameKana                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Cv                                        = GetString(new IntPtr(p + 0x058)); // 024665F00180 0x58 Cv                          ( 000186672F10 ModelPrimitiveType string string string String )
            value.Age                                       = GetInt32(new IntPtr(p + 0x060)); // 024665F001A0 0x60 Age                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BloodType                                 = GetString(new IntPtr(p + 0x068)); // 024665F001C0 0x68 BloodType                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x070)); // 024665F001E0 0x70 Birthday                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.ZodiacSign                                = GetString(new IntPtr(p + 0x078)); // 024665F00200 0x78 ZodiacSign                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.DominantHand                              = GetString(new IntPtr(p + 0x080)); // 024665F00220 0x80 DominantHand                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Birthplace                                = GetString(new IntPtr(p + 0x088)); // 024665F00240 0x88 Birthplace                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Height                                    = GetString(new IntPtr(p + 0x090)); // 024665F00260 0x90 Height                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Weight                                    = GetString(new IntPtr(p + 0x098)); // 024665F00280 0x98 Weight                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Hobby                                     = GetString(new IntPtr(p + 0x0A0)); // 024665F002A0 0xA0 Hobby                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.SpecialAbility                            = GetString(new IntPtr(p + 0x0A8)); // 024665F002C0 0xA8 SpecialAbility              ( 000186672F10 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x0B0)); // 024665F002E0 0xB0 Description                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
