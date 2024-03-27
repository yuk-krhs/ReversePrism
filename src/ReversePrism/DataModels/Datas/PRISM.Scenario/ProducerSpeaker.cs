using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSpeakProducer                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 SpeakDuration                            0001866656B0 ModelPrimitiveType float float float Single
    // 018 RegisterSpeak                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C BeforeSpeakTime                          0001866656B0 ModelPrimitiveType float float float Single
    // 020 SoundPlayer                              000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 028 IsSoundLoaded                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    // 038 CueName                                  000186672F10 ModelPrimitiveType string string string String
    public partial class ProducerSpeaker
    {
        public bool                                     IsSpeakProducer                         { get; set; }
        public float                                    SpeakDuration                           { get; set; }
        public bool                                     RegisterSpeak                           { get; set; }
        public float                                    BeforeSpeakTime                         { get; set; }
        public CriAtomExPlayer?                         SoundPlayer                             { get; set; }
        public bool                                     IsSoundLoaded                           { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }

        public static ProducerSpeaker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducerSpeaker();

            value.IsSpeakProducer                           = GetBool(new IntPtr(p + 0x010)); // 027006991EE0 0x10 IsSpeakProducer             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SpeakDuration                             = GetSingle(new IntPtr(p + 0x014)); // 027006991F00 0x14 SpeakDuration               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RegisterSpeak                             = GetBool(new IntPtr(p + 0x018)); // 027006991F20 0x18 RegisterSpeak               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BeforeSpeakTime                           = GetSingle(new IntPtr(p + 0x01C)); // 027006991F40 0x1C BeforeSpeakTime             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SoundPlayer                               = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 027006991F60 0x20 SoundPlayer                 ( 000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.IsSoundLoaded                             = GetBool(new IntPtr(p + 0x028)); // 027006991F80 0x28 IsSoundLoaded               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x030)); // 027006991FA0 0x30 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x038)); // 027006991FC0 0x38 CueName                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
