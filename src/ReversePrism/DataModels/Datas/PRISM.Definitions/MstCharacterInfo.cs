using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 FirstNameRoma                            ModelPrimitiveType string string string String
    // 020 LastNameRoma                             ModelPrimitiveType string string string String
    // 028 FirstNameKana                            ModelPrimitiveType string string string String
    // 030 LastNameKana                             ModelPrimitiveType string string string String
    // 038 Age                                      ModelPrimitiveType int int int Int32
    // 040 BloodType                                ModelPrimitiveType string string string String
    // 048 Birthday                                 ModelPrimitiveType string string string String
    // 050 ZodiacSign                               ModelPrimitiveType string string string String
    // 058 DominantHand                             ModelPrimitiveType string string string String
    // 060 Birthplace                               ModelPrimitiveType string string string String
    // 068 Height                                   ModelPrimitiveType string string string String
    // 070 Weight                                   ModelPrimitiveType string string string String
    // 078 ThreeSizes                               ModelPrimitiveType string string string String
    // 080 Hobby                                    ModelPrimitiveType string string string String
    // 088 SpecialAbility                           ModelPrimitiveType string string string String
    // 090 Description                              ModelPrimitiveType string string string String
    // 098 ColorCode                                ModelPrimitiveType string string string String
    // 0A0 MstDefaultCasualCostumeSetId             ModelPrimitiveType int int int Int32
    // 0A4 MstTracksuitLifeSizeCostumeSetId         ModelPrimitiveType int int int Int32
    // 0A8 MstTracksuitCbCostumeSetId               ModelPrimitiveType int int int Int32
    // 0AC Shape                                    ModelPrimitiveType float float float Single
    // 0B0 HeadShape                                ModelPrimitiveType float float float Single
    // 0B4 MotionType                               ModelPrimitiveType int int int Int32
    // 0B8 LightColorCode                           ModelPrimitiveType string string string String
    // 0C0 DefaultCasualCostumeSet                  ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 0C8 TracksuitLifeSizeCostumeSet              ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 0D0 TracksuitCbCostumeSet                    ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.FirstNameRoma                             = GetString(new IntPtr(p + 0x018)); // 0x18 FirstNameRoma               ( ModelPrimitiveType string string string String )
            value.LastNameRoma                              = GetString(new IntPtr(p + 0x020)); // 0x20 LastNameRoma                ( ModelPrimitiveType string string string String )
            value.FirstNameKana                             = GetString(new IntPtr(p + 0x028)); // 0x28 FirstNameKana               ( ModelPrimitiveType string string string String )
            value.LastNameKana                              = GetString(new IntPtr(p + 0x030)); // 0x30 LastNameKana                ( ModelPrimitiveType string string string String )
            value.Age                                       = GetInt32(new IntPtr(p + 0x038)); // 0x38 Age                         ( ModelPrimitiveType int int int Int32 )
            value.BloodType                                 = GetString(new IntPtr(p + 0x040)); // 0x40 BloodType                   ( ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x048)); // 0x48 Birthday                    ( ModelPrimitiveType string string string String )
            value.ZodiacSign                                = GetString(new IntPtr(p + 0x050)); // 0x50 ZodiacSign                  ( ModelPrimitiveType string string string String )
            value.DominantHand                              = GetString(new IntPtr(p + 0x058)); // 0x58 DominantHand                ( ModelPrimitiveType string string string String )
            value.Birthplace                                = GetString(new IntPtr(p + 0x060)); // 0x60 Birthplace                  ( ModelPrimitiveType string string string String )
            value.Height                                    = GetString(new IntPtr(p + 0x068)); // 0x68 Height                      ( ModelPrimitiveType string string string String )
            value.Weight                                    = GetString(new IntPtr(p + 0x070)); // 0x70 Weight                      ( ModelPrimitiveType string string string String )
            value.ThreeSizes                                = GetString(new IntPtr(p + 0x078)); // 0x78 ThreeSizes                  ( ModelPrimitiveType string string string String )
            value.Hobby                                     = GetString(new IntPtr(p + 0x080)); // 0x80 Hobby                       ( ModelPrimitiveType string string string String )
            value.SpecialAbility                            = GetString(new IntPtr(p + 0x088)); // 0x88 SpecialAbility              ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x090)); // 0x90 Description                 ( ModelPrimitiveType string string string String )
            value.ColorCode                                 = GetString(new IntPtr(p + 0x098)); // 0x98 ColorCode                   ( ModelPrimitiveType string string string String )
            value.MstDefaultCasualCostumeSetId              = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MstDefaultCasualCostumeSetId ( ModelPrimitiveType int int int Int32 )
            value.MstTracksuitLifeSizeCostumeSetId          = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 MstTracksuitLifeSizeCostumeSetId ( ModelPrimitiveType int int int Int32 )
            value.MstTracksuitCbCostumeSetId                = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 MstTracksuitCbCostumeSetId  ( ModelPrimitiveType int int int Int32 )
            value.Shape                                     = GetSingle(new IntPtr(p + 0x0AC)); // 0xAC Shape                       ( ModelPrimitiveType float float float Single )
            value.HeadShape                                 = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 HeadShape                   ( ModelPrimitiveType float float float Single )
            value.MotionType                                = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 MotionType                  ( ModelPrimitiveType int int int Int32 )
            value.LightColorCode                            = GetString(new IntPtr(p + 0x0B8)); // 0xB8 LightColorCode              ( ModelPrimitiveType string string string String )
            value.DefaultCasualCostumeSet                   = GetObject<MstCostumeSet>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0xC0 DefaultCasualCostumeSet     ( ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.TracksuitLifeSizeCostumeSet               = GetObject<MstCostumeSet>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0xC8 TracksuitLifeSizeCostumeSet ( ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.TracksuitCbCostumeSet                     = GetObject<MstCostumeSet>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0xD0 TracksuitCbCostumeSet       ( ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )

            return value;
        }
    }
}
