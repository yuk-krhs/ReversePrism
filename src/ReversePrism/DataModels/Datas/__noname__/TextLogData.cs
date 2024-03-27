using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SpeakerID                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 SpeakerName                              0001866722E0 ModelPrimitiveType string string string String
    // 020 VoiceID                                  0001866722E0 ModelPrimitiveType string string string String
    // 028 Text                                     0001866722E0 ModelPrimitiveType string string string String
    // 030 IsChoice                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TextLogData
    {
        public int                                      SpeakerID                               { get; set; }
        public string                                   SpeakerName                             { get; set; }
        public string                                   VoiceID                                 { get; set; }
        public string                                   Text                                    { get; set; }
        public bool                                     IsChoice                                { get; set; }

        public static TextLogData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextLogData();

            value.SpeakerID                                 = GetInt32(new IntPtr(p + 0x010)); // 0270035FD060 0x10 SpeakerID                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x018)); // 0270035FD080 0x18 SpeakerName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.VoiceID                                   = GetString(new IntPtr(p + 0x020)); // 0270035FD0A0 0x20 VoiceID                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x028)); // 0270035FD0C0 0x28 Text                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsChoice                                  = GetBool(new IntPtr(p + 0x030)); // 0270035FD0E0 0x30 IsChoice                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
