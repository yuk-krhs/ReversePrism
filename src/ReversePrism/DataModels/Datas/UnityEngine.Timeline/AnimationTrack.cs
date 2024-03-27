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
    // 0A0 M_InfiniteClipPreExtrapolation           00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 0A4 M_InfiniteClipPostExtrapolation          00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 0A8 M_InfiniteClipOffsetPosition             0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B4 M_InfiniteClipOffsetEulerAngles          0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0C0 M_InfiniteClipTimeOffset                 0001865C2950 ModelPrimitiveType double double double Double
    // 0C8 M_InfiniteClipRemoveOffset               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C9 M_InfiniteClipApplyFootIK                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0CC MInfiniteClipLoop                        0001866A3320 ModelEnumType LoopMode LoopMode LoopMode Int32
    // 0D0 M_MatchTargetFields                      0001865DF1D0 ModelEnumType MatchTargetFields MatchTargetFields MatchTargetFields Int32
    // 0D4 M_Position                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0E0 M_EulerAngles                            0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0F0 M_AvatarMask                             00018672AEF0 ModelClassType AvatarMask AvatarMask AvatarMask Pointer
    // 0F8 M_ApplyAvatarMask                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0FC M_TrackOffset                            00018669D110 ModelEnumType TrackOffset TrackOffset TrackOffset Int32
    // 100 M_InfiniteClip                           0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 000 s_CachedQueue                            Queue`1<Transform> IL2CPP_TYPE_GENERICINST
    // 108 M_OpenClipOffsetRotation                 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 118 M_Rotation                               000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 128 M_ApplyOffsets                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AnimationTrack
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
            var value   = new AnimationTrack();

            value.M_InfiniteClipPreExtrapolation            = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x0A0)); // 027006F51A38 0xA0 M_InfiniteClipPreExtrapolation ( 00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_InfiniteClipPostExtrapolation           = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x0A4)); // 027006F51A58 0xA4 M_InfiniteClipPostExtrapolation ( 00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_InfiniteClipOffsetPosition              = (Vector3)GetInt32(new IntPtr(p + 0x0A8)); // 027006F51A78 0xA8 M_InfiniteClipOffsetPosition ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_InfiniteClipOffsetEulerAngles           = (Vector3)GetInt32(new IntPtr(p + 0x0B4)); // 027006F51A98 0xB4 M_InfiniteClipOffsetEulerAngles ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_InfiniteClipTimeOffset                  = GetDouble(new IntPtr(p + 0x0C0)); // 027006F51AB8 0xC0 M_InfiniteClipTimeOffset    ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_InfiniteClipRemoveOffset                = GetBool(new IntPtr(p + 0x0C8)); // 027006F51AD8 0xC8 M_InfiniteClipRemoveOffset  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InfiniteClipApplyFootIK                 = GetBool(new IntPtr(p + 0x0C9)); // 027006F51AF8 0xC9 M_InfiniteClipApplyFootIK   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MInfiniteClipLoop                         = (LoopMode)GetInt32(new IntPtr(p + 0x0CC)); // 027006F51B18 0xCC MInfiniteClipLoop           ( 0001866A3320 ModelEnumType LoopMode LoopMode LoopMode Int32 )
            value.M_MatchTargetFields                       = (MatchTargetFields)GetInt32(new IntPtr(p + 0x0D0)); // 027006F51B38 0xD0 M_MatchTargetFields         ( 0001865DF1D0 ModelEnumType MatchTargetFields MatchTargetFields MatchTargetFields Int32 )
            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x0D4)); // 027006F51B58 0xD4 M_Position                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_EulerAngles                             = (Vector3)GetInt32(new IntPtr(p + 0x0E0)); // 027006F51B78 0xE0 M_EulerAngles               ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AvatarMask                              = GetObject<AvatarMask>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.AvatarMask.FromPointer); // 027006F51B98 0xF0 M_AvatarMask                ( 00018672AEF0 ModelClassType AvatarMask AvatarMask AvatarMask Pointer )
            value.M_ApplyAvatarMask                         = GetBool(new IntPtr(p + 0x0F8)); // 027006F51BB8 0xF8 M_ApplyAvatarMask           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TrackOffset                             = (TrackOffset)GetInt32(new IntPtr(p + 0x0FC)); // 027006F51BD8 0xFC M_TrackOffset               ( 00018669D110 ModelEnumType TrackOffset TrackOffset TrackOffset Int32 )
            value.M_InfiniteClip                            = GetObject<AnimationClip>(new IntPtr(p + 0x100), ReversePrism.DataModels.AnimationClip.FromPointer); // 027006F51BF8 0x100 M_InfiniteClip              ( 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.M_OpenClipOffsetRotation                  = (Quaternion)GetInt32(new IntPtr(p + 0x108)); // 027006F51C38 0x108 M_OpenClipOffsetRotation    ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_Rotation                                = (Quaternion)GetInt32(new IntPtr(p + 0x118)); // 027006F51C58 0x118 M_Rotation                  ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_ApplyOffsets                            = GetBool(new IntPtr(p + 0x128)); // 027006F51C78 0x128 M_ApplyOffsets              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
