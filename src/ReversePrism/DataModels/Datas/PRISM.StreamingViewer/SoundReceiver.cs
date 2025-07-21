using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NumEnrties                               int IL2CPP_TYPE_I4
    // 010 IsStereo                                 ModelPrimitiveType bool bool bool Bool
    // 014 Channels                                 ModelPrimitiveType int int int Int32
    // 018 AtomExPlayer                             ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 020 Playback                                 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 028 VoicePool                                ModelClassType CriAtomExVoicePool CriAtomExVoicePool CriAtomExVoicePool Pointer
    // 000 hcaDecoder                               CriHcaDecoder IL2CPP_TYPE_CLASS
    // 030 IsStarted                                ModelPrimitiveType bool bool bool Bool
    // 034 AudioPlaybackTime                        ModelPrimitiveType float float float Single
    // 038 playbackSamples                          float[][] IL2CPP_TYPE_SZARRAY
    // 040 GCHandles                                ModelEnumListType GCHandle[] GCHandle[] List<GCHandle> Pointer
    // 048 EntriedIndex                             ModelPrimitiveType int int int Int32
    // 04C PacketSampleLength                       ModelPrimitiveType int int int Int32
    // 050 AddEntryCount                            ModelPrimitiveType int int int Int32
    // 054 FrameTime                                ModelPrimitiveType float float float Single
    // 058 StartTime                                ModelPrimitiveType float float float Single
    // 05C IsFinished                               ModelPrimitiveType bool bool bool Bool
    // 05D IsMute                                   ModelPrimitiveType bool bool bool Bool
    // 05E IsStartIgnoreBuffer                      ModelPrimitiveType bool bool bool Bool
    // 060 LatestUpdatePlaybackTimeFrame            ModelPrimitiveType int int int Int32
    // 068 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    public partial class SoundReceiver : DataModel
    {
        public bool                                     IsStereo                                { get; set; }
        public int                                      Channels                                { get; set; }
        public CriAtomExPlayer?                         AtomExPlayer                            { get; set; }
        public CriAtomExPlayback                        Playback                                { get; set; }
        public CriAtomExVoicePool?                      VoicePool                               { get; set; }
        public bool                                     IsStarted                               { get; set; }
        public float                                    AudioPlaybackTime                       { get; set; }
        public List<GCHandle>?                          GCHandles                               { get; set; }
        public int                                      EntriedIndex                            { get; set; }
        public int                                      PacketSampleLength                      { get; set; }
        public int                                      AddEntryCount                           { get; set; }
        public float                                    FrameTime                               { get; set; }
        public float                                    StartTime                               { get; set; }
        public bool                                     IsFinished                              { get; set; }
        public bool                                     IsMute                                  { get; set; }
        public bool                                     IsStartIgnoreBuffer                     { get; set; }
        public int                                      LatestUpdatePlaybackTimeFrame           { get; set; }

        public static SoundReceiver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundReceiver() { Pointer= p0 };

            value.IsStereo                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsStereo                    ( ModelPrimitiveType bool bool bool Bool )
            value.Channels                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 Channels                    ( ModelPrimitiveType int int int Int32 )
            value.AtomExPlayer                              = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x18 AtomExPlayer                ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x020)); // 0x20 Playback                    ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.VoicePool                                 = GetObject<CriAtomExVoicePool>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomExVoicePool.FromPointer); // 0x28 VoicePool                   ( ModelClassType CriAtomExVoicePool CriAtomExVoicePool CriAtomExVoicePool Pointer )
            value.IsStarted                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 IsStarted                   ( ModelPrimitiveType bool bool bool Bool )
            value.AudioPlaybackTime                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 AudioPlaybackTime           ( ModelPrimitiveType float float float Single )
            value.GCHandles                                 = GetEnumList<GCHandle>(new IntPtr(p + 0x040)); // 0x40 GCHandles                   ( ModelEnumListType GCHandle[] GCHandle[] List<GCHandle> Pointer )
            value.EntriedIndex                              = GetInt32(new IntPtr(p + 0x048)); // 0x48 EntriedIndex                ( ModelPrimitiveType int int int Int32 )
            value.PacketSampleLength                        = GetInt32(new IntPtr(p + 0x04C)); // 0x4C PacketSampleLength          ( ModelPrimitiveType int int int Int32 )
            value.AddEntryCount                             = GetInt32(new IntPtr(p + 0x050)); // 0x50 AddEntryCount               ( ModelPrimitiveType int int int Int32 )
            value.FrameTime                                 = GetSingle(new IntPtr(p + 0x054)); // 0x54 FrameTime                   ( ModelPrimitiveType float float float Single )
            value.StartTime                                 = GetSingle(new IntPtr(p + 0x058)); // 0x58 StartTime                   ( ModelPrimitiveType float float float Single )
            value.IsFinished                                = GetBool(new IntPtr(p + 0x05C)); // 0x5C IsFinished                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsMute                                    = GetBool(new IntPtr(p + 0x05D)); // 0x5D IsMute                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsStartIgnoreBuffer                       = GetBool(new IntPtr(p + 0x05E)); // 0x5E IsStartIgnoreBuffer         ( ModelPrimitiveType bool bool bool Bool )
            value.LatestUpdatePlaybackTimeFrame             = GetInt32(new IntPtr(p + 0x060)); // 0x60 LatestUpdatePlaybackTimeFrame ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
