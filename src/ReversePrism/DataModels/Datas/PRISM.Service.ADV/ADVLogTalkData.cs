using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  ModelPrimitiveType string string string String
    // 018 SpeakerName                              ModelPrimitiveType string string string String
    // 020 Content                                  ModelPrimitiveType string string string String
    // 028 VoiceId                                  ModelPrimitiveType string string string String
    // 030 IsChoice                                 ModelPrimitiveType bool bool bool Bool
    public partial class ADVLogTalkData : DataModel
    {
        public string                                   CharaId                                 { get; set; }
        public string                                   SpeakerName                             { get; set; }
        public string                                   Content                                 { get; set; }
        public string                                   VoiceId                                 { get; set; }
        public bool                                     IsChoice                                { get; set; }

        public static ADVLogTalkData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogTalkData() { Pointer= p0 };

            value.CharaId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 CharaId                     ( ModelPrimitiveType string string string String )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x018)); // 0x18 SpeakerName                 ( ModelPrimitiveType string string string String )
            value.Content                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Content                     ( ModelPrimitiveType string string string String )
            value.VoiceId                                   = GetString(new IntPtr(p + 0x028)); // 0x28 VoiceId                     ( ModelPrimitiveType string string string String )
            value.IsChoice                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 IsChoice                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
