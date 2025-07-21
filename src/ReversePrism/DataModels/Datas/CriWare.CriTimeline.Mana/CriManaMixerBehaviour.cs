using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PlayableDirector                       ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 018 M_clips                                  ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer
    // 020 M_boundMovieMaterial                     ModelClassType CriManaMovieMaterialBase CriManaMovieMaterialBase CriManaMovieMaterialBase Pointer
    // 028 m_gcHandleList                           Dictionary`2<int, GCHandle> IL2CPP_TYPE_GENERICINST
    // 030 M_frameSync                              ModelPrimitiveType bool bool bool Bool
    // 000 cPreloadTimeSec                          double IL2CPP_TYPE_R8
    // 034 m_lastClipId                             Nullable`1<Guid> IL2CPP_TYPE_GENERICINST
    // 048 StartTime                                ModelPrimitiveType double double double Double
    // 050 M_currentSeekingFrameTime                ModelPrimitiveType double double double Double
    // 058 M_originalAudioVolume                    ModelPrimitiveType float float float Single
    // 05C M_originalSubAudioVolume                 ModelPrimitiveType float float float Single
    // 060 M_originalExtraAudioVolume               ModelPrimitiveType float float float Single
    // 064 EnableTimelineScrubPlayback              ModelPrimitiveType bool bool bool Bool
    // 068 M_movieMixerState                        ModelEnumType MovieMixerState MovieMixerState MovieMixerState Int32
    public partial class CriManaMixerBehaviour : DataModel
    {
        public PlayableDirector?                        M_PlayableDirector                      { get; set; }
        public List<TimelineClip>?                      M_clips                                 { get; set; }
        public CriManaMovieMaterialBase?                M_boundMovieMaterial                    { get; set; }
        public bool                                     M_frameSync                             { get; set; }
        public double                                   StartTime                               { get; set; }
        public double                                   M_currentSeekingFrameTime               { get; set; }
        public float                                    M_originalAudioVolume                   { get; set; }
        public float                                    M_originalSubAudioVolume                { get; set; }
        public float                                    M_originalExtraAudioVolume              { get; set; }
        public bool                                     EnableTimelineScrubPlayback             { get; set; }
        public MovieMixerState                          M_movieMixerState                       { get; set; }

        public static CriManaMixerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaMixerBehaviour() { Pointer= p0 };

            value.M_PlayableDirector                        = GetObject<PlayableDirector>(new IntPtr(p + 0x010), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x10 M_PlayableDirector          ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.M_clips                                   = GetObjectList<TimelineClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimelineClip.FromPointer); // 0x18 M_clips                     ( ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer )
            value.M_boundMovieMaterial                      = GetObject<CriManaMovieMaterialBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriManaMovieMaterialBase.FromPointer); // 0x20 M_boundMovieMaterial        ( ModelClassType CriManaMovieMaterialBase CriManaMovieMaterialBase CriManaMovieMaterialBase Pointer )
            value.M_frameSync                               = GetBool(new IntPtr(p + 0x030)); // 0x30 M_frameSync                 ( ModelPrimitiveType bool bool bool Bool )
            value.StartTime                                 = GetDouble(new IntPtr(p + 0x048)); // 0x48 StartTime                   ( ModelPrimitiveType double double double Double )
            value.M_currentSeekingFrameTime                 = GetDouble(new IntPtr(p + 0x050)); // 0x50 M_currentSeekingFrameTime   ( ModelPrimitiveType double double double Double )
            value.M_originalAudioVolume                     = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_originalAudioVolume       ( ModelPrimitiveType float float float Single )
            value.M_originalSubAudioVolume                  = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_originalSubAudioVolume    ( ModelPrimitiveType float float float Single )
            value.M_originalExtraAudioVolume                = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_originalExtraAudioVolume  ( ModelPrimitiveType float float float Single )
            value.EnableTimelineScrubPlayback               = GetBool(new IntPtr(p + 0x064)); // 0x64 EnableTimelineScrubPlayback ( ModelPrimitiveType bool bool bool Bool )
            value.M_movieMixerState                         = (MovieMixerState)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_movieMixerState           ( ModelEnumType MovieMixerState MovieMixerState MovieMixerState Int32 )

            return value;
        }
    }
}
