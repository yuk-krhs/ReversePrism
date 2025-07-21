using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              ModelPrimitiveType int int int Int32
    // 018 SpeakerName                              ModelPrimitiveType string string string String
    // 020 ContentText                              ModelPrimitiveType string string string String
    // 028 VoiceId                                  ModelPrimitiveType string string string String
    // 030 CueSheetName                             ModelPrimitiveType string string string String
    // 038 IsChoice                                 ModelPrimitiveType bool bool bool Bool
    // 040 CharacterIconPathForNotIdol              ModelPrimitiveType string string string String
    public partial class AdvTextLogTalkCellViewModel : DataModel
    {
        public int                                      CharacterId                             { get; set; }
        public string                                   SpeakerName                             { get; set; }
        public string                                   ContentText                             { get; set; }
        public string                                   VoiceId                                 { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public bool                                     IsChoice                                { get; set; }
        public string                                   CharacterIconPathForNotIdol             { get; set; }

        public static AdvTextLogTalkCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvTextLogTalkCellViewModel() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x018)); // 0x18 SpeakerName                 ( ModelPrimitiveType string string string String )
            value.ContentText                               = GetString(new IntPtr(p + 0x020)); // 0x20 ContentText                 ( ModelPrimitiveType string string string String )
            value.VoiceId                                   = GetString(new IntPtr(p + 0x028)); // 0x28 VoiceId                     ( ModelPrimitiveType string string string String )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x030)); // 0x30 CueSheetName                ( ModelPrimitiveType string string string String )
            value.IsChoice                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 IsChoice                    ( ModelPrimitiveType bool bool bool Bool )
            value.CharacterIconPathForNotIdol               = GetString(new IntPtr(p + 0x040)); // 0x40 CharacterIconPathForNotIdol ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
