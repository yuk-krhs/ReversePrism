using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AcfFileName                              0001866722E0 ModelPrimitiveType string string string String
    // 018 MaxVirtualVoices                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C MaxVoiceLimitGroups                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 MaxCategories                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 MaxAisacs                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 MaxBusSends                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C MaxSequenceEventsPerFrame                0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 MaxBeatSyncCallbacksPerFrame             0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 MaxCueLinkCallbacksPerFrame              0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 StandardVoicePoolConfig                  00018653C610 ModelClassType StandardVoicePoolConfig StandardVoicePoolConfig StandardVoicePoolConfig Pointer
    // 040 HcaMxVoicePoolConfig                     000186539C70 ModelClassType HcaMxVoicePoolConfig HcaMxVoicePoolConfig HcaMxVoicePoolConfig Pointer
    // 048 OutputSamplingRate                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 04C UsesInGamePreview                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 InGamePreviewMode                        00018653A700 ModelEnumType InGamePreviewSwitchMode InGamePreviewSwitchMode InGamePreviewSwitchMode Int32
    // 054 SwitchInitializeSocket                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 058 InGamePreviewConfig                      00018653A1D0 ModelClassType InGamePreviewConfig InGamePreviewConfig InGamePreviewConfig Pointer
    // 060 ServerFrequency                          000186666050 ModelPrimitiveType float float float Single
    // 064 AsrOutputChannels                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 068 UseRandomSeedWithTime                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 06C CategoriesPerPlayback                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 070 MaxFaders                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 074 MaxBuses                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 078 MaxParameterBlocks                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 07C VrMode                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 07D KeepPlayingSoundOnPause                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 080 EditorPcmOutputConfig                    000186539780 ModelClassType EditorPcmOutputConfig EditorPcmOutputConfig EditorPcmOutputConfig Pointer
    // 088 PcBufferingTime                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 08C LinuxOutput                              00018653AEA0 ModelEnumType LinuxOutput LinuxOutput LinuxOutput Int32
    // 090 LinuxPulseLatencyUsec                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 094 IosEnableSonicSync                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 098 IosBufferingTime                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 09C IosOverrideIPodMusic                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 09D AndroidEnableSonicSync                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A0 AndroidBufferingTime                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A4 AndroidStartBufferingTime                0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A8 AndroidLowLatencyStandardVoicePoolConfig 000186539250 ModelClassType AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig Pointer
    // 0B0 AndroidUsesAndroidFastMixer              000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B1 AndroidForceToUseAsrForDefaultPlayback   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B2 AndroidUsesAAudio                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B4 AndroidStreamType                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B8 VitaManaVoicePoolConfig                  00018653D5D0 ModelClassType VitaManaVoicePoolConfig VitaManaVoicePoolConfig VitaManaVoicePoolConfig Pointer
    // 0C0 VitaAtrac9VoicePoolConfig                00018653D070 ModelClassType VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig Pointer
    // 0C8 Ps4Atrac9VoicePoolConfig                 00018653B670 ModelClassType Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Pointer
    // 0D0 Ps5PortConfig                            00018653C0D0 ModelClassType Ps5PortConfig Ps5PortConfig Ps5PortConfig Pointer
    // 0D8 SwitchEnableSonicSync                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 0E0 SwitchOpusVoicePoolConfig                00018653CB30 ModelClassType SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig Pointer
    // 0E8 Ps4Audio3dConfig                         00018653BB90 ModelClassType Ps4Audio3dConfig Ps4Audio3dConfig Ps4Audio3dConfig Pointer
    // 0F0 WebglWebAudioVoicePoolConfig             00018653DB10 ModelClassType WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig Pointer
    public partial class CriAtomConfig
    {
        public string                                   AcfFileName                             { get; set; }
        public int                                      MaxVirtualVoices                        { get; set; }
        public int                                      MaxVoiceLimitGroups                     { get; set; }
        public int                                      MaxCategories                           { get; set; }
        public int                                      MaxAisacs                               { get; set; }
        public int                                      MaxBusSends                             { get; set; }
        public int                                      MaxSequenceEventsPerFrame               { get; set; }
        public int                                      MaxBeatSyncCallbacksPerFrame            { get; set; }
        public int                                      MaxCueLinkCallbacksPerFrame             { get; set; }
        public StandardVoicePoolConfig?                 StandardVoicePoolConfig                 { get; set; }
        public HcaMxVoicePoolConfig?                    HcaMxVoicePoolConfig                    { get; set; }
        public int                                      OutputSamplingRate                      { get; set; }
        public bool                                     UsesInGamePreview                       { get; set; }
        public InGamePreviewSwitchMode                  InGamePreviewMode                       { get; set; }
        public bool                                     SwitchInitializeSocket                  { get; set; }
        public InGamePreviewConfig?                     InGamePreviewConfig                     { get; set; }
        public float                                    ServerFrequency                         { get; set; }
        public int                                      AsrOutputChannels                       { get; set; }
        public bool                                     UseRandomSeedWithTime                   { get; set; }
        public int                                      CategoriesPerPlayback                   { get; set; }
        public int                                      MaxFaders                               { get; set; }
        public int                                      MaxBuses                                { get; set; }
        public int                                      MaxParameterBlocks                      { get; set; }
        public bool                                     VrMode                                  { get; set; }
        public bool                                     KeepPlayingSoundOnPause                 { get; set; }
        public EditorPcmOutputConfig?                   EditorPcmOutputConfig                   { get; set; }
        public int                                      PcBufferingTime                         { get; set; }
        public LinuxOutput                              LinuxOutput                             { get; set; }
        public int                                      LinuxPulseLatencyUsec                   { get; set; }
        public bool                                     IosEnableSonicSync                      { get; set; }
        public int                                      IosBufferingTime                        { get; set; }
        public bool                                     IosOverrideIPodMusic                    { get; set; }
        public bool                                     AndroidEnableSonicSync                  { get; set; }
        public int                                      AndroidBufferingTime                    { get; set; }
        public int                                      AndroidStartBufferingTime               { get; set; }
        public AndroidLowLatencyStandardVoicePoolConfig? AndroidLowLatencyStandardVoicePoolConfig { get; set; }
        public bool                                     AndroidUsesAndroidFastMixer             { get; set; }
        public bool                                     AndroidForceToUseAsrForDefaultPlayback  { get; set; }
        public bool                                     AndroidUsesAAudio                       { get; set; }
        public int                                      AndroidStreamType                       { get; set; }
        public VitaManaVoicePoolConfig?                 VitaManaVoicePoolConfig                 { get; set; }
        public VitaAtrac9VoicePoolConfig?               VitaAtrac9VoicePoolConfig               { get; set; }
        public Ps4Atrac9VoicePoolConfig?                Ps4Atrac9VoicePoolConfig                { get; set; }
        public Ps5PortConfig?                           Ps5PortConfig                           { get; set; }
        public bool                                     SwitchEnableSonicSync                   { get; set; }
        public SwitchOpusVoicePoolConfig?               SwitchOpusVoicePoolConfig               { get; set; }
        public Ps4Audio3dConfig?                        Ps4Audio3dConfig                        { get; set; }
        public WebGLWebAudioVoicePoolConfig?            WebglWebAudioVoicePoolConfig            { get; set; }

        public static CriAtomConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomConfig();

            value.AcfFileName                               = GetString(new IntPtr(p + 0x010)); // 0270D116FD00 0x10 AcfFileName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MaxVirtualVoices                          = GetInt32(new IntPtr(p + 0x018)); // 0270D116FD20 0x18 MaxVirtualVoices            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxVoiceLimitGroups                       = GetInt32(new IntPtr(p + 0x01C)); // 0270D116FD40 0x1C MaxVoiceLimitGroups         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxCategories                             = GetInt32(new IntPtr(p + 0x020)); // 0270D116FD60 0x20 MaxCategories               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxAisacs                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D116FD80 0x24 MaxAisacs                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxBusSends                               = GetInt32(new IntPtr(p + 0x028)); // 0270D116FDA0 0x28 MaxBusSends                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxSequenceEventsPerFrame                 = GetInt32(new IntPtr(p + 0x02C)); // 0270D116FDC0 0x2C MaxSequenceEventsPerFrame   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxBeatSyncCallbacksPerFrame              = GetInt32(new IntPtr(p + 0x030)); // 0270D116FDE0 0x30 MaxBeatSyncCallbacksPerFrame ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxCueLinkCallbacksPerFrame               = GetInt32(new IntPtr(p + 0x034)); // 0270D116FE00 0x34 MaxCueLinkCallbacksPerFrame ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StandardVoicePoolConfig                   = GetObject<StandardVoicePoolConfig>(new IntPtr(p + 0x038), ReversePrism.DataModels.StandardVoicePoolConfig.FromPointer); // 0270D116FE20 0x38 StandardVoicePoolConfig     ( 00018653C610 ModelClassType StandardVoicePoolConfig StandardVoicePoolConfig StandardVoicePoolConfig Pointer )
            value.HcaMxVoicePoolConfig                      = GetObject<HcaMxVoicePoolConfig>(new IntPtr(p + 0x040), ReversePrism.DataModels.HcaMxVoicePoolConfig.FromPointer); // 0270D116FE40 0x40 HcaMxVoicePoolConfig        ( 000186539C70 ModelClassType HcaMxVoicePoolConfig HcaMxVoicePoolConfig HcaMxVoicePoolConfig Pointer )
            value.OutputSamplingRate                        = GetInt32(new IntPtr(p + 0x048)); // 0270D116FE60 0x48 OutputSamplingRate          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UsesInGamePreview                         = GetBool(new IntPtr(p + 0x04C)); // 0270D116FE80 0x4C UsesInGamePreview           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.InGamePreviewMode                         = (InGamePreviewSwitchMode)GetInt32(new IntPtr(p + 0x050)); // 0270D116FEA0 0x50 InGamePreviewMode           ( 00018653A700 ModelEnumType InGamePreviewSwitchMode InGamePreviewSwitchMode InGamePreviewSwitchMode Int32 )
            value.SwitchInitializeSocket                    = GetBool(new IntPtr(p + 0x054)); // 0270D116FEC0 0x54 SwitchInitializeSocket      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.InGamePreviewConfig                       = GetObject<InGamePreviewConfig>(new IntPtr(p + 0x058), ReversePrism.DataModels.InGamePreviewConfig.FromPointer); // 0270D116FEE0 0x58 InGamePreviewConfig         ( 00018653A1D0 ModelClassType InGamePreviewConfig InGamePreviewConfig InGamePreviewConfig Pointer )
            value.ServerFrequency                           = GetSingle(new IntPtr(p + 0x060)); // 0270D116FF00 0x60 ServerFrequency             ( 000186666050 ModelPrimitiveType float float float Single )
            value.AsrOutputChannels                         = GetInt32(new IntPtr(p + 0x064)); // 0270D116FF20 0x64 AsrOutputChannels           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UseRandomSeedWithTime                     = GetBool(new IntPtr(p + 0x068)); // 0270D116FF40 0x68 UseRandomSeedWithTime       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CategoriesPerPlayback                     = GetInt32(new IntPtr(p + 0x06C)); // 0270D116FF60 0x6C CategoriesPerPlayback       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxFaders                                 = GetInt32(new IntPtr(p + 0x070)); // 0270D116FF80 0x70 MaxFaders                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxBuses                                  = GetInt32(new IntPtr(p + 0x074)); // 0270D116FFA0 0x74 MaxBuses                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxParameterBlocks                        = GetInt32(new IntPtr(p + 0x078)); // 0270D116FFC0 0x78 MaxParameterBlocks          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VrMode                                    = GetBool(new IntPtr(p + 0x07C)); // 0270D116FFE0 0x7C VrMode                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.KeepPlayingSoundOnPause                   = GetBool(new IntPtr(p + 0x07D)); // 0270D1170000 0x7D KeepPlayingSoundOnPause     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EditorPcmOutputConfig                     = GetObject<EditorPcmOutputConfig>(new IntPtr(p + 0x080), ReversePrism.DataModels.EditorPcmOutputConfig.FromPointer); // 0270D1170020 0x80 EditorPcmOutputConfig       ( 000186539780 ModelClassType EditorPcmOutputConfig EditorPcmOutputConfig EditorPcmOutputConfig Pointer )
            value.PcBufferingTime                           = GetInt32(new IntPtr(p + 0x088)); // 0270D1170040 0x88 PcBufferingTime             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LinuxOutput                               = (LinuxOutput)GetInt32(new IntPtr(p + 0x08C)); // 0270D1170060 0x8C LinuxOutput                 ( 00018653AEA0 ModelEnumType LinuxOutput LinuxOutput LinuxOutput Int32 )
            value.LinuxPulseLatencyUsec                     = GetInt32(new IntPtr(p + 0x090)); // 0270D1170080 0x90 LinuxPulseLatencyUsec       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IosEnableSonicSync                        = GetBool(new IntPtr(p + 0x094)); // 0270D11700A0 0x94 IosEnableSonicSync          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IosBufferingTime                          = GetInt32(new IntPtr(p + 0x098)); // 0270D11700C0 0x98 IosBufferingTime            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IosOverrideIPodMusic                      = GetBool(new IntPtr(p + 0x09C)); // 0270D11700E0 0x9C IosOverrideIPodMusic        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AndroidEnableSonicSync                    = GetBool(new IntPtr(p + 0x09D)); // 0270D1170100 0x9D AndroidEnableSonicSync      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AndroidBufferingTime                      = GetInt32(new IntPtr(p + 0x0A0)); // 0270D1170120 0xA0 AndroidBufferingTime        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AndroidStartBufferingTime                 = GetInt32(new IntPtr(p + 0x0A4)); // 0270D1170140 0xA4 AndroidStartBufferingTime   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AndroidLowLatencyStandardVoicePoolConfig  = GetObject<AndroidLowLatencyStandardVoicePoolConfig>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AndroidLowLatencyStandardVoicePoolConfig.FromPointer); // 0270D1170160 0xA8 AndroidLowLatencyStandardVoicePoolConfig ( 000186539250 ModelClassType AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig Pointer )
            value.AndroidUsesAndroidFastMixer               = GetBool(new IntPtr(p + 0x0B0)); // 0270D1170180 0xB0 AndroidUsesAndroidFastMixer ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AndroidForceToUseAsrForDefaultPlayback    = GetBool(new IntPtr(p + 0x0B1)); // 0270D11701A0 0xB1 AndroidForceToUseAsrForDefaultPlayback ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AndroidUsesAAudio                         = GetBool(new IntPtr(p + 0x0B2)); // 0270D11701C0 0xB2 AndroidUsesAAudio           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AndroidStreamType                         = GetInt32(new IntPtr(p + 0x0B4)); // 0270D11701E0 0xB4 AndroidStreamType           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VitaManaVoicePoolConfig                   = GetObject<VitaManaVoicePoolConfig>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.VitaManaVoicePoolConfig.FromPointer); // 0270D1170200 0xB8 VitaManaVoicePoolConfig     ( 00018653D5D0 ModelClassType VitaManaVoicePoolConfig VitaManaVoicePoolConfig VitaManaVoicePoolConfig Pointer )
            value.VitaAtrac9VoicePoolConfig                 = GetObject<VitaAtrac9VoicePoolConfig>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.VitaAtrac9VoicePoolConfig.FromPointer); // 0270D1170220 0xC0 VitaAtrac9VoicePoolConfig   ( 00018653D070 ModelClassType VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig Pointer )
            value.Ps4Atrac9VoicePoolConfig                  = GetObject<Ps4Atrac9VoicePoolConfig>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Ps4Atrac9VoicePoolConfig.FromPointer); // 0270D1170240 0xC8 Ps4Atrac9VoicePoolConfig    ( 00018653B670 ModelClassType Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Pointer )
            value.Ps5PortConfig                             = GetObject<Ps5PortConfig>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Ps5PortConfig.FromPointer); // 0270D1170260 0xD0 Ps5PortConfig               ( 00018653C0D0 ModelClassType Ps5PortConfig Ps5PortConfig Ps5PortConfig Pointer )
            value.SwitchEnableSonicSync                     = GetBool(new IntPtr(p + 0x0D8)); // 0270D1170280 0xD8 SwitchEnableSonicSync       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SwitchOpusVoicePoolConfig                 = GetObject<SwitchOpusVoicePoolConfig>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.SwitchOpusVoicePoolConfig.FromPointer); // 0270D11702A0 0xE0 SwitchOpusVoicePoolConfig   ( 00018653CB30 ModelClassType SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig Pointer )
            value.Ps4Audio3dConfig                          = GetObject<Ps4Audio3dConfig>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Ps4Audio3dConfig.FromPointer); // 0270D11702C0 0xE8 Ps4Audio3dConfig            ( 00018653BB90 ModelClassType Ps4Audio3dConfig Ps4Audio3dConfig Ps4Audio3dConfig Pointer )
            value.WebglWebAudioVoicePoolConfig              = GetObject<WebGLWebAudioVoicePoolConfig>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.WebGLWebAudioVoicePoolConfig.FromPointer); // 0270D11702E0 0xF0 WebglWebAudioVoicePoolConfig ( 00018653DB10 ModelClassType WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig Pointer )

            return value;
        }
    }
}
