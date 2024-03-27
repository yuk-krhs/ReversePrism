using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NumEnrties                               int IL2CPP_TYPE_I4
    // 010 IsStereo                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 014 Channels                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 018 AtomExPlayer                             000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 020 Playback                                 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 028 VoicePool                                00018664AE30 ModelClassType CriAtomExVoicePool CriAtomExVoicePool CriAtomExVoicePool Pointer
    // 000 hcaDecoder                               CriHcaDecoder IL2CPP_TYPE_CLASS
    // 030 IsStarted                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 AudioPlaybackTime                        0001866656B0 ModelPrimitiveType float float float Single
    // 038 playbackSamples                          float[][] IL2CPP_TYPE_SZARRAY
    // 040 GCHandles                                000185B80720 ModelEnumListType GCHandle[] GCHandle[] List<GCHandle> Pointer
    // 048 EntriedIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C PacketSampleLength                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 AddEntryCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 FrameTime                                0001866656B0 ModelPrimitiveType float float float Single
    // 058 StartTime                                0001866656B0 ModelPrimitiveType float float float Single
    // 05C IsFinished                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05D IsMute                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05E IsStartIgnoreBuffer                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 LatestUpdatePlaybackTimeFrame            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 070 onStartSubject                           Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class SoundReceiver
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
            var value   = new SoundReceiver();

            value.IsStereo                                  = GetBool(new IntPtr(p + 0x010)); // 0270D4F5AA48 0x10 IsStereo                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Channels                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D4F5AA68 0x14 Channels                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AtomExPlayer                              = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0270D4F5AA88 0x18 AtomExPlayer                ( 000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x020)); // 0270D4F5AAA8 0x20 Playback                    ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.VoicePool                                 = GetObject<CriAtomExVoicePool>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomExVoicePool.FromPointer); // 0270D4F5AAC8 0x28 VoicePool                   ( 00018664AE30 ModelClassType CriAtomExVoicePool CriAtomExVoicePool CriAtomExVoicePool Pointer )
            value.IsStarted                                 = GetBool(new IntPtr(p + 0x030)); // 0270D4F5AB08 0x30 IsStarted                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AudioPlaybackTime                         = GetSingle(new IntPtr(p + 0x034)); // 0270D4F5AB28 0x34 AudioPlaybackTime           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.GCHandles                                 = GetEnumList<GCHandle>(new IntPtr(p + 0x040)); // 0270D4F5AB68 0x40 GCHandles                   ( 000185B80720 ModelEnumListType GCHandle[] GCHandle[] List<GCHandle> Pointer )
            value.EntriedIndex                              = GetInt32(new IntPtr(p + 0x048)); // 0270D4F5AB88 0x48 EntriedIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PacketSampleLength                        = GetInt32(new IntPtr(p + 0x04C)); // 0270D4F5ABA8 0x4C PacketSampleLength          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AddEntryCount                             = GetInt32(new IntPtr(p + 0x050)); // 0270D4F5ABC8 0x50 AddEntryCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FrameTime                                 = GetSingle(new IntPtr(p + 0x054)); // 0270D4F5ABE8 0x54 FrameTime                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StartTime                                 = GetSingle(new IntPtr(p + 0x058)); // 0270D4F5AC08 0x58 StartTime                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsFinished                                = GetBool(new IntPtr(p + 0x05C)); // 0270D4F5AC28 0x5C IsFinished                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMute                                    = GetBool(new IntPtr(p + 0x05D)); // 0270D4F5AC48 0x5D IsMute                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsStartIgnoreBuffer                       = GetBool(new IntPtr(p + 0x05E)); // 0270D4F5AC68 0x5E IsStartIgnoreBuffer         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LatestUpdatePlaybackTimeFrame             = GetInt32(new IntPtr(p + 0x060)); // 0270D4F5AC88 0x60 LatestUpdatePlaybackTimeFrame ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
