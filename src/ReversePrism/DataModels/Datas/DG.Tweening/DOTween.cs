using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Version                                  string IL2CPP_TYPE_STRING
    // 008 useSafeMode                              bool IL2CPP_TYPE_BOOLEAN
    // 00C nestedTweenFailureBehaviour              NestedTweenFailureBehaviour IL2CPP_TYPE_VALUETYPE
    // 010 ShowUnityEditorReport                    ModelPrimitiveType bool bool bool Bool
    // 014 TimeScale                                ModelPrimitiveType float float float Single
    // 018 UseSmoothDeltaTime                       ModelPrimitiveType bool bool bool Bool
    // 01C MaxSmoothUnscaledTime                    ModelPrimitiveType float float float Single
    // 020 RewindCallbackMode                       ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32
    // 024 LogBehaviour                             ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32
    // 028 onWillLog                                Func`3<LogType, <object>, bool> IL2CPP_TYPE_GENERICINST
    // 030 DrawGizmos                               ModelPrimitiveType bool bool bool Bool
    // 031 DebugMode                                ModelPrimitiveType bool bool bool Bool
    // 032 FooDebugStoreTargetId                    ModelPrimitiveType bool bool bool Bool
    // 034 DefaultUpdateType                        ModelEnumType UpdateType UpdateType UpdateType Int32
    // 038 DefaultTimeScaleIndependent              ModelPrimitiveType bool bool bool Bool
    // 03C DefaultAutoPlay                          ModelEnumType AutoPlay AutoPlay AutoPlay Int32
    // 040 DefaultAutoKill                          ModelPrimitiveType bool bool bool Bool
    // 044 DefaultLoopType                          ModelEnumType LoopType LoopType LoopType Int32
    // 048 DefaultRecyclable                        ModelPrimitiveType bool bool bool Bool
    // 04C DefaultEaseType                          ModelEnumType Ease Ease Ease Int32
    // 050 DefaultEaseOvershootOrAmplitude          ModelPrimitiveType float float float Single
    // 054 DefaultEasePeriod                        ModelPrimitiveType float float float Single
    // 058 Instance                                 ModelClassType DOTweenComponent DOTweenComponent DOTweenComponent Pointer
    // 060 MaxActiveTweenersReached                 ModelPrimitiveType int int int Int32
    // 064 MaxActiveSequencesReached                ModelPrimitiveType int int int Int32
    // 068 SafeModeReport                           ModelEnumType SafeModeReport SafeModeReport SafeModeReport Int32
    // 078 GizmosDelegates                          ModelClassListType List`1<TweenCallback> List`1<TweenCallback> List<TweenCallback> Pointer
    // 080 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 081 IsQuitting                               ModelPrimitiveType bool bool bool Bool
    public partial class DOTween : DataModel
    {
        public bool                                     ShowUnityEditorReport                   { get; set; }
        public float                                    TimeScale                               { get; set; }
        public bool                                     UseSmoothDeltaTime                      { get; set; }
        public float                                    MaxSmoothUnscaledTime                   { get; set; }
        public RewindCallbackMode                       RewindCallbackMode                      { get; set; }
        public LogBehaviour                             LogBehaviour                            { get; set; }
        public bool                                     DrawGizmos                              { get; set; }
        public bool                                     DebugMode                               { get; set; }
        public bool                                     FooDebugStoreTargetId                   { get; set; }
        public UpdateType                               DefaultUpdateType                       { get; set; }
        public bool                                     DefaultTimeScaleIndependent             { get; set; }
        public AutoPlay                                 DefaultAutoPlay                         { get; set; }
        public bool                                     DefaultAutoKill                         { get; set; }
        public LoopType                                 DefaultLoopType                         { get; set; }
        public bool                                     DefaultRecyclable                       { get; set; }
        public Ease                                     DefaultEaseType                         { get; set; }
        public float                                    DefaultEaseOvershootOrAmplitude         { get; set; }
        public float                                    DefaultEasePeriod                       { get; set; }
        public DOTweenComponent?                        Instance                                { get; set; }
        public int                                      MaxActiveTweenersReached                { get; set; }
        public int                                      MaxActiveSequencesReached               { get; set; }
        public SafeModeReport                           SafeModeReport                          { get; set; }
        public List<TweenCallback>?                     GizmosDelegates                         { get; set; }
        public bool                                     Initialized                             { get; set; }
        public bool                                     IsQuitting                              { get; set; }

        public static DOTween? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DOTween() { Pointer= p0 };

            value.ShowUnityEditorReport                     = GetBool(new IntPtr(p + 0x010)); // 0x10 ShowUnityEditorReport       ( ModelPrimitiveType bool bool bool Bool )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 TimeScale                   ( ModelPrimitiveType float float float Single )
            value.UseSmoothDeltaTime                        = GetBool(new IntPtr(p + 0x018)); // 0x18 UseSmoothDeltaTime          ( ModelPrimitiveType bool bool bool Bool )
            value.MaxSmoothUnscaledTime                     = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MaxSmoothUnscaledTime       ( ModelPrimitiveType float float float Single )
            value.RewindCallbackMode                        = (RewindCallbackMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 RewindCallbackMode          ( ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32 )
            value.LogBehaviour                              = (LogBehaviour)GetInt32(new IntPtr(p + 0x024)); // 0x24 LogBehaviour                ( ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32 )
            value.DrawGizmos                                = GetBool(new IntPtr(p + 0x030)); // 0x30 DrawGizmos                  ( ModelPrimitiveType bool bool bool Bool )
            value.DebugMode                                 = GetBool(new IntPtr(p + 0x031)); // 0x31 DebugMode                   ( ModelPrimitiveType bool bool bool Bool )
            value.FooDebugStoreTargetId                     = GetBool(new IntPtr(p + 0x032)); // 0x32 FooDebugStoreTargetId       ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultUpdateType                         = (UpdateType)GetInt32(new IntPtr(p + 0x034)); // 0x34 DefaultUpdateType           ( ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.DefaultTimeScaleIndependent               = GetBool(new IntPtr(p + 0x038)); // 0x38 DefaultTimeScaleIndependent ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultAutoPlay                           = (AutoPlay)GetInt32(new IntPtr(p + 0x03C)); // 0x3C DefaultAutoPlay             ( ModelEnumType AutoPlay AutoPlay AutoPlay Int32 )
            value.DefaultAutoKill                           = GetBool(new IntPtr(p + 0x040)); // 0x40 DefaultAutoKill             ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultLoopType                           = (LoopType)GetInt32(new IntPtr(p + 0x044)); // 0x44 DefaultLoopType             ( ModelEnumType LoopType LoopType LoopType Int32 )
            value.DefaultRecyclable                         = GetBool(new IntPtr(p + 0x048)); // 0x48 DefaultRecyclable           ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultEaseType                           = (Ease)GetInt32(new IntPtr(p + 0x04C)); // 0x4C DefaultEaseType             ( ModelEnumType Ease Ease Ease Int32 )
            value.DefaultEaseOvershootOrAmplitude           = GetSingle(new IntPtr(p + 0x050)); // 0x50 DefaultEaseOvershootOrAmplitude ( ModelPrimitiveType float float float Single )
            value.DefaultEasePeriod                         = GetSingle(new IntPtr(p + 0x054)); // 0x54 DefaultEasePeriod           ( ModelPrimitiveType float float float Single )
            value.Instance                                  = GetObject<DOTweenComponent>(new IntPtr(p + 0x058), ReversePrism.DataModels.DOTweenComponent.FromPointer); // 0x58 Instance                    ( ModelClassType DOTweenComponent DOTweenComponent DOTweenComponent Pointer )
            value.MaxActiveTweenersReached                  = GetInt32(new IntPtr(p + 0x060)); // 0x60 MaxActiveTweenersReached    ( ModelPrimitiveType int int int Int32 )
            value.MaxActiveSequencesReached                 = GetInt32(new IntPtr(p + 0x064)); // 0x64 MaxActiveSequencesReached   ( ModelPrimitiveType int int int Int32 )
            value.SafeModeReport                            = (SafeModeReport)GetInt32(new IntPtr(p + 0x068)); // 0x68 SafeModeReport              ( ModelEnumType SafeModeReport SafeModeReport SafeModeReport Int32 )
            value.GizmosDelegates                           = GetObjectList<TweenCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x78 GizmosDelegates             ( ModelClassListType List`1<TweenCallback> List`1<TweenCallback> List<TweenCallback> Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x080)); // 0x80 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsQuitting                                = GetBool(new IntPtr(p + 0x081)); // 0x81 IsQuitting                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
