using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  000186671910 ModelPrimitiveType string string string String
    // 018 SpeakerName                              000186671910 ModelPrimitiveType string string string String
    // 020 Content                                  000186671910 ModelPrimitiveType string string string String
    // 028 VoiceId                                  000186671910 ModelPrimitiveType string string string String
    // 030 IsChoice                                 000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.CharaId                                   = GetString(new IntPtr(p + 0x010)); // 02466698FD68 0x10 CharaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x018)); // 02466698FD88 0x18 SpeakerName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Content                                   = GetString(new IntPtr(p + 0x020)); // 02466698FDA8 0x20 Content                     ( 000186671910 ModelPrimitiveType string string string String )
            value.VoiceId                                   = GetString(new IntPtr(p + 0x028)); // 02466698FDC8 0x28 VoiceId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.IsChoice                                  = GetBool(new IntPtr(p + 0x030)); // 02466698FDE8 0x30 IsChoice                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
