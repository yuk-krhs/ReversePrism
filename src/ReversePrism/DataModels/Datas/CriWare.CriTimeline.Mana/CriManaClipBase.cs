using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Guid                                     ModelEnumType Guid Guid Guid Int32
    // 028 M_loopWithinClip                         ModelPrimitiveType bool bool bool Bool
    // 029 M_useOnMemoryPlayback                    ModelPrimitiveType bool bool bool Bool
    // 030 GcHandle                                 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 038 M_movieFrameRate                         ModelPrimitiveType double double double Double
    // 040 M_clipDuration                           ModelPrimitiveType double double double Double
    // 048 M_fadeinDuration                         ModelPrimitiveType float float float Single
    // 050 M_fadeinCurve                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 M_fadeoutDuration                        ModelPrimitiveType float float float Single
    // 060 M_fadeoutCurve                           ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 068 M_fadeAudio                              ModelPrimitiveType bool bool bool Bool
    // 070 M_clip                                   ModelClassType TimelineClip TimelineClip TimelineClip Pointer
    // 078 M_manaBehaviour                          ModelClassType CriManaBehaviour CriManaBehaviour CriManaBehaviour Pointer
    // 080 m_movieInfoStruct                        Nullable`1<MovieInfoStruct> IL2CPP_TYPE_GENERICINST
    public partial class CriManaClipBase : DataModel
    {
        public Guid                                     Guid                                    { get; set; }
        public bool                                     M_loopWithinClip                        { get; set; }
        public bool                                     M_useOnMemoryPlayback                   { get; set; }
        public GCHandle                                 GcHandle                                { get; set; }
        public double                                   M_movieFrameRate                        { get; set; }
        public double                                   M_clipDuration                          { get; set; }
        public float                                    M_fadeinDuration                        { get; set; }
        public AnimationCurve?                          M_fadeinCurve                           { get; set; }
        public float                                    M_fadeoutDuration                       { get; set; }
        public AnimationCurve?                          M_fadeoutCurve                          { get; set; }
        public bool                                     M_fadeAudio                             { get; set; }
        public TimelineClip?                            M_clip                                  { get; set; }
        public CriManaBehaviour?                        M_manaBehaviour                         { get; set; }

        public static CriManaClipBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaClipBase() { Pointer= p0 };

            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x018)); // 0x18 Guid                        ( ModelEnumType Guid Guid Guid Int32 )
            value.M_loopWithinClip                          = GetBool(new IntPtr(p + 0x028)); // 0x28 M_loopWithinClip            ( ModelPrimitiveType bool bool bool Bool )
            value.M_useOnMemoryPlayback                     = GetBool(new IntPtr(p + 0x029)); // 0x29 M_useOnMemoryPlayback       ( ModelPrimitiveType bool bool bool Bool )
            value.GcHandle                                  = (GCHandle)GetInt32(new IntPtr(p + 0x030)); // 0x30 GcHandle                    ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.M_movieFrameRate                          = GetDouble(new IntPtr(p + 0x038)); // 0x38 M_movieFrameRate            ( ModelPrimitiveType double double double Double )
            value.M_clipDuration                            = GetDouble(new IntPtr(p + 0x040)); // 0x40 M_clipDuration              ( ModelPrimitiveType double double double Double )
            value.M_fadeinDuration                          = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_fadeinDuration            ( ModelPrimitiveType float float float Single )
            value.M_fadeinCurve                             = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x50 M_fadeinCurve               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_fadeoutDuration                         = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_fadeoutDuration           ( ModelPrimitiveType float float float Single )
            value.M_fadeoutCurve                            = GetObject<AnimationCurve>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x60 M_fadeoutCurve              ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_fadeAudio                               = GetBool(new IntPtr(p + 0x068)); // 0x68 M_fadeAudio                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_clip                                    = GetObject<TimelineClip>(new IntPtr(p + 0x070), ReversePrism.DataModels.TimelineClip.FromPointer); // 0x70 M_clip                      ( ModelClassType TimelineClip TimelineClip TimelineClip Pointer )
            value.M_manaBehaviour                           = GetObject<CriManaBehaviour>(new IntPtr(p + 0x078), ReversePrism.DataModels.CriManaBehaviour.FromPointer); // 0x78 M_manaBehaviour             ( ModelClassType CriManaBehaviour CriManaBehaviour CriManaBehaviour Pointer )

            return value;
        }
    }
}
