using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSpeakProducer                          ModelPrimitiveType bool bool bool Bool
    // 014 SpeakDuration                            ModelPrimitiveType float float float Single
    // 018 RegisterSpeak                            ModelPrimitiveType bool bool bool Bool
    // 01C BeforeSpeakTime                          ModelPrimitiveType float float float Single
    // 020 SoundPlayer                              ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 028 IsSoundLoaded                            ModelPrimitiveType bool bool bool Bool
    // 030 CueSheetName                             ModelPrimitiveType string string string String
    // 038 CueName                                  ModelPrimitiveType string string string String
    public partial class ProducerSpeaker : DataModel
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
            var value   = new ProducerSpeaker() { Pointer= p0 };

            value.IsSpeakProducer                           = GetBool(new IntPtr(p + 0x010)); // 0x10 IsSpeakProducer             ( ModelPrimitiveType bool bool bool Bool )
            value.SpeakDuration                             = GetSingle(new IntPtr(p + 0x014)); // 0x14 SpeakDuration               ( ModelPrimitiveType float float float Single )
            value.RegisterSpeak                             = GetBool(new IntPtr(p + 0x018)); // 0x18 RegisterSpeak               ( ModelPrimitiveType bool bool bool Bool )
            value.BeforeSpeakTime                           = GetSingle(new IntPtr(p + 0x01C)); // 0x1C BeforeSpeakTime             ( ModelPrimitiveType float float float Single )
            value.SoundPlayer                               = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x20 SoundPlayer                 ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.IsSoundLoaded                             = GetBool(new IntPtr(p + 0x028)); // 0x28 IsSoundLoaded               ( ModelPrimitiveType bool bool bool Bool )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x030)); // 0x30 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x038)); // 0x38 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
