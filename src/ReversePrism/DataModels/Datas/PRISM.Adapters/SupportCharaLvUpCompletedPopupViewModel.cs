using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSupportCharacterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Rarity                                   0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 01C BeforeLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 AfterLv                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 028 EffectContents                           000185D10AD8 ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer
    // 030 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    // 038 CueName                                  000186672F10 ModelPrimitiveType string string string String
    public partial class SupportCharaLvUpCompletedPopupViewModel
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
            var value   = new SupportCharaLvUpCompletedPopupViewModel();

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x010)); // 0270D5F95D40 0x10 MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0270D5F95D60 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x018)); // 0270D5F95D80 0x18 Rarity                      ( 0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D5F95DA0 0x1C BeforeLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D5F95DC0 0x20 AfterLv                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectContents                            = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0270D5F95DE0 0x28 EffectContents              ( 000185D10AD8 ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x030)); // 0270D5F95E00 0x30 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x038)); // 0270D5F95E20 0x38 CueName                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
