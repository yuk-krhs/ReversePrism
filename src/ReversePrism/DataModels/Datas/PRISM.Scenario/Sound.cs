using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NoVoiceCueSheet                          ModelPrimitiveType bool bool bool Bool
    // 018 CurrentVoiceCueSheet                     ModelPrimitiveType string string string String
    // 020 CueSheetNameList                         ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 028 IsAdv                                    ModelPrimitiveType bool bool bool Bool
    // 029 IsContinueBGM                            ModelPrimitiveType bool bool bool Bool
    // 030 bgmCueSheetNameList                      HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 038 SoundQueue                               ModelClassListType List`1<SoundQueue> List`1<SoundQueue> List<SoundQueue> Pointer
    // 040 dicSetVolume                             Dictionary`2<string, SoundPlayback> IL2CPP_TYPE_GENERICINST
    // 048 voicePlaybacks                           Dictionary`2<string, CriAtomExPlayback> IL2CPP_TYPE_GENERICINST
    public partial class Sound : DataModel
    {
        public bool                                     NoVoiceCueSheet                         { get; set; }
        public string                                   CurrentVoiceCueSheet                    { get; set; }
        public List<string>?                            CueSheetNameList                        { get; set; }
        public bool                                     IsAdv                                   { get; set; }
        public bool                                     IsContinueBGM                           { get; set; }
        public List<SoundQueue>?                        SoundQueue                              { get; set; }

        public static Sound? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Sound() { Pointer= p0 };

            value.NoVoiceCueSheet                           = GetBool(new IntPtr(p + 0x010)); // 0x10 NoVoiceCueSheet             ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentVoiceCueSheet                      = GetString(new IntPtr(p + 0x018)); // 0x18 CurrentVoiceCueSheet        ( ModelPrimitiveType string string string String )
            value.CueSheetNameList                          = GetStringList(new IntPtr(p + 0x020)); // 0x20 CueSheetNameList            ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.IsAdv                                     = GetBool(new IntPtr(p + 0x028)); // 0x28 IsAdv                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsContinueBGM                             = GetBool(new IntPtr(p + 0x029)); // 0x29 IsContinueBGM               ( ModelPrimitiveType bool bool bool Bool )
            value.SoundQueue                                = GetObjectList<SoundQueue>(new IntPtr(p + 0x038), ReversePrism.DataModels.SoundQueue.FromPointer); // 0x38 SoundQueue                  ( ModelClassListType List`1<SoundQueue> List`1<SoundQueue> List<SoundQueue> Pointer )

            return value;
        }
    }
}
