using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_LatestVersion                          int IL2CPP_TYPE_I4
    // 010 M_Version                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 kDefaultClipCaps                         ClipCaps IL2CPP_TYPE_VALUETYPE
    // 004 kDefaultClipDurationInSeconds            float IL2CPP_TYPE_R4
    // 008 kTimeScaleMin                            double IL2CPP_TYPE_R8
    // 010 KTimeScaleMax                            0001865C3F60 ModelPrimitiveType double double double Double
    // 018 KDefaultCurvesName                       000186673B80 ModelPrimitiveType string string string String
    // 020 KMinDuration                             0001865C3D00 ModelPrimitiveType double double double Double
    // 028 KMaxTimeValue                            0001865C3D00 ModelPrimitiveType double double double Double
    // 018 M_Start                                  0001865C2950 ModelPrimitiveType double double double Double
    // 020 M_ClipIn                                 0001865C2950 ModelPrimitiveType double double double Double
    // 028 M_Asset                                  000186638250 ModelClassType Object Object Object Pointer
    // 030 M_Duration                               0001865C2950 ModelPrimitiveType double double double Double
    // 038 M_TimeScale                              0001865C2950 ModelPrimitiveType double double double Double
    // 040 M_ParentTrack                            00018669B680 ModelClassType TrackAsset TrackAsset TrackAsset Pointer
    // 048 M_EaseInDuration                         0001865C2950 ModelPrimitiveType double double double Double
    // 050 M_EaseOutDuration                        0001865C2950 ModelPrimitiveType double double double Double
    // 058 M_BlendInDuration                        0001865C2950 ModelPrimitiveType double double double Double
    // 060 M_BlendOutDuration                       0001865C2950 ModelPrimitiveType double double double Double
    // 068 M_MixInCurve                             000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 070 M_MixOutCurve                            000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 078 M_BlendInCurveMode                       00018660C030 ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32
    // 07C M_BlendOutCurveMode                      00018660C030 ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32
    // 080 M_ExposedParameterNames                  000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 088 M_AnimationCurves                        0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 090 M_Recordable                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 094 M_PostExtrapolationMode                  00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 098 M_PreExtrapolationMode                   00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 0A0 M_PostExtrapolationTime                  0001865C2950 ModelPrimitiveType double double double Double
    // 0A8 M_PreExtrapolationTime                   0001865C2950 ModelPrimitiveType double double double Double
    // 0B0 M_DisplayName                            000186671910 ModelPrimitiveType string string string String
    public partial class TimelineClip
    {
        public int                                      M_Version                               { get; set; }
        public double                                   KTimeScaleMax                           { get; set; }
        public string                                   KDefaultCurvesName                      { get; set; }
        public double                                   KMinDuration                            { get; set; }
        public double                                   KMaxTimeValue                           { get; set; }
        public double                                   M_Start                                 { get; set; }
        public double                                   M_ClipIn                                { get; set; }
        public Object?                                  M_Asset                                 { get; set; }
        public double                                   M_Duration                              { get; set; }
        public double                                   M_TimeScale                             { get; set; }
        public TrackAsset?                              M_ParentTrack                           { get; set; }
        public double                                   M_EaseInDuration                        { get; set; }
        public double                                   M_EaseOutDuration                       { get; set; }
        public double                                   M_BlendInDuration                       { get; set; }
        public double                                   M_BlendOutDuration                      { get; set; }
        public AnimationCurve?                          M_MixInCurve                            { get; set; }
        public AnimationCurve?                          M_MixOutCurve                           { get; set; }
        public BlendCurveMode                           M_BlendInCurveMode                      { get; set; }
        public BlendCurveMode                           M_BlendOutCurveMode                     { get; set; }
        public List<string>?                            M_ExposedParameterNames                 { get; set; }
        public AnimationClip?                           M_AnimationCurves                       { get; set; }
        public bool                                     M_Recordable                            { get; set; }
        public ClipExtrapolation                        M_PostExtrapolationMode                 { get; set; }
        public ClipExtrapolation                        M_PreExtrapolationMode                  { get; set; }
        public double                                   M_PostExtrapolationTime                 { get; set; }
        public double                                   M_PreExtrapolationTime                  { get; set; }
        public string                                   M_DisplayName                           { get; set; }

        public static TimelineClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineClip();

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x010)); // 027006B58BA0 0x10 M_Version                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.KTimeScaleMax                             = GetDouble(new IntPtr(p + 0x010)); // 027006B58C20 0x10 KTimeScaleMax               ( 0001865C3F60 ModelPrimitiveType double double double Double )
            value.KDefaultCurvesName                        = GetString(new IntPtr(p + 0x018)); // 027006B58C40 0x18 KDefaultCurvesName          ( 000186673B80 ModelPrimitiveType string string string String )
            value.KMinDuration                              = GetDouble(new IntPtr(p + 0x020)); // 027006B58C60 0x20 KMinDuration                ( 0001865C3D00 ModelPrimitiveType double double double Double )
            value.KMaxTimeValue                             = GetDouble(new IntPtr(p + 0x028)); // 027006B58C80 0x28 KMaxTimeValue               ( 0001865C3D00 ModelPrimitiveType double double double Double )
            value.M_Start                                   = GetDouble(new IntPtr(p + 0x018)); // 027006B58CA0 0x18 M_Start                     ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_ClipIn                                  = GetDouble(new IntPtr(p + 0x020)); // 027006B58CC0 0x20 M_ClipIn                    ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_Asset                                   = GetObject<Object>(new IntPtr(p + 0x028), ReversePrism.DataModels.Object.FromPointer); // 027006B58CE0 0x28 M_Asset                     ( 000186638250 ModelClassType Object Object Object Pointer )
            value.M_Duration                                = GetDouble(new IntPtr(p + 0x030)); // 027006B58D00 0x30 M_Duration                  ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_TimeScale                               = GetDouble(new IntPtr(p + 0x038)); // 027006B58D20 0x38 M_TimeScale                 ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_ParentTrack                             = GetObject<TrackAsset>(new IntPtr(p + 0x040), ReversePrism.DataModels.TrackAsset.FromPointer); // 027006B58D40 0x40 M_ParentTrack               ( 00018669B680 ModelClassType TrackAsset TrackAsset TrackAsset Pointer )
            value.M_EaseInDuration                          = GetDouble(new IntPtr(p + 0x048)); // 027006B58D60 0x48 M_EaseInDuration            ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_EaseOutDuration                         = GetDouble(new IntPtr(p + 0x050)); // 027006B58D80 0x50 M_EaseOutDuration           ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_BlendInDuration                         = GetDouble(new IntPtr(p + 0x058)); // 027006B58DA0 0x58 M_BlendInDuration           ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_BlendOutDuration                        = GetDouble(new IntPtr(p + 0x060)); // 027006B58DC0 0x60 M_BlendOutDuration          ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_MixInCurve                              = GetObject<AnimationCurve>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnimationCurve.FromPointer); // 027006B58DE0 0x68 M_MixInCurve                ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_MixOutCurve                             = GetObject<AnimationCurve>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimationCurve.FromPointer); // 027006B58E00 0x70 M_MixOutCurve               ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_BlendInCurveMode                        = (BlendCurveMode)GetInt32(new IntPtr(p + 0x078)); // 027006B58E20 0x78 M_BlendInCurveMode          ( 00018660C030 ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32 )
            value.M_BlendOutCurveMode                       = (BlendCurveMode)GetInt32(new IntPtr(p + 0x07C)); // 027006B58E40 0x7C M_BlendOutCurveMode         ( 00018660C030 ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32 )
            value.M_ExposedParameterNames                   = GetStringList(new IntPtr(p + 0x080)); // 027006B58E60 0x80 M_ExposedParameterNames     ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.M_AnimationCurves                         = GetObject<AnimationClip>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimationClip.FromPointer); // 027006B58E80 0x88 M_AnimationCurves           ( 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.M_Recordable                              = GetBool(new IntPtr(p + 0x090)); // 027006B58EA0 0x90 M_Recordable                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PostExtrapolationMode                   = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x094)); // 027006B58EC0 0x94 M_PostExtrapolationMode     ( 00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_PreExtrapolationMode                    = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x098)); // 027006B58EE0 0x98 M_PreExtrapolationMode      ( 00018660C7C0 ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_PostExtrapolationTime                   = GetDouble(new IntPtr(p + 0x0A0)); // 027006B58F00 0xA0 M_PostExtrapolationTime     ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_PreExtrapolationTime                    = GetDouble(new IntPtr(p + 0x0A8)); // 027006B58F20 0xA8 M_PreExtrapolationTime      ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_DisplayName                             = GetString(new IntPtr(p + 0x0B0)); // 027006B58F40 0xB0 M_DisplayName               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
