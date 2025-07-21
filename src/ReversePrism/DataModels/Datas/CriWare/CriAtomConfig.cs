using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AcfFileName                              ModelPrimitiveType string string string String
    // 018 MaxVirtualVoices                         ModelPrimitiveType int int int Int32
    // 01C MaxVoiceLimitGroups                      ModelPrimitiveType int int int Int32
    // 020 MaxCategories                            ModelPrimitiveType int int int Int32
    // 024 MaxAisacs                                ModelPrimitiveType int int int Int32
    // 028 MaxBusSends                              ModelPrimitiveType int int int Int32
    // 02C MaxSequenceEventsPerFrame                ModelPrimitiveType int int int Int32
    // 030 MaxBeatSyncCallbacksPerFrame             ModelPrimitiveType int int int Int32
    // 034 MaxCueLinkCallbacksPerFrame              ModelPrimitiveType int int int Int32
    // 038 StandardVoicePoolConfig                  ModelClassType StandardVoicePoolConfig StandardVoicePoolConfig StandardVoicePoolConfig Pointer
    // 040 HcaMxVoicePoolConfig                     ModelClassType HcaMxVoicePoolConfig HcaMxVoicePoolConfig HcaMxVoicePoolConfig Pointer
    // 048 OutputSamplingRate                       ModelPrimitiveType int int int Int32
    // 04C UsesInGamePreview                        ModelPrimitiveType bool bool bool Bool
    // 050 InGamePreviewMode                        ModelEnumType InGamePreviewSwitchMode InGamePreviewSwitchMode InGamePreviewSwitchMode Int32
    // 054 SwitchInitializeSocket                   ModelPrimitiveType bool bool bool Bool
    // 058 InGamePreviewConfig                      ModelClassType InGamePreviewConfig InGamePreviewConfig InGamePreviewConfig Pointer
    // 060 ServerFrequency                          ModelPrimitiveType float float float Single
    // 064 AsrOutputChannels                        ModelPrimitiveType int int int Int32
    // 068 UseRandomSeedWithTime                    ModelPrimitiveType bool bool bool Bool
    // 06C CategoriesPerPlayback                    ModelPrimitiveType int int int Int32
    // 070 MaxFaders                                ModelPrimitiveType int int int Int32
    // 074 MaxBuses                                 ModelPrimitiveType int int int Int32
    // 078 MaxParameterBlocks                       ModelPrimitiveType int int int Int32
    // 07C VrMode                                   ModelPrimitiveType bool bool bool Bool
    // 07D KeepPlayingSoundOnPause                  ModelPrimitiveType bool bool bool Bool
    // 080 EditorPcmOutputConfig                    ModelClassType EditorPcmOutputConfig EditorPcmOutputConfig EditorPcmOutputConfig Pointer
    // 088 PcBufferingTime                          ModelPrimitiveType int int int Int32
    // 08C LinuxOutput                              ModelEnumType LinuxOutput LinuxOutput LinuxOutput Int32
    // 090 LinuxPulseLatencyUsec                    ModelPrimitiveType int int int Int32
    // 094 IosEnableSonicSync                       ModelPrimitiveType bool bool bool Bool
    // 098 IosBufferingTime                         ModelPrimitiveType int int int Int32
    // 09C IosOverrideIPodMusic                     ModelPrimitiveType bool bool bool Bool
    // 09D AndroidEnableSonicSync                   ModelPrimitiveType bool bool bool Bool
    // 0A0 AndroidBufferingTime                     ModelPrimitiveType int int int Int32
    // 0A4 AndroidStartBufferingTime                ModelPrimitiveType int int int Int32
    // 0A8 AndroidLowLatencyStandardVoicePoolConfig ModelClassType AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig Pointer
    // 0B0 AndroidUsesAndroidFastMixer              ModelPrimitiveType bool bool bool Bool
    // 0B1 AndroidForceToUseAsrForDefaultPlayback   ModelPrimitiveType bool bool bool Bool
    // 0B2 AndroidUsesAAudio                        ModelPrimitiveType bool bool bool Bool
    // 0B4 AndroidStreamType                        ModelPrimitiveType int int int Int32
    // 0B8 VitaManaVoicePoolConfig                  ModelClassType VitaManaVoicePoolConfig VitaManaVoicePoolConfig VitaManaVoicePoolConfig Pointer
    // 0C0 VitaAtrac9VoicePoolConfig                ModelClassType VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig Pointer
    // 0C8 Ps4Atrac9VoicePoolConfig                 ModelClassType Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Pointer
    // 0D0 Ps5PortConfig                            ModelClassType Ps5PortConfig Ps5PortConfig Ps5PortConfig Pointer
    // 0D8 SwitchEnableSonicSync                    ModelPrimitiveType bool bool bool Bool
    // 0E0 SwitchOpusVoicePoolConfig                ModelClassType SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig Pointer
    // 0E8 Ps4Audio3dConfig                         ModelClassType Ps4Audio3dConfig Ps4Audio3dConfig Ps4Audio3dConfig Pointer
    // 0F0 WebglWebAudioVoicePoolConfig             ModelClassType WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig Pointer
    public partial class CriAtomConfig : DataModel
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
            var value   = new CriAtomConfig() { Pointer= p0 };

            value.AcfFileName                               = GetString(new IntPtr(p + 0x010)); // 0x10 AcfFileName                 ( ModelPrimitiveType string string string String )
            value.MaxVirtualVoices                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxVirtualVoices            ( ModelPrimitiveType int int int Int32 )
            value.MaxVoiceLimitGroups                       = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MaxVoiceLimitGroups         ( ModelPrimitiveType int int int Int32 )
            value.MaxCategories                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxCategories               ( ModelPrimitiveType int int int Int32 )
            value.MaxAisacs                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 MaxAisacs                   ( ModelPrimitiveType int int int Int32 )
            value.MaxBusSends                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxBusSends                 ( ModelPrimitiveType int int int Int32 )
            value.MaxSequenceEventsPerFrame                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MaxSequenceEventsPerFrame   ( ModelPrimitiveType int int int Int32 )
            value.MaxBeatSyncCallbacksPerFrame              = GetInt32(new IntPtr(p + 0x030)); // 0x30 MaxBeatSyncCallbacksPerFrame ( ModelPrimitiveType int int int Int32 )
            value.MaxCueLinkCallbacksPerFrame               = GetInt32(new IntPtr(p + 0x034)); // 0x34 MaxCueLinkCallbacksPerFrame ( ModelPrimitiveType int int int Int32 )
            value.StandardVoicePoolConfig                   = GetObject<StandardVoicePoolConfig>(new IntPtr(p + 0x038), ReversePrism.DataModels.StandardVoicePoolConfig.FromPointer); // 0x38 StandardVoicePoolConfig     ( ModelClassType StandardVoicePoolConfig StandardVoicePoolConfig StandardVoicePoolConfig Pointer )
            value.HcaMxVoicePoolConfig                      = GetObject<HcaMxVoicePoolConfig>(new IntPtr(p + 0x040), ReversePrism.DataModels.HcaMxVoicePoolConfig.FromPointer); // 0x40 HcaMxVoicePoolConfig        ( ModelClassType HcaMxVoicePoolConfig HcaMxVoicePoolConfig HcaMxVoicePoolConfig Pointer )
            value.OutputSamplingRate                        = GetInt32(new IntPtr(p + 0x048)); // 0x48 OutputSamplingRate          ( ModelPrimitiveType int int int Int32 )
            value.UsesInGamePreview                         = GetBool(new IntPtr(p + 0x04C)); // 0x4C UsesInGamePreview           ( ModelPrimitiveType bool bool bool Bool )
            value.InGamePreviewMode                         = (InGamePreviewSwitchMode)GetInt32(new IntPtr(p + 0x050)); // 0x50 InGamePreviewMode           ( ModelEnumType InGamePreviewSwitchMode InGamePreviewSwitchMode InGamePreviewSwitchMode Int32 )
            value.SwitchInitializeSocket                    = GetBool(new IntPtr(p + 0x054)); // 0x54 SwitchInitializeSocket      ( ModelPrimitiveType bool bool bool Bool )
            value.InGamePreviewConfig                       = GetObject<InGamePreviewConfig>(new IntPtr(p + 0x058), ReversePrism.DataModels.InGamePreviewConfig.FromPointer); // 0x58 InGamePreviewConfig         ( ModelClassType InGamePreviewConfig InGamePreviewConfig InGamePreviewConfig Pointer )
            value.ServerFrequency                           = GetSingle(new IntPtr(p + 0x060)); // 0x60 ServerFrequency             ( ModelPrimitiveType float float float Single )
            value.AsrOutputChannels                         = GetInt32(new IntPtr(p + 0x064)); // 0x64 AsrOutputChannels           ( ModelPrimitiveType int int int Int32 )
            value.UseRandomSeedWithTime                     = GetBool(new IntPtr(p + 0x068)); // 0x68 UseRandomSeedWithTime       ( ModelPrimitiveType bool bool bool Bool )
            value.CategoriesPerPlayback                     = GetInt32(new IntPtr(p + 0x06C)); // 0x6C CategoriesPerPlayback       ( ModelPrimitiveType int int int Int32 )
            value.MaxFaders                                 = GetInt32(new IntPtr(p + 0x070)); // 0x70 MaxFaders                   ( ModelPrimitiveType int int int Int32 )
            value.MaxBuses                                  = GetInt32(new IntPtr(p + 0x074)); // 0x74 MaxBuses                    ( ModelPrimitiveType int int int Int32 )
            value.MaxParameterBlocks                        = GetInt32(new IntPtr(p + 0x078)); // 0x78 MaxParameterBlocks          ( ModelPrimitiveType int int int Int32 )
            value.VrMode                                    = GetBool(new IntPtr(p + 0x07C)); // 0x7C VrMode                      ( ModelPrimitiveType bool bool bool Bool )
            value.KeepPlayingSoundOnPause                   = GetBool(new IntPtr(p + 0x07D)); // 0x7D KeepPlayingSoundOnPause     ( ModelPrimitiveType bool bool bool Bool )
            value.EditorPcmOutputConfig                     = GetObject<EditorPcmOutputConfig>(new IntPtr(p + 0x080), ReversePrism.DataModels.EditorPcmOutputConfig.FromPointer); // 0x80 EditorPcmOutputConfig       ( ModelClassType EditorPcmOutputConfig EditorPcmOutputConfig EditorPcmOutputConfig Pointer )
            value.PcBufferingTime                           = GetInt32(new IntPtr(p + 0x088)); // 0x88 PcBufferingTime             ( ModelPrimitiveType int int int Int32 )
            value.LinuxOutput                               = (LinuxOutput)GetInt32(new IntPtr(p + 0x08C)); // 0x8C LinuxOutput                 ( ModelEnumType LinuxOutput LinuxOutput LinuxOutput Int32 )
            value.LinuxPulseLatencyUsec                     = GetInt32(new IntPtr(p + 0x090)); // 0x90 LinuxPulseLatencyUsec       ( ModelPrimitiveType int int int Int32 )
            value.IosEnableSonicSync                        = GetBool(new IntPtr(p + 0x094)); // 0x94 IosEnableSonicSync          ( ModelPrimitiveType bool bool bool Bool )
            value.IosBufferingTime                          = GetInt32(new IntPtr(p + 0x098)); // 0x98 IosBufferingTime            ( ModelPrimitiveType int int int Int32 )
            value.IosOverrideIPodMusic                      = GetBool(new IntPtr(p + 0x09C)); // 0x9C IosOverrideIPodMusic        ( ModelPrimitiveType bool bool bool Bool )
            value.AndroidEnableSonicSync                    = GetBool(new IntPtr(p + 0x09D)); // 0x9D AndroidEnableSonicSync      ( ModelPrimitiveType bool bool bool Bool )
            value.AndroidBufferingTime                      = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 AndroidBufferingTime        ( ModelPrimitiveType int int int Int32 )
            value.AndroidStartBufferingTime                 = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 AndroidStartBufferingTime   ( ModelPrimitiveType int int int Int32 )
            value.AndroidLowLatencyStandardVoicePoolConfig  = GetObject<AndroidLowLatencyStandardVoicePoolConfig>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AndroidLowLatencyStandardVoicePoolConfig.FromPointer); // 0xA8 AndroidLowLatencyStandardVoicePoolConfig ( ModelClassType AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig AndroidLowLatencyStandardVoicePoolConfig Pointer )
            value.AndroidUsesAndroidFastMixer               = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 AndroidUsesAndroidFastMixer ( ModelPrimitiveType bool bool bool Bool )
            value.AndroidForceToUseAsrForDefaultPlayback    = GetBool(new IntPtr(p + 0x0B1)); // 0xB1 AndroidForceToUseAsrForDefaultPlayback ( ModelPrimitiveType bool bool bool Bool )
            value.AndroidUsesAAudio                         = GetBool(new IntPtr(p + 0x0B2)); // 0xB2 AndroidUsesAAudio           ( ModelPrimitiveType bool bool bool Bool )
            value.AndroidStreamType                         = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 AndroidStreamType           ( ModelPrimitiveType int int int Int32 )
            value.VitaManaVoicePoolConfig                   = GetObject<VitaManaVoicePoolConfig>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.VitaManaVoicePoolConfig.FromPointer); // 0xB8 VitaManaVoicePoolConfig     ( ModelClassType VitaManaVoicePoolConfig VitaManaVoicePoolConfig VitaManaVoicePoolConfig Pointer )
            value.VitaAtrac9VoicePoolConfig                 = GetObject<VitaAtrac9VoicePoolConfig>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.VitaAtrac9VoicePoolConfig.FromPointer); // 0xC0 VitaAtrac9VoicePoolConfig   ( ModelClassType VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig VitaAtrac9VoicePoolConfig Pointer )
            value.Ps4Atrac9VoicePoolConfig                  = GetObject<Ps4Atrac9VoicePoolConfig>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Ps4Atrac9VoicePoolConfig.FromPointer); // 0xC8 Ps4Atrac9VoicePoolConfig    ( ModelClassType Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Ps4Atrac9VoicePoolConfig Pointer )
            value.Ps5PortConfig                             = GetObject<Ps5PortConfig>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Ps5PortConfig.FromPointer); // 0xD0 Ps5PortConfig               ( ModelClassType Ps5PortConfig Ps5PortConfig Ps5PortConfig Pointer )
            value.SwitchEnableSonicSync                     = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 SwitchEnableSonicSync       ( ModelPrimitiveType bool bool bool Bool )
            value.SwitchOpusVoicePoolConfig                 = GetObject<SwitchOpusVoicePoolConfig>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.SwitchOpusVoicePoolConfig.FromPointer); // 0xE0 SwitchOpusVoicePoolConfig   ( ModelClassType SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig SwitchOpusVoicePoolConfig Pointer )
            value.Ps4Audio3dConfig                          = GetObject<Ps4Audio3dConfig>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Ps4Audio3dConfig.FromPointer); // 0xE8 Ps4Audio3dConfig            ( ModelClassType Ps4Audio3dConfig Ps4Audio3dConfig Ps4Audio3dConfig Pointer )
            value.WebglWebAudioVoicePoolConfig              = GetObject<WebGLWebAudioVoicePoolConfig>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.WebGLWebAudioVoicePoolConfig.FromPointer); // 0xF0 WebglWebAudioVoicePoolConfig ( ModelClassType WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig WebGLWebAudioVoicePoolConfig Pointer )

            return value;
        }
    }
}
