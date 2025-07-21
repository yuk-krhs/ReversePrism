using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DefaultInfiniteClipName                string IL2CPP_TYPE_STRING
    // 000 k_DefaultRecordableClipName              string IL2CPP_TYPE_STRING
    // 0A0 M_InfiniteClipPreExtrapolation           ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 0A4 M_InfiniteClipPostExtrapolation          ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 0A8 M_InfiniteClipOffsetPosition             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B4 M_InfiniteClipOffsetEulerAngles          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0C0 M_InfiniteClipTimeOffset                 ModelPrimitiveType double double double Double
    // 0C8 M_InfiniteClipRemoveOffset               ModelPrimitiveType bool bool bool Bool
    // 0C9 M_InfiniteClipApplyFootIK                ModelPrimitiveType bool bool bool Bool
    // 0CC MInfiniteClipLoop                        ModelEnumType LoopMode LoopMode LoopMode Int32
    // 0D0 M_MatchTargetFields                      ModelEnumType MatchTargetFields MatchTargetFields MatchTargetFields Int32
    // 0D4 M_Position                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0E0 M_EulerAngles                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0F0 M_AvatarMask                             ModelClassType AvatarMask AvatarMask AvatarMask Pointer
    // 0F8 M_ApplyAvatarMask                        ModelPrimitiveType bool bool bool Bool
    // 0FC M_TrackOffset                            ModelEnumType TrackOffset TrackOffset TrackOffset Int32
    // 100 M_InfiniteClip                           ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 000 s_CachedQueue                            Queue`1<Transform> IL2CPP_TYPE_GENERICINST
    // 108 M_OpenClipOffsetRotation                 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 118 M_Rotation                               ModelEnumType Quaternion Quaternion Quaternion Int32
    // 128 M_ApplyOffsets                           ModelPrimitiveType bool bool bool Bool
    public partial class AnimationTrack : DataModel
    {
        public ClipExtrapolation                        M_InfiniteClipPreExtrapolation          { get; set; }
        public ClipExtrapolation                        M_InfiniteClipPostExtrapolation         { get; set; }
        public Vector3                                  M_InfiniteClipOffsetPosition            { get; set; }
        public Vector3                                  M_InfiniteClipOffsetEulerAngles         { get; set; }
        public double                                   M_InfiniteClipTimeOffset                { get; set; }
        public bool                                     M_InfiniteClipRemoveOffset              { get; set; }
        public bool                                     M_InfiniteClipApplyFootIK               { get; set; }
        public LoopMode                                 MInfiniteClipLoop                       { get; set; }
        public MatchTargetFields                        M_MatchTargetFields                     { get; set; }
        public Vector3                                  M_Position                              { get; set; }
        public Vector3                                  M_EulerAngles                           { get; set; }
        public AvatarMask?                              M_AvatarMask                            { get; set; }
        public bool                                     M_ApplyAvatarMask                       { get; set; }
        public TrackOffset                              M_TrackOffset                           { get; set; }
        public AnimationClip?                           M_InfiniteClip                          { get; set; }
        public Quaternion                               M_OpenClipOffsetRotation                { get; set; }
        public Quaternion                               M_Rotation                              { get; set; }
        public bool                                     M_ApplyOffsets                          { get; set; }

        public static AnimationTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationTrack() { Pointer= p0 };

            value.M_InfiniteClipPreExtrapolation            = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_InfiniteClipPreExtrapolation ( ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_InfiniteClipPostExtrapolation           = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 M_InfiniteClipPostExtrapolation ( ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_InfiniteClipOffsetPosition              = (Vector3)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_InfiniteClipOffsetPosition ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_InfiniteClipOffsetEulerAngles           = (Vector3)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 M_InfiniteClipOffsetEulerAngles ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_InfiniteClipTimeOffset                  = GetDouble(new IntPtr(p + 0x0C0)); // 0xC0 M_InfiniteClipTimeOffset    ( ModelPrimitiveType double double double Double )
            value.M_InfiniteClipRemoveOffset                = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 M_InfiniteClipRemoveOffset  ( ModelPrimitiveType bool bool bool Bool )
            value.M_InfiniteClipApplyFootIK                 = GetBool(new IntPtr(p + 0x0C9)); // 0xC9 M_InfiniteClipApplyFootIK   ( ModelPrimitiveType bool bool bool Bool )
            value.MInfiniteClipLoop                         = (LoopMode)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC MInfiniteClipLoop           ( ModelEnumType LoopMode LoopMode LoopMode Int32 )
            value.M_MatchTargetFields                       = (MatchTargetFields)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 M_MatchTargetFields         ( ModelEnumType MatchTargetFields MatchTargetFields MatchTargetFields Int32 )
            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 M_Position                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_EulerAngles                             = (Vector3)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_EulerAngles               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AvatarMask                              = GetObject<AvatarMask>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.AvatarMask.FromPointer); // 0xF0 M_AvatarMask                ( ModelClassType AvatarMask AvatarMask AvatarMask Pointer )
            value.M_ApplyAvatarMask                         = GetBool(new IntPtr(p + 0x0F8)); // 0xF8 M_ApplyAvatarMask           ( ModelPrimitiveType bool bool bool Bool )
            value.M_TrackOffset                             = (TrackOffset)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC M_TrackOffset               ( ModelEnumType TrackOffset TrackOffset TrackOffset Int32 )
            value.M_InfiniteClip                            = GetObject<AnimationClip>(new IntPtr(p + 0x100), ReversePrism.DataModels.AnimationClip.FromPointer); // 0x100 M_InfiniteClip              ( ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.M_OpenClipOffsetRotation                  = (Quaternion)GetInt32(new IntPtr(p + 0x108)); // 0x108 M_OpenClipOffsetRotation    ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_Rotation                                = (Quaternion)GetInt32(new IntPtr(p + 0x118)); // 0x118 M_Rotation                  ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_ApplyOffsets                            = GetBool(new IntPtr(p + 0x128)); // 0x128 M_ApplyOffsets              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
