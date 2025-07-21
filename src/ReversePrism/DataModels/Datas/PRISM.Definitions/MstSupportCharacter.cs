using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstCharacterId                           ModelPrimitiveType int int int Int32
    // 018 Rarity                                   ModelPrimitiveType int int int Int32
    // 01C CardId                                   ModelPrimitiveType int int int Int32
    // 020 GoodScheduleDetailType                   ModelPrimitiveType int int int Int32
    // 028 MstPotentialSupportSkillIdList           ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 MstSupportCharacterEventIdList           ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 MstSupportEffectIdList                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 UnlockPremiseLevelList                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 LimitBreakRecipeProductId                ModelPrimitiveType string string string String
    // 058 SignPositionIndex                        ModelPrimitiveType int int int Int32
    // 060 CharacterInfo                            ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    public partial class MstSupportCharacter : DataModel
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
            var value   = new MstSupportCharacter() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterId                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterId              ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CardId                      ( ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 GoodScheduleDetailType      ( ModelPrimitiveType int int int Int32 )
            value.MstPotentialSupportSkillIdList            = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MstPotentialSupportSkillIdList ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstSupportCharacterEventIdList            = GetInt32List(new IntPtr(p + 0x030)); // 0x30 MstSupportCharacterEventIdList ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstSupportEffectIdList                    = GetInt32List(new IntPtr(p + 0x038)); // 0x38 MstSupportEffectIdList      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseLevelList                    = GetInt32List(new IntPtr(p + 0x040)); // 0x40 UnlockPremiseLevelList      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x048)); // 0x48 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LimitBreakRecipeProductId                 = GetString(new IntPtr(p + 0x050)); // 0x50 LimitBreakRecipeProductId   ( ModelPrimitiveType string string string String )
            value.SignPositionIndex                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 SignPositionIndex           ( ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x60 CharacterInfo               ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )

            return value;
        }
    }
}
