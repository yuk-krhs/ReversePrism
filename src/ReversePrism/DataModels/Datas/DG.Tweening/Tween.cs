using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 TimeScale                                ModelPrimitiveType float float float Single
    // 02C IsBackwards                              ModelPrimitiveType bool bool bool Bool
    // 030 id                                       <object> IL2CPP_TYPE_OBJECT
    // 038 StringId                                 ModelPrimitiveType string string string String
    // 040 IntId                                    ModelPrimitiveType int int int Int32
    // 048 target                                   <object> IL2CPP_TYPE_OBJECT
    // 050 UpdateType                               ModelEnumType UpdateType UpdateType UpdateType Int32
    // 054 IsIndependentUpdate                      ModelPrimitiveType bool bool bool Bool
    // 058 OnPlay                                   ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 060 OnPause                                  ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 068 OnRewind                                 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 070 OnUpdate                                 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 078 OnStepComplete                           ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 080 OnComplete                               ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 088 OnKill                                   ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 090 onWaypointChange                         TweenCallback`1<int> IL2CPP_TYPE_GENERICINST
    // 098 IsFrom                                   ModelPrimitiveType bool bool bool Bool
    // 099 IsBlendable                              ModelPrimitiveType bool bool bool Bool
    // 09A IsRecyclable                             ModelPrimitiveType bool bool bool Bool
    // 09B IsSpeedBased                             ModelPrimitiveType bool bool bool Bool
    // 09C AutoKill                                 ModelPrimitiveType bool bool bool Bool
    // 0A0 Duration                                 ModelPrimitiveType float float float Single
    // 0A4 Loops                                    ModelPrimitiveType int int int Int32
    // 0A8 LoopType                                 ModelEnumType LoopType LoopType LoopType Int32
    // 0AC Delay                                    ModelPrimitiveType float float float Single
    // 0B0 IsRelative                               ModelPrimitiveType bool bool bool Bool
    // 0B4 EaseType                                 ModelEnumType Ease Ease Ease Int32
    // 0B8 CustomEase                               ModelClassType EaseFunction EaseFunction EaseFunction Pointer
    // 0C0 EaseOvershootOrAmplitude                 ModelPrimitiveType float float float Single
    // 0C4 EasePeriod                               ModelPrimitiveType float float float Single
    // 0C8 DebugTargetId                            ModelPrimitiveType string string string String
    // 0D0 TypeofT1                                 ModelClassType Type Type Type Pointer
    // 0D8 TypeofT2                                 ModelClassType Type Type Type Pointer
    // 0E0 TypeofTPlugOptions                       ModelClassType Type Type Type Pointer
    // 0E8 Active                                   ModelPrimitiveType bool bool bool Bool
    // 0E9 IsSequenced                              ModelPrimitiveType bool bool bool Bool
    // 0F0 SequenceParent                           ModelClassType Sequence Sequence Sequence Pointer
    // 0F8 ActiveId                                 ModelPrimitiveType int int int Int32
    // 0FC SpecialStartupMode                       ModelEnumType SpecialStartupMode SpecialStartupMode SpecialStartupMode Int32
    // 100 CreationLocked                           ModelPrimitiveType bool bool bool Bool
    // 101 StartupDone                              ModelPrimitiveType bool bool bool Bool
    // 102 PlayedOnce                               ModelPrimitiveType bool bool bool Bool
    // 104 Position                                 ModelPrimitiveType float float float Single
    // 108 FullDuration                             ModelPrimitiveType float float float Single
    // 10C CompletedLoops                           ModelPrimitiveType int int int Int32
    // 110 IsPlaying                                ModelPrimitiveType bool bool bool Bool
    // 111 IsComplete                               ModelPrimitiveType bool bool bool Bool
    // 114 ElapsedDelay                             ModelPrimitiveType float float float Single
    // 118 DelayComplete                            ModelPrimitiveType bool bool bool Bool
    // 11C MiscInt                                  ModelPrimitiveType int int int Int32
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

            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 TimeScale                   ( ModelPrimitiveType float float float Single )
            value.IsBackwards                               = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsBackwards                 ( ModelPrimitiveType bool bool bool Bool )
            value.StringId                                  = GetString(new IntPtr(p + 0x038)); // 0x38 StringId                    ( ModelPrimitiveType string string string String )
            value.IntId                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 IntId                       ( ModelPrimitiveType int int int Int32 )
            value.UpdateType                                = (UpdateType)GetInt32(new IntPtr(p + 0x050)); // 0x50 UpdateType                  ( ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.IsIndependentUpdate                       = GetBool(new IntPtr(p + 0x054)); // 0x54 IsIndependentUpdate         ( ModelPrimitiveType bool bool bool Bool )
            value.OnPlay                                    = GetObject<TweenCallback>(new IntPtr(p + 0x058), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x58 OnPlay                      ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnPause                                   = GetObject<TweenCallback>(new IntPtr(p + 0x060), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x60 OnPause                     ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnRewind                                  = GetObject<TweenCallback>(new IntPtr(p + 0x068), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x68 OnRewind                    ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnUpdate                                  = GetObject<TweenCallback>(new IntPtr(p + 0x070), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x70 OnUpdate                    ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnStepComplete                            = GetObject<TweenCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x78 OnStepComplete              ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnComplete                                = GetObject<TweenCallback>(new IntPtr(p + 0x080), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x80 OnComplete                  ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnKill                                    = GetObject<TweenCallback>(new IntPtr(p + 0x088), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x88 OnKill                      ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.IsFrom                                    = GetBool(new IntPtr(p + 0x098)); // 0x98 IsFrom                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsBlendable                               = GetBool(new IntPtr(p + 0x099)); // 0x99 IsBlendable                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsRecyclable                              = GetBool(new IntPtr(p + 0x09A)); // 0x9A IsRecyclable                ( ModelPrimitiveType bool bool bool Bool )
            value.IsSpeedBased                              = GetBool(new IntPtr(p + 0x09B)); // 0x9B IsSpeedBased                ( ModelPrimitiveType bool bool bool Bool )
            value.AutoKill                                  = GetBool(new IntPtr(p + 0x09C)); // 0x9C AutoKill                    ( ModelPrimitiveType bool bool bool Bool )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 Duration                    ( ModelPrimitiveType float float float Single )
            value.Loops                                     = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 Loops                       ( ModelPrimitiveType int int int Int32 )
            value.LoopType                                  = (LoopType)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 LoopType                    ( ModelEnumType LoopType LoopType LoopType Int32 )
            value.Delay                                     = GetSingle(new IntPtr(p + 0x0AC)); // 0xAC Delay                       ( ModelPrimitiveType float float float Single )
            value.IsRelative                                = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsRelative                  ( ModelPrimitiveType bool bool bool Bool )
            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 EaseType                    ( ModelEnumType Ease Ease Ease Int32 )
            value.CustomEase                                = GetObject<EaseFunction>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.EaseFunction.FromPointer); // 0xB8 CustomEase                  ( ModelClassType EaseFunction EaseFunction EaseFunction Pointer )
            value.EaseOvershootOrAmplitude                  = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 EaseOvershootOrAmplitude    ( ModelPrimitiveType float float float Single )
            value.EasePeriod                                = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 EasePeriod                  ( ModelPrimitiveType float float float Single )
            value.DebugTargetId                             = GetString(new IntPtr(p + 0x0C8)); // 0xC8 DebugTargetId               ( ModelPrimitiveType string string string String )
            value.TypeofT1                                  = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 0xD0 TypeofT1                    ( ModelClassType Type Type Type Pointer )
            value.TypeofT2                                  = GetObject<Type>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Type.FromPointer); // 0xD8 TypeofT2                    ( ModelClassType Type Type Type Pointer )
            value.TypeofTPlugOptions                        = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0xE0 TypeofTPlugOptions          ( ModelClassType Type Type Type Pointer )
            value.Active                                    = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 Active                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsSequenced                               = GetBool(new IntPtr(p + 0x0E9)); // 0xE9 IsSequenced                 ( ModelPrimitiveType bool bool bool Bool )
            value.SequenceParent                            = GetObject<Sequence>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Sequence.FromPointer); // 0xF0 SequenceParent              ( ModelClassType Sequence Sequence Sequence Pointer )
            value.ActiveId                                  = GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 ActiveId                    ( ModelPrimitiveType int int int Int32 )
            value.SpecialStartupMode                        = (SpecialStartupMode)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC SpecialStartupMode          ( ModelEnumType SpecialStartupMode SpecialStartupMode SpecialStartupMode Int32 )
            value.CreationLocked                            = GetBool(new IntPtr(p + 0x100)); // 0x100 CreationLocked              ( ModelPrimitiveType bool bool bool Bool )
            value.StartupDone                               = GetBool(new IntPtr(p + 0x101)); // 0x101 StartupDone                 ( ModelPrimitiveType bool bool bool Bool )
            value.PlayedOnce                                = GetBool(new IntPtr(p + 0x102)); // 0x102 PlayedOnce                  ( ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetSingle(new IntPtr(p + 0x104)); // 0x104 Position                    ( ModelPrimitiveType float float float Single )
            value.FullDuration                              = GetSingle(new IntPtr(p + 0x108)); // 0x108 FullDuration                ( ModelPrimitiveType float float float Single )
            value.CompletedLoops                            = GetInt32(new IntPtr(p + 0x10C)); // 0x10C CompletedLoops              ( ModelPrimitiveType int int int Int32 )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x110)); // 0x110 IsPlaying                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsComplete                                = GetBool(new IntPtr(p + 0x111)); // 0x111 IsComplete                  ( ModelPrimitiveType bool bool bool Bool )
            value.ElapsedDelay                              = GetSingle(new IntPtr(p + 0x114)); // 0x114 ElapsedDelay                ( ModelPrimitiveType float float float Single )
            value.DelayComplete                             = GetBool(new IntPtr(p + 0x118)); // 0x118 DelayComplete               ( ModelPrimitiveType bool bool bool Bool )
            value.MiscInt                                   = GetInt32(new IntPtr(p + 0x11C)); // 0x11C MiscInt                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
