using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 018 Rarity                                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 01C BeforeLv                                 ModelPrimitiveType int int int Int32
    // 020 AfterLv                                  ModelPrimitiveType int int int Int32
    // 028 EffectContents                           ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer
    // 030 CueSheetName                             ModelPrimitiveType string string string String
    // 038 CueName                                  ModelPrimitiveType string string string String
    public partial class SupportCharaLvUpCompletedPopupViewModel : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public int                                      BeforeLv                                { get; set; }
        public int                                      AfterLv                                 { get; set; }
        public List<SupportEffectContentViewModel>?     EffectContents                          { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }

        public static SupportCharaLvUpCompletedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaLvUpCompletedPopupViewModel() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x018)); // 0x18 Rarity                      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C BeforeLv                    ( ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 AfterLv                     ( ModelPrimitiveType int int int Int32 )
            value.EffectContents                            = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0x28 EffectContents              ( ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x030)); // 0x30 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x038)); // 0x38 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
