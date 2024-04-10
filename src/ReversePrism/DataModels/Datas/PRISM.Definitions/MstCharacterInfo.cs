using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 FirstNameRoma                            000186672F10 ModelPrimitiveType string string string String
    // 020 LastNameRoma                             000186672F10 ModelPrimitiveType string string string String
    // 028 FirstNameKana                            000186672F10 ModelPrimitiveType string string string String
    // 030 LastNameKana                             000186672F10 ModelPrimitiveType string string string String
    // 038 Age                                      0001865F4260 ModelPrimitiveType int int int Int32
    // 040 BloodType                                000186672F10 ModelPrimitiveType string string string String
    // 048 Birthday                                 000186672F10 ModelPrimitiveType string string string String
    // 050 ZodiacSign                               000186672F10 ModelPrimitiveType string string string String
    // 058 DominantHand                             000186672F10 ModelPrimitiveType string string string String
    // 060 Birthplace                               000186672F10 ModelPrimitiveType string string string String
    // 068 Height                                   000186672F10 ModelPrimitiveType string string string String
    // 070 Weight                                   000186672F10 ModelPrimitiveType string string string String
    // 078 ThreeSizes                               000186672F10 ModelPrimitiveType string string string String
    // 080 Hobby                                    000186672F10 ModelPrimitiveType string string string String
    // 088 SpecialAbility                           000186672F10 ModelPrimitiveType string string string String
    // 090 Description                              000186672F10 ModelPrimitiveType string string string String
    // 098 ColorCode                                000186672F10 ModelPrimitiveType string string string String
    // 0A0 MstDefaultCasualCostumeSetId             0001865F4260 ModelPrimitiveType int int int Int32
    // 0A4 MstTracksuitLifeSizeCostumeSetId         0001865F4260 ModelPrimitiveType int int int Int32
    // 0A8 MstTracksuitCbCostumeSetId               0001865F4260 ModelPrimitiveType int int int Int32
    // 0AC Shape                                    000186666CB0 ModelPrimitiveType float float float Single
    // 0B0 HeadShape                                000186666CB0 ModelPrimitiveType float float float Single
    // 0B4 MotionType                               0001865F4260 ModelPrimitiveType int int int Int32
    // 0B8 LightColorCode                           000186672F10 ModelPrimitiveType string string string String
    // 0C0 DefaultCasualCostumeSet                  00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 0C8 TracksuitLifeSizeCostumeSet              00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 0D0 TracksuitCbCostumeSet                    00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    public partial class MstCharacterInfo : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   FirstNameRoma                           { get; set; }
        public string                                   LastNameRoma                            { get; set; }
        public string                                   FirstNameKana                           { get; set; }
        public string                                   LastNameKana                            { get; set; }
        public int                                      Age                                     { get; set; }
        public string                                   BloodType                               { get; set; }
        public string                                   Birthday                                { get; set; }
        public string                                   ZodiacSign                              { get; set; }
        public string                                   DominantHand                            { get; set; }
        public string                                   Birthplace                              { get; set; }
        public string                                   Height                                  { get; set; }
        public string                                   Weight                                  { get; set; }
        public string                                   ThreeSizes                              { get; set; }
        public string                                   Hobby                                   { get; set; }
        public string                                   SpecialAbility                          { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   ColorCode                               { get; set; }
        public int                                      MstDefaultCasualCostumeSetId            { get; set; }
        public int                                      MstTracksuitLifeSizeCostumeSetId        { get; set; }
        public int                                      MstTracksuitCbCostumeSetId              { get; set; }
        public float                                    Shape                                   { get; set; }
        public float                                    HeadShape                               { get; set; }
        public int                                      MotionType                              { get; set; }
        public string                                   LightColorCode                          { get; set; }
        public MstCostumeSet?                           DefaultCasualCostumeSet                 { get; set; }
        public MstCostumeSet?                           TracksuitLifeSizeCostumeSet             { get; set; }
        public MstCostumeSet?                           TracksuitCbCostumeSet                   { get; set; }

        public static MstCharacterInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstCharacterInfo() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46F1210 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0245A46F1230 0x14 MstUnitId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FirstNameRoma                             = GetString(new IntPtr(p + 0x018)); // 0245A46F1250 0x18 FirstNameRoma               ( 000186672F10 ModelPrimitiveType string string string String )
            value.LastNameRoma                              = GetString(new IntPtr(p + 0x020)); // 0245A46F1270 0x20 LastNameRoma                ( 000186672F10 ModelPrimitiveType string string string String )
            value.FirstNameKana                             = GetString(new IntPtr(p + 0x028)); // 0245A46F1290 0x28 FirstNameKana               ( 000186672F10 ModelPrimitiveType string string string String )
            value.LastNameKana                              = GetString(new IntPtr(p + 0x030)); // 0245A46F12B0 0x30 LastNameKana                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Age                                       = GetInt32(new IntPtr(p + 0x038)); // 0245A46F12D0 0x38 Age                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BloodType                                 = GetString(new IntPtr(p + 0x040)); // 0245A46F12F0 0x40 BloodType                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x048)); // 0245A46F1310 0x48 Birthday                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.ZodiacSign                                = GetString(new IntPtr(p + 0x050)); // 0245A46F1330 0x50 ZodiacSign                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.DominantHand                              = GetString(new IntPtr(p + 0x058)); // 0245A46F1350 0x58 DominantHand                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Birthplace                                = GetString(new IntPtr(p + 0x060)); // 0245A46F1370 0x60 Birthplace                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Height                                    = GetString(new IntPtr(p + 0x068)); // 0245A46F1390 0x68 Height                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Weight                                    = GetString(new IntPtr(p + 0x070)); // 0245A46F13B0 0x70 Weight                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.ThreeSizes                                = GetString(new IntPtr(p + 0x078)); // 0245A46F13D0 0x78 ThreeSizes                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Hobby                                     = GetString(new IntPtr(p + 0x080)); // 0245A46F13F0 0x80 Hobby                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.SpecialAbility                            = GetString(new IntPtr(p + 0x088)); // 0245A46F1410 0x88 SpecialAbility              ( 000186672F10 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x090)); // 0245A46F1430 0x90 Description                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.ColorCode                                 = GetString(new IntPtr(p + 0x098)); // 0245A46F1450 0x98 ColorCode                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.MstDefaultCasualCostumeSetId              = GetInt32(new IntPtr(p + 0x0A0)); // 0245A46F1470 0xA0 MstDefaultCasualCostumeSetId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstTracksuitLifeSizeCostumeSetId          = GetInt32(new IntPtr(p + 0x0A4)); // 0245A46F1490 0xA4 MstTracksuitLifeSizeCostumeSetId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstTracksuitCbCostumeSetId                = GetInt32(new IntPtr(p + 0x0A8)); // 0245A46F14B0 0xA8 MstTracksuitCbCostumeSetId  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Shape                                     = GetSingle(new IntPtr(p + 0x0AC)); // 0245A46F14D0 0xAC Shape                       ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.HeadShape                                 = GetSingle(new IntPtr(p + 0x0B0)); // 0245A46F14F0 0xB0 HeadShape                   ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.MotionType                                = GetInt32(new IntPtr(p + 0x0B4)); // 0245A46F1510 0xB4 MotionType                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LightColorCode                            = GetString(new IntPtr(p + 0x0B8)); // 0245A46F1530 0xB8 LightColorCode              ( 000186672F10 ModelPrimitiveType string string string String )
            value.DefaultCasualCostumeSet                   = GetObject<MstCostumeSet>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A46F1550 0xC0 DefaultCasualCostumeSet     ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.TracksuitLifeSizeCostumeSet               = GetObject<MstCostumeSet>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A46F1570 0xC8 TracksuitLifeSizeCostumeSet ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.TracksuitCbCostumeSet                     = GetObject<MstCostumeSet>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A46F1590 0xD0 TracksuitCbCostumeSet       ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )

            return value;
        }
    }
}
