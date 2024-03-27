using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Guid                                     0001865DC840 ModelEnumType Guid Guid Guid Int32
    // 028 M_loopWithinClip                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 029 M_useOnMemoryPlayback                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 GcHandle                                 0001865D93A0 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 038 M_movieFrameRate                         0001865C2950 ModelPrimitiveType double double double Double
    // 040 M_clipDuration                           0001865C2950 ModelPrimitiveType double double double Double
    // 048 M_fadeinDuration                         000186666050 ModelPrimitiveType float float float Single
    // 050 M_fadeinCurve                            000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 M_fadeoutDuration                        000186666050 ModelPrimitiveType float float float Single
    // 060 M_fadeoutCurve                           000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 068 M_fadeAudio                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 070 M_clip                                   00018666E050 ModelClassType TimelineClip TimelineClip TimelineClip Pointer
    // 078 M_manaBehaviour                          000186658A20 ModelClassType CriManaBehaviour CriManaBehaviour CriManaBehaviour Pointer
    // 080 m_movieInfoStruct                        Nullable`1<MovieInfoStruct> IL2CPP_TYPE_GENERICINST
    public partial class CriManaClipBase
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
            var value   = new CriManaClipBase();

            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x018)); // 0270DACC31F0 0x18 Guid                        ( 0001865DC840 ModelEnumType Guid Guid Guid Int32 )
            value.M_loopWithinClip                          = GetBool(new IntPtr(p + 0x028)); // 0270DACC3210 0x28 M_loopWithinClip            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_useOnMemoryPlayback                     = GetBool(new IntPtr(p + 0x029)); // 0270DACC3230 0x29 M_useOnMemoryPlayback       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.GcHandle                                  = (GCHandle)GetInt32(new IntPtr(p + 0x030)); // 0270DACC3250 0x30 GcHandle                    ( 0001865D93A0 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.M_movieFrameRate                          = GetDouble(new IntPtr(p + 0x038)); // 0270DACC3270 0x38 M_movieFrameRate            ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_clipDuration                            = GetDouble(new IntPtr(p + 0x040)); // 0270DACC3290 0x40 M_clipDuration              ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_fadeinDuration                          = GetSingle(new IntPtr(p + 0x048)); // 0270DACC32B0 0x48 M_fadeinDuration            ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_fadeinCurve                             = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270DACC32D0 0x50 M_fadeinCurve               ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_fadeoutDuration                         = GetSingle(new IntPtr(p + 0x058)); // 0270DACC32F0 0x58 M_fadeoutDuration           ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_fadeoutCurve                            = GetObject<AnimationCurve>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270DACC3310 0x60 M_fadeoutCurve              ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_fadeAudio                               = GetBool(new IntPtr(p + 0x068)); // 0270DACC3330 0x68 M_fadeAudio                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_clip                                    = GetObject<TimelineClip>(new IntPtr(p + 0x070), ReversePrism.DataModels.TimelineClip.FromPointer); // 0270DACC3350 0x70 M_clip                      ( 00018666E050 ModelClassType TimelineClip TimelineClip TimelineClip Pointer )
            value.M_manaBehaviour                           = GetObject<CriManaBehaviour>(new IntPtr(p + 0x078), ReversePrism.DataModels.CriManaBehaviour.FromPointer); // 0270DACC3370 0x78 M_manaBehaviour             ( 000186658A20 ModelClassType CriManaBehaviour CriManaBehaviour CriManaBehaviour Pointer )

            return value;
        }
    }
}
