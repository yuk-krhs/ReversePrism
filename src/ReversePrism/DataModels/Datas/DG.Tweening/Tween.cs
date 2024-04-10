using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 TimeScale                                000186666050 ModelPrimitiveType float float float Single
    // 02C IsBackwards                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 id                                       <object> IL2CPP_TYPE_OBJECT
    // 038 StringId                                 0001866722E0 ModelPrimitiveType string string string String
    // 040 IntId                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 target                                   <object> IL2CPP_TYPE_OBJECT
    // 050 UpdateType                               0001867420B0 ModelEnumType UpdateType UpdateType UpdateType Int32
    // 054 IsIndependentUpdate                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 058 OnPlay                                   0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 060 OnPause                                  0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 068 OnRewind                                 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 070 OnUpdate                                 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 078 OnStepComplete                           0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 080 OnComplete                               0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 088 OnKill                                   0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 090 onWaypointChange                         TweenCallback`1<int> IL2CPP_TYPE_GENERICINST
    // 098 IsFrom                                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 099 IsBlendable                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 09A IsRecyclable                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 09B IsSpeedBased                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 09C AutoKill                                 000186595210 ModelPrimitiveType bool bool bool Bool
    // 0A0 Duration                                 000186665900 ModelPrimitiveType float float float Single
    // 0A4 Loops                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 0A8 LoopType                                 0001865C09A0 ModelEnumType LoopType LoopType LoopType Int32
    // 0AC Delay                                    000186665900 ModelPrimitiveType float float float Single
    // 0B0 IsRelative                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B4 EaseType                                 000186716EE0 ModelEnumType Ease Ease Ease Int32
    // 0B8 CustomEase                               000186718C70 ModelClassType EaseFunction EaseFunction EaseFunction Pointer
    // 0C0 EaseOvershootOrAmplitude                 000186666050 ModelPrimitiveType float float float Single
    // 0C4 EasePeriod                               000186666050 ModelPrimitiveType float float float Single
    // 0C8 DebugTargetId                            0001866722E0 ModelPrimitiveType string string string String
    // 0D0 TypeofT1                                 000186692A80 ModelClassType Type Type Type Pointer
    // 0D8 TypeofT2                                 000186692A80 ModelClassType Type Type Type Pointer
    // 0E0 TypeofTPlugOptions                       000186692A80 ModelClassType Type Type Type Pointer
    // 0E8 Active                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E9 IsSequenced                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 0F0 SequenceParent                           000186726710 ModelClassType Sequence Sequence Sequence Pointer
    // 0F8 ActiveId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 0FC SpecialStartupMode                       00018654AC40 ModelEnumType SpecialStartupMode SpecialStartupMode SpecialStartupMode Int32
    // 100 CreationLocked                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 101 StartupDone                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 102 PlayedOnce                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 104 Position                                 0001866656B0 ModelPrimitiveType float float float Single
    // 108 FullDuration                             000186665900 ModelPrimitiveType float float float Single
    // 10C CompletedLoops                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 110 IsPlaying                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 111 IsComplete                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 114 ElapsedDelay                             000186665900 ModelPrimitiveType float float float Single
    // 118 DelayComplete                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 11C MiscInt                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class Tween : DataModel
    {
        public float                                    TimeScale                               { get; set; }
        public bool                                     IsBackwards                             { get; set; }
        public string                                   StringId                                { get; set; }
        public int                                      IntId                                   { get; set; }
        public UpdateType                               UpdateType                              { get; set; }
        public bool                                     IsIndependentUpdate                     { get; set; }
        public TweenCallback?                           OnPlay                                  { get; set; }
        public TweenCallback?                           OnPause                                 { get; set; }
        public TweenCallback?                           OnRewind                                { get; set; }
        public TweenCallback?                           OnUpdate                                { get; set; }
        public TweenCallback?                           OnStepComplete                          { get; set; }
        public TweenCallback?                           OnComplete                              { get; set; }
        public TweenCallback?                           OnKill                                  { get; set; }
        public bool                                     IsFrom                                  { get; set; }
        public bool                                     IsBlendable                             { get; set; }
        public bool                                     IsRecyclable                            { get; set; }
        public bool                                     IsSpeedBased                            { get; set; }
        public bool                                     AutoKill                                { get; set; }
        public float                                    Duration                                { get; set; }
        public int                                      Loops                                   { get; set; }
        public LoopType                                 LoopType                                { get; set; }
        public float                                    Delay                                   { get; set; }
        public bool                                     IsRelative                              { get; set; }
        public Ease                                     EaseType                                { get; set; }
        public EaseFunction?                            CustomEase                              { get; set; }
        public float                                    EaseOvershootOrAmplitude                { get; set; }
        public float                                    EasePeriod                              { get; set; }
        public string                                   DebugTargetId                           { get; set; }
        public Type?                                    TypeofT1                                { get; set; }
        public Type?                                    TypeofT2                                { get; set; }
        public Type?                                    TypeofTPlugOptions                      { get; set; }
        public bool                                     Active                                  { get; set; }
        public bool                                     IsSequenced                             { get; set; }
        public Sequence?                                SequenceParent                          { get; set; }
        public int                                      ActiveId                                { get; set; }
        public SpecialStartupMode                       SpecialStartupMode                      { get; set; }
        public bool                                     CreationLocked                          { get; set; }
        public bool                                     StartupDone                             { get; set; }
        public bool                                     PlayedOnce                              { get; set; }
        public float                                    Position                                { get; set; }
        public float                                    FullDuration                            { get; set; }
        public int                                      CompletedLoops                          { get; set; }
        public bool                                     IsPlaying                               { get; set; }
        public bool                                     IsComplete                              { get; set; }
        public float                                    ElapsedDelay                            { get; set; }
        public bool                                     DelayComplete                           { get; set; }
        public int                                      MiscInt                                 { get; set; }

        public static Tween? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tween() { Pointer= p0 };

            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x028)); // 0245A43A8450 0x28 TimeScale                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.IsBackwards                               = GetBool(new IntPtr(p + 0x02C)); // 0245A43A8470 0x2C IsBackwards                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.StringId                                  = GetString(new IntPtr(p + 0x038)); // 0245A43A84B0 0x38 StringId                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IntId                                     = GetInt32(new IntPtr(p + 0x040)); // 0245A43A84D0 0x40 IntId                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UpdateType                                = (UpdateType)GetInt32(new IntPtr(p + 0x050)); // 0245A43A8510 0x50 UpdateType                  ( 0001867420B0 ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.IsIndependentUpdate                       = GetBool(new IntPtr(p + 0x054)); // 0245A43A8530 0x54 IsIndependentUpdate         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.OnPlay                                    = GetObject<TweenCallback>(new IntPtr(p + 0x058), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43A8550 0x58 OnPlay                      ( 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnPause                                   = GetObject<TweenCallback>(new IntPtr(p + 0x060), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43A8570 0x60 OnPause                     ( 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnRewind                                  = GetObject<TweenCallback>(new IntPtr(p + 0x068), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43A8590 0x68 OnRewind                    ( 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnUpdate                                  = GetObject<TweenCallback>(new IntPtr(p + 0x070), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43A85B0 0x70 OnUpdate                    ( 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnStepComplete                            = GetObject<TweenCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43A85D0 0x78 OnStepComplete              ( 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnComplete                                = GetObject<TweenCallback>(new IntPtr(p + 0x080), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43A85F0 0x80 OnComplete                  ( 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnKill                                    = GetObject<TweenCallback>(new IntPtr(p + 0x088), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43A8610 0x88 OnKill                      ( 0001866C0840 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.IsFrom                                    = GetBool(new IntPtr(p + 0x098)); // 0245A43A8650 0x98 IsFrom                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsBlendable                               = GetBool(new IntPtr(p + 0x099)); // 0245A43A8670 0x99 IsBlendable                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsRecyclable                              = GetBool(new IntPtr(p + 0x09A)); // 0245A43A8690 0x9A IsRecyclable                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsSpeedBased                              = GetBool(new IntPtr(p + 0x09B)); // 0245A43A86B0 0x9B IsSpeedBased                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.AutoKill                                  = GetBool(new IntPtr(p + 0x09C)); // 0245A43A86D0 0x9C AutoKill                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x0A0)); // 0245A43A86F0 0xA0 Duration                    ( 000186665900 ModelPrimitiveType float float float Single )
            value.Loops                                     = GetInt32(new IntPtr(p + 0x0A4)); // 0245A43A8710 0xA4 Loops                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.LoopType                                  = (LoopType)GetInt32(new IntPtr(p + 0x0A8)); // 0245A43A8730 0xA8 LoopType                    ( 0001865C09A0 ModelEnumType LoopType LoopType LoopType Int32 )
            value.Delay                                     = GetSingle(new IntPtr(p + 0x0AC)); // 0245A43A8750 0xAC Delay                       ( 000186665900 ModelPrimitiveType float float float Single )
            value.IsRelative                                = GetBool(new IntPtr(p + 0x0B0)); // 0245A43A8770 0xB0 IsRelative                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x0B4)); // 0245A43A8790 0xB4 EaseType                    ( 000186716EE0 ModelEnumType Ease Ease Ease Int32 )
            value.CustomEase                                = GetObject<EaseFunction>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.EaseFunction.FromPointer); // 0245A43A87B0 0xB8 CustomEase                  ( 000186718C70 ModelClassType EaseFunction EaseFunction EaseFunction Pointer )
            value.EaseOvershootOrAmplitude                  = GetSingle(new IntPtr(p + 0x0C0)); // 0245A43A87D0 0xC0 EaseOvershootOrAmplitude    ( 000186666050 ModelPrimitiveType float float float Single )
            value.EasePeriod                                = GetSingle(new IntPtr(p + 0x0C4)); // 0245A43A87F0 0xC4 EasePeriod                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.DebugTargetId                             = GetString(new IntPtr(p + 0x0C8)); // 0245A43A8810 0xC8 DebugTargetId               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TypeofT1                                  = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 0245A43A8830 0xD0 TypeofT1                    ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.TypeofT2                                  = GetObject<Type>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Type.FromPointer); // 0245A43A8850 0xD8 TypeofT2                    ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.TypeofTPlugOptions                        = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0245A43A8870 0xE0 TypeofTPlugOptions          ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.Active                                    = GetBool(new IntPtr(p + 0x0E8)); // 0245A43A8890 0xE8 Active                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSequenced                               = GetBool(new IntPtr(p + 0x0E9)); // 0245A43A88B0 0xE9 IsSequenced                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.SequenceParent                            = GetObject<Sequence>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Sequence.FromPointer); // 0245A43A88D0 0xF0 SequenceParent              ( 000186726710 ModelClassType Sequence Sequence Sequence Pointer )
            value.ActiveId                                  = GetInt32(new IntPtr(p + 0x0F8)); // 0245A43A88F0 0xF8 ActiveId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.SpecialStartupMode                        = (SpecialStartupMode)GetInt32(new IntPtr(p + 0x0FC)); // 0245A43A8910 0xFC SpecialStartupMode          ( 00018654AC40 ModelEnumType SpecialStartupMode SpecialStartupMode SpecialStartupMode Int32 )
            value.CreationLocked                            = GetBool(new IntPtr(p + 0x100)); // 0245A43A8930 0x100 CreationLocked              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.StartupDone                               = GetBool(new IntPtr(p + 0x101)); // 0245A43A8950 0x101 StartupDone                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PlayedOnce                                = GetBool(new IntPtr(p + 0x102)); // 0245A43A8970 0x102 PlayedOnce                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetSingle(new IntPtr(p + 0x104)); // 0245A43A8990 0x104 Position                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FullDuration                              = GetSingle(new IntPtr(p + 0x108)); // 0245A43A89B0 0x108 FullDuration                ( 000186665900 ModelPrimitiveType float float float Single )
            value.CompletedLoops                            = GetInt32(new IntPtr(p + 0x10C)); // 0245A43A89D0 0x10C CompletedLoops              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x110)); // 0245A43A89F0 0x110 IsPlaying                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsComplete                                = GetBool(new IntPtr(p + 0x111)); // 0245A43A8A10 0x111 IsComplete                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ElapsedDelay                              = GetSingle(new IntPtr(p + 0x114)); // 0245A43A8A30 0x114 ElapsedDelay                ( 000186665900 ModelPrimitiveType float float float Single )
            value.DelayComplete                             = GetBool(new IntPtr(p + 0x118)); // 0245A43A8A50 0x118 DelayComplete               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.MiscInt                                   = GetInt32(new IntPtr(p + 0x11C)); // 0245A43A8A70 0x11C MiscInt                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
