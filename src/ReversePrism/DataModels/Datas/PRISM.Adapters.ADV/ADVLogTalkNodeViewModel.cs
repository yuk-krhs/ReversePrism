using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  ModelPrimitiveType int int int Int32
    // 018 CharacterInfo                            ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 020 SpeakerName                              ModelPrimitiveType string string string String
    // 028 Content                                  ModelPrimitiveType string string string String
    // 030 VoiceId                                  ModelPrimitiveType string string string String
    // 038 CueSheetName                             ModelPrimitiveType string string string String
    // 040 IsChoice                                 ModelPrimitiveType bool bool bool Bool
    public partial class ADVLogTalkNodeViewModel : DataModel
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
            var value   = new ADVLogTalkNodeViewModel() { Pointer= p0 };

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x18 CharacterInfo               ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x020)); // 0x20 SpeakerName                 ( ModelPrimitiveType string string string String )
            value.Content                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Content                     ( ModelPrimitiveType string string string String )
            value.VoiceId                                   = GetString(new IntPtr(p + 0x030)); // 0x30 VoiceId                     ( ModelPrimitiveType string string string String )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x038)); // 0x38 CueSheetName                ( ModelPrimitiveType string string string String )
            value.IsChoice                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 IsChoice                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
