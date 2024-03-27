using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Clip                                   0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 020 M_Position                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C M_EulerAngles                            0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 M_UseTrackMatchFields                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C M_MatchTargetFields                      0001865DF1D0 ModelEnumType MatchTargetFields MatchTargetFields MatchTargetFields Int32
    // 040 M_RemoveStartOffset                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 M_ApplyFootIK                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 M_Loop                                   0001866A3320 ModelEnumType LoopMode LoopMode LoopMode Int32
    // 048 AppliedOffsetMode                        0001866D0D00 ModelEnumType AppliedOffsetMode AppliedOffsetMode AppliedOffsetMode Int32
    // 000 k_LatestVersion                          int IL2CPP_TYPE_I4
    // 04C M_Version                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 M_Rotation                               000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class AnimationPlayableAsset
    {
        public AnimationClip?                           M_Clip                                  { get; set; }
        public Vector3                                  M_Position                              { get; set; }
        public Vector3                                  M_EulerAngles                           { get; set; }
        public bool                                     M_UseTrackMatchFields                   { get; set; }
        public MatchTargetFields                        M_MatchTargetFields                     { get; set; }
        public bool                                     M_RemoveStartOffset                     { get; set; }
        public bool                                     M_ApplyFootIK                           { get; set; }
        public LoopMode                                 M_Loop                                  { get; set; }
        public AppliedOffsetMode                        AppliedOffsetMode                       { get; set; }
        public int                                      M_Version                               { get; set; }
        public Quaternion                               M_Rotation                              { get; set; }

        public static AnimationPlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationPlayableAsset();

            value.M_Clip                                    = GetObject<AnimationClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationClip.FromPointer); // 0270DB238660 0x18 M_Clip                      ( 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0270DB238680 0x20 M_Position                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_EulerAngles                             = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0270DB2386A0 0x2C M_EulerAngles               ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_UseTrackMatchFields                     = GetBool(new IntPtr(p + 0x038)); // 0270DB2386C0 0x38 M_UseTrackMatchFields       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MatchTargetFields                       = (MatchTargetFields)GetInt32(new IntPtr(p + 0x03C)); // 0270DB2386E0 0x3C M_MatchTargetFields         ( 0001865DF1D0 ModelEnumType MatchTargetFields MatchTargetFields MatchTargetFields Int32 )
            value.M_RemoveStartOffset                       = GetBool(new IntPtr(p + 0x040)); // 0270DB238700 0x40 M_RemoveStartOffset         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ApplyFootIK                             = GetBool(new IntPtr(p + 0x041)); // 0270DB238720 0x41 M_ApplyFootIK               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Loop                                    = (LoopMode)GetInt32(new IntPtr(p + 0x044)); // 0270DB238740 0x44 M_Loop                      ( 0001866A3320 ModelEnumType LoopMode LoopMode LoopMode Int32 )
            value.AppliedOffsetMode                         = (AppliedOffsetMode)GetInt32(new IntPtr(p + 0x048)); // 0270DB238760 0x48 AppliedOffsetMode           ( 0001866D0D00 ModelEnumType AppliedOffsetMode AppliedOffsetMode AppliedOffsetMode Int32 )
            value.M_Version                                 = GetInt32(new IntPtr(p + 0x04C)); // 0270DB2387A0 0x4C M_Version                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Rotation                                = (Quaternion)GetInt32(new IntPtr(p + 0x050)); // 0270DB2387C0 0x50 M_Rotation                  ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
