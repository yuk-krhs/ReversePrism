using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterIconModels                      000185B8E810 ModelClassListType IntroductionCharacterIconViewModel[] IntroductionCharacterIconViewModel[] List<IntroductionCharacterIconViewModel> Pointer
    // 018 VoicePattern                             0001866E3DC0 ModelClassType UICharacterVoicePattern UICharacterVoicePattern UICharacterVoicePattern Pointer
    // 020 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    public partial class IntroductionCharacterSelectViewModel : DataModel
    {
        public List<IntroductionCharacterIconViewModel>? CharacterIconModels                     { get; set; }
        public UICharacterVoicePattern?                 VoicePattern                            { get; set; }
        public string                                   CueSheetName                            { get; set; }

        public static IntroductionCharacterSelectViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectViewModel() { Pointer= p0 };

            value.CharacterIconModels                       = GetObjectList<IntroductionCharacterIconViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntroductionCharacterIconViewModel.FromPointer); // 02466640AED8 0x10 CharacterIconModels         ( 000185B8E810 ModelClassListType IntroductionCharacterIconViewModel[] IntroductionCharacterIconViewModel[] List<IntroductionCharacterIconViewModel> Pointer )
            value.VoicePattern                              = GetObject<UICharacterVoicePattern>(new IntPtr(p + 0x018), ReversePrism.DataModels.UICharacterVoicePattern.FromPointer); // 02466640AEF8 0x18 VoicePattern                ( 0001866E3DC0 ModelClassType UICharacterVoicePattern UICharacterVoicePattern UICharacterVoicePattern Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x020)); // 02466640AF18 0x20 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
