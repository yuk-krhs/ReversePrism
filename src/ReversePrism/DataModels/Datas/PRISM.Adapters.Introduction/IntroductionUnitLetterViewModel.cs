using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewTitle                                000186672F10 ModelPrimitiveType string string string String
    // 018 UnitSelectCellDataList                   000185D122A8 ModelClassListType IReadOnlyList`1<IntroductionUnitSelectCellData> IReadOnlyList`1<IntroductionUnitSelectCellData> List<IntroductionUnitSelectCellData> Pointer
    // 020 HazukiVoicePattern                       0001866E3DC0 ModelClassType UICharacterVoicePattern UICharacterVoicePattern UICharacterVoicePattern Pointer
    // 028 HazukiScreenType                         000186617410 ModelEnumType ScreenType ScreenType ScreenType Int32
    // 030 HazukiRequiredMotionCueSheetName         000186672F10 ModelPrimitiveType string string string String
    public partial class IntroductionUnitLetterViewModel : DataModel
    {
        public string                                   ViewTitle                               { get; set; }
        public List<IntroductionUnitSelectCellData>?    UnitSelectCellDataList                  { get; set; }
        public UICharacterVoicePattern?                 HazukiVoicePattern                      { get; set; }
        public ScreenType                               HazukiScreenType                        { get; set; }
        public string                                   HazukiRequiredMotionCueSheetName        { get; set; }

        public static IntroductionUnitLetterViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterViewModel() { Pointer= p0 };

            value.ViewTitle                                 = GetString(new IntPtr(p + 0x010)); // 0246668A0838 0x10 ViewTitle                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.UnitSelectCellDataList                    = GetObjectList<IntroductionUnitSelectCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionUnitSelectCellData.FromPointer); // 0246668A0858 0x18 UnitSelectCellDataList      ( 000185D122A8 ModelClassListType IReadOnlyList`1<IntroductionUnitSelectCellData> IReadOnlyList`1<IntroductionUnitSelectCellData> List<IntroductionUnitSelectCellData> Pointer )
            value.HazukiVoicePattern                        = GetObject<UICharacterVoicePattern>(new IntPtr(p + 0x020), ReversePrism.DataModels.UICharacterVoicePattern.FromPointer); // 0246668A0878 0x20 HazukiVoicePattern          ( 0001866E3DC0 ModelClassType UICharacterVoicePattern UICharacterVoicePattern UICharacterVoicePattern Pointer )
            value.HazukiScreenType                          = (ScreenType)GetInt32(new IntPtr(p + 0x028)); // 0246668A0898 0x28 HazukiScreenType            ( 000186617410 ModelEnumType ScreenType ScreenType ScreenType Int32 )
            value.HazukiRequiredMotionCueSheetName          = GetString(new IntPtr(p + 0x030)); // 0246668A08B8 0x30 HazukiRequiredMotionCueSheetName ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
