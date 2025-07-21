using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SpeakerID                                ModelPrimitiveType int int int Int32
    // 018 SpeakerName                              ModelPrimitiveType string string string String
    // 020 VoiceID                                  ModelPrimitiveType string string string String
    // 028 Text                                     ModelPrimitiveType string string string String
    // 030 IsChoice                                 ModelPrimitiveType bool bool bool Bool
    public partial class TextLogData : DataModel
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
            var value   = new TextLogData() { Pointer= p0 };

            value.SpeakerID                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 SpeakerID                   ( ModelPrimitiveType int int int Int32 )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x018)); // 0x18 SpeakerName                 ( ModelPrimitiveType string string string String )
            value.VoiceID                                   = GetString(new IntPtr(p + 0x020)); // 0x20 VoiceID                     ( ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Text                        ( ModelPrimitiveType string string string String )
            value.IsChoice                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 IsChoice                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
