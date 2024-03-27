using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 01C CardId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 GoodScheduleDetailType                   0001865F4260 ModelPrimitiveType int int int Int32
    // 028 MstPotentialSupportSkillIdList           000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 MstSupportCharacterEventIdList           000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 MstSupportEffectIdList                   000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 UnlockPremiseLevelList                   000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 LimitBreakRecipeProductId                000186672F10 ModelPrimitiveType string string string String
    // 058 SignPositionIndex                        0001865F4260 ModelPrimitiveType int int int Int32
    // 060 CharacterInfo                            00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    public partial class MstSupportCharacter
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterId                          { get; set; }
        public int                                      Rarity                                  { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      GoodScheduleDetailType                  { get; set; }
        public List<int>?                               MstPotentialSupportSkillIdList          { get; set; }
        public List<int>?                               MstSupportCharacterEventIdList          { get; set; }
        public List<int>?                               MstSupportEffectIdList                  { get; set; }
        public List<int>?                               UnlockPremiseLevelList                  { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public string                                   LimitBreakRecipeProductId               { get; set; }
        public int                                      SignPositionIndex                       { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }

        public static MstSupportCharacter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSupportCharacter();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045C50B0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterId                            = GetInt32(new IntPtr(p + 0x014)); // 0270045C50D0 0x14 MstCharacterId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x018)); // 0270045C50F0 0x18 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270045C5110 0x1C CardId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = GetInt32(new IntPtr(p + 0x020)); // 0270045C5130 0x20 GoodScheduleDetailType      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstPotentialSupportSkillIdList            = GetInt32List(new IntPtr(p + 0x028)); // 0270045C5150 0x28 MstPotentialSupportSkillIdList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstSupportCharacterEventIdList            = GetInt32List(new IntPtr(p + 0x030)); // 0270045C5170 0x30 MstSupportCharacterEventIdList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstSupportEffectIdList                    = GetInt32List(new IntPtr(p + 0x038)); // 0270045C5190 0x38 MstSupportEffectIdList      ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseLevelList                    = GetInt32List(new IntPtr(p + 0x040)); // 0270045C51B0 0x40 UnlockPremiseLevelList      ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x048)); // 0270045C51D0 0x48 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LimitBreakRecipeProductId                 = GetString(new IntPtr(p + 0x050)); // 0270045C51F0 0x50 LimitBreakRecipeProductId   ( 000186672F10 ModelPrimitiveType string string string String )
            value.SignPositionIndex                         = GetInt32(new IntPtr(p + 0x058)); // 0270045C5210 0x58 SignPositionIndex           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0270045C5230 0x60 CharacterInfo               ( 00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )

            return value;
        }
    }
}
