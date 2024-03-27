using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 CharacterInfo                            00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 020 SpeakerName                              000186671910 ModelPrimitiveType string string string String
    // 028 Content                                  000186671910 ModelPrimitiveType string string string String
    // 030 VoiceId                                  000186671910 ModelPrimitiveType string string string String
    // 038 CueSheetName                             000186671910 ModelPrimitiveType string string string String
    // 040 IsChoice                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ADVLogTalkNodeViewModel
    {
        public int                                      CharaId                                 { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }
        public string                                   SpeakerName                             { get; set; }
        public string                                   Content                                 { get; set; }
        public string                                   VoiceId                                 { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public bool                                     IsChoice                                { get; set; }

        public static ADVLogTalkNodeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogTalkNodeViewModel();

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D691ECB8 0x10 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0270D691ECD8 0x18 CharacterInfo               ( 00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x020)); // 0270D691ECF8 0x20 SpeakerName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Content                                   = GetString(new IntPtr(p + 0x028)); // 0270D691ED18 0x28 Content                     ( 000186671910 ModelPrimitiveType string string string String )
            value.VoiceId                                   = GetString(new IntPtr(p + 0x030)); // 0270D691ED38 0x30 VoiceId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x038)); // 0270D691ED58 0x38 CueSheetName                ( 000186671910 ModelPrimitiveType string string string String )
            value.IsChoice                                  = GetBool(new IntPtr(p + 0x040)); // 0270D691ED78 0x40 IsChoice                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
