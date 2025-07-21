using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_LatestVersion                          int IL2CPP_TYPE_I4
    // 010 M_Version                                ModelPrimitiveType int int int Int32
    // 000 kDefaultClipCaps                         ClipCaps IL2CPP_TYPE_VALUETYPE
    // 004 kDefaultClipDurationInSeconds            float IL2CPP_TYPE_R4
    // 008 kTimeScaleMin                            double IL2CPP_TYPE_R8
    // 010 KTimeScaleMax                            ModelPrimitiveType double double double Double
    // 018 KDefaultCurvesName                       ModelPrimitiveType string string string String
    // 020 KMinDuration                             ModelPrimitiveType double double double Double
    // 028 KMaxTimeValue                            ModelPrimitiveType double double double Double
    // 018 M_Start                                  ModelPrimitiveType double double double Double
    // 020 M_ClipIn                                 ModelPrimitiveType double double double Double
    // 028 M_Asset                                  ModelClassType Object Object Object Pointer
    // 030 M_Duration                               ModelPrimitiveType double double double Double
    // 038 M_TimeScale                              ModelPrimitiveType double double double Double
    // 040 M_ParentTrack                            ModelClassType TrackAsset TrackAsset TrackAsset Pointer
    // 048 M_EaseInDuration                         ModelPrimitiveType double double double Double
    // 050 M_EaseOutDuration                        ModelPrimitiveType double double double Double
    // 058 M_BlendInDuration                        ModelPrimitiveType double double double Double
    // 060 M_BlendOutDuration                       ModelPrimitiveType double double double Double
    // 068 M_MixInCurve                             ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 070 M_MixOutCurve                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 078 M_BlendInCurveMode                       ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32
    // 07C M_BlendOutCurveMode                      ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32
    // 080 M_ExposedParameterNames                  ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 088 M_AnimationCurves                        ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 090 M_Recordable                             ModelPrimitiveType bool bool bool Bool
    // 094 M_PostExtrapolationMode                  ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 098 M_PreExtrapolationMode                   ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 0A0 M_PostExtrapolationTime                  ModelPrimitiveType double double double Double
    // 0A8 M_PreExtrapolationTime                   ModelPrimitiveType double double double Double
    // 0B0 M_DisplayName                            ModelPrimitiveType string string string String
    public partial class TimelineClip : DataModel
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
            var value   = new TimelineClip() { Pointer= p0 };

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Version                   ( ModelPrimitiveType int int int Int32 )
            value.KTimeScaleMax                             = GetDouble(new IntPtr(p + 0x010)); // 0x10 KTimeScaleMax               ( ModelPrimitiveType double double double Double )
            value.KDefaultCurvesName                        = GetString(new IntPtr(p + 0x018)); // 0x18 KDefaultCurvesName          ( ModelPrimitiveType string string string String )
            value.KMinDuration                              = GetDouble(new IntPtr(p + 0x020)); // 0x20 KMinDuration                ( ModelPrimitiveType double double double Double )
            value.KMaxTimeValue                             = GetDouble(new IntPtr(p + 0x028)); // 0x28 KMaxTimeValue               ( ModelPrimitiveType double double double Double )
            value.M_Start                                   = GetDouble(new IntPtr(p + 0x018)); // 0x18 M_Start                     ( ModelPrimitiveType double double double Double )
            value.M_ClipIn                                  = GetDouble(new IntPtr(p + 0x020)); // 0x20 M_ClipIn                    ( ModelPrimitiveType double double double Double )
            value.M_Asset                                   = GetObject<Object>(new IntPtr(p + 0x028), ReversePrism.DataModels.Object.FromPointer); // 0x28 M_Asset                     ( ModelClassType Object Object Object Pointer )
            value.M_Duration                                = GetDouble(new IntPtr(p + 0x030)); // 0x30 M_Duration                  ( ModelPrimitiveType double double double Double )
            value.M_TimeScale                               = GetDouble(new IntPtr(p + 0x038)); // 0x38 M_TimeScale                 ( ModelPrimitiveType double double double Double )
            value.M_ParentTrack                             = GetObject<TrackAsset>(new IntPtr(p + 0x040), ReversePrism.DataModels.TrackAsset.FromPointer); // 0x40 M_ParentTrack               ( ModelClassType TrackAsset TrackAsset TrackAsset Pointer )
            value.M_EaseInDuration                          = GetDouble(new IntPtr(p + 0x048)); // 0x48 M_EaseInDuration            ( ModelPrimitiveType double double double Double )
            value.M_EaseOutDuration                         = GetDouble(new IntPtr(p + 0x050)); // 0x50 M_EaseOutDuration           ( ModelPrimitiveType double double double Double )
            value.M_BlendInDuration                         = GetDouble(new IntPtr(p + 0x058)); // 0x58 M_BlendInDuration           ( ModelPrimitiveType double double double Double )
            value.M_BlendOutDuration                        = GetDouble(new IntPtr(p + 0x060)); // 0x60 M_BlendOutDuration          ( ModelPrimitiveType double double double Double )
            value.M_MixInCurve                              = GetObject<AnimationCurve>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x68 M_MixInCurve                ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_MixOutCurve                             = GetObject<AnimationCurve>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x70 M_MixOutCurve               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_BlendInCurveMode                        = (BlendCurveMode)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_BlendInCurveMode          ( ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32 )
            value.M_BlendOutCurveMode                       = (BlendCurveMode)GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_BlendOutCurveMode         ( ModelEnumType BlendCurveMode BlendCurveMode BlendCurveMode Int32 )
            value.M_ExposedParameterNames                   = GetStringList(new IntPtr(p + 0x080)); // 0x80 M_ExposedParameterNames     ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.M_AnimationCurves                         = GetObject<AnimationClip>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimationClip.FromPointer); // 0x88 M_AnimationCurves           ( ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.M_Recordable                              = GetBool(new IntPtr(p + 0x090)); // 0x90 M_Recordable                ( ModelPrimitiveType bool bool bool Bool )
            value.M_PostExtrapolationMode                   = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x094)); // 0x94 M_PostExtrapolationMode     ( ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_PreExtrapolationMode                    = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x098)); // 0x98 M_PreExtrapolationMode      ( ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_PostExtrapolationTime                   = GetDouble(new IntPtr(p + 0x0A0)); // 0xA0 M_PostExtrapolationTime     ( ModelPrimitiveType double double double Double )
            value.M_PreExtrapolationTime                    = GetDouble(new IntPtr(p + 0x0A8)); // 0xA8 M_PreExtrapolationTime      ( ModelPrimitiveType double double double Double )
            value.M_DisplayName                             = GetString(new IntPtr(p + 0x0B0)); // 0xB0 M_DisplayName               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
