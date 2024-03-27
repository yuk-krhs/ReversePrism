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
    // 010 ShowUnityEditorReport                    000186596380 ModelPrimitiveType bool bool bool Bool
    // 014 TimeScale                                000186666A20 ModelPrimitiveType float float float Single
    // 018 UseSmoothDeltaTime                       000186596380 ModelPrimitiveType bool bool bool Bool
    // 01C MaxSmoothUnscaledTime                    000186666A20 ModelPrimitiveType float float float Single
    // 020 RewindCallbackMode                       0001866812F0 ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32
    // 024 LogBehaviour                             0001865AC0A0 ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32
    // 028 onWillLog                                Func`3<LogType, <object>, bool> IL2CPP_TYPE_GENERICINST
    // 030 DrawGizmos                               000186596380 ModelPrimitiveType bool bool bool Bool
    // 031 DebugMode                                000186596380 ModelPrimitiveType bool bool bool Bool
    // 032 FooDebugStoreTargetId                    000186595C30 ModelPrimitiveType bool bool bool Bool
    // 034 DefaultUpdateType                        000186742580 ModelEnumType UpdateType UpdateType UpdateType Int32
    // 038 DefaultTimeScaleIndependent              000186596380 ModelPrimitiveType bool bool bool Bool
    // 03C DefaultAutoPlay                          000186728660 ModelEnumType AutoPlay AutoPlay AutoPlay Int32
    // 040 DefaultAutoKill                          000186596380 ModelPrimitiveType bool bool bool Bool
    // 044 DefaultLoopType                          0001865C0EC0 ModelEnumType LoopType LoopType LoopType Int32
    // 048 DefaultRecyclable                        000186596380 ModelPrimitiveType bool bool bool Bool
    // 04C DefaultEaseType                          0001867173C0 ModelEnumType Ease Ease Ease Int32
    // 050 DefaultEaseOvershootOrAmplitude          000186666A20 ModelPrimitiveType float float float Single
    // 054 DefaultEasePeriod                        000186666A20 ModelPrimitiveType float float float Single
    // 058 Instance                                 000186671E20 ModelClassType DOTweenComponent DOTweenComponent DOTweenComponent Pointer
    // 060 MaxActiveTweenersReached                 0001865F3B80 ModelPrimitiveType int int int Int32
    // 064 MaxActiveSequencesReached                0001865F3B80 ModelPrimitiveType int int int Int32
    // 068 SafeModeReport                           0001866BA250 ModelEnumType SafeModeReport SafeModeReport SafeModeReport Int32
    // 078 GizmosDelegates                          000185D16988 ModelClassListType List`1<TweenCallback> List`1<TweenCallback> List<TweenCallback> Pointer
    // 080 Initialized                              000186595E60 ModelPrimitiveType bool bool bool Bool
    // 081 IsQuitting                               000186595E60 ModelPrimitiveType bool bool bool Bool
    public partial class DOTween
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
            var value   = new DOTween();

            value.ShowUnityEditorReport                     = GetBool(new IntPtr(p + 0x010)); // 0270D302D580 0x10 ShowUnityEditorReport       ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x014)); // 0270D302D5A0 0x14 TimeScale                   ( 000186666A20 ModelPrimitiveType float float float Single )
            value.UseSmoothDeltaTime                        = GetBool(new IntPtr(p + 0x018)); // 0270D302D5C0 0x18 UseSmoothDeltaTime          ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.MaxSmoothUnscaledTime                     = GetSingle(new IntPtr(p + 0x01C)); // 0270D302D5E0 0x1C MaxSmoothUnscaledTime       ( 000186666A20 ModelPrimitiveType float float float Single )
            value.RewindCallbackMode                        = (RewindCallbackMode)GetInt32(new IntPtr(p + 0x020)); // 0270D302D600 0x20 RewindCallbackMode          ( 0001866812F0 ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32 )
            value.LogBehaviour                              = (LogBehaviour)GetInt32(new IntPtr(p + 0x024)); // 0270D302D620 0x24 LogBehaviour                ( 0001865AC0A0 ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32 )
            value.DrawGizmos                                = GetBool(new IntPtr(p + 0x030)); // 0270D302D660 0x30 DrawGizmos                  ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.DebugMode                                 = GetBool(new IntPtr(p + 0x031)); // 0270D302D680 0x31 DebugMode                   ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.FooDebugStoreTargetId                     = GetBool(new IntPtr(p + 0x032)); // 0270D302D6A0 0x32 FooDebugStoreTargetId       ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.DefaultUpdateType                         = (UpdateType)GetInt32(new IntPtr(p + 0x034)); // 0270D302D6C0 0x34 DefaultUpdateType           ( 000186742580 ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.DefaultTimeScaleIndependent               = GetBool(new IntPtr(p + 0x038)); // 0270D302D6E0 0x38 DefaultTimeScaleIndependent ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.DefaultAutoPlay                           = (AutoPlay)GetInt32(new IntPtr(p + 0x03C)); // 0270D302D700 0x3C DefaultAutoPlay             ( 000186728660 ModelEnumType AutoPlay AutoPlay AutoPlay Int32 )
            value.DefaultAutoKill                           = GetBool(new IntPtr(p + 0x040)); // 0270D302D720 0x40 DefaultAutoKill             ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.DefaultLoopType                           = (LoopType)GetInt32(new IntPtr(p + 0x044)); // 0270D302D740 0x44 DefaultLoopType             ( 0001865C0EC0 ModelEnumType LoopType LoopType LoopType Int32 )
            value.DefaultRecyclable                         = GetBool(new IntPtr(p + 0x048)); // 0270D302D760 0x48 DefaultRecyclable           ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.DefaultEaseType                           = (Ease)GetInt32(new IntPtr(p + 0x04C)); // 0270D302D780 0x4C DefaultEaseType             ( 0001867173C0 ModelEnumType Ease Ease Ease Int32 )
            value.DefaultEaseOvershootOrAmplitude           = GetSingle(new IntPtr(p + 0x050)); // 0270D302D7A0 0x50 DefaultEaseOvershootOrAmplitude ( 000186666A20 ModelPrimitiveType float float float Single )
            value.DefaultEasePeriod                         = GetSingle(new IntPtr(p + 0x054)); // 0270D302D7C0 0x54 DefaultEasePeriod           ( 000186666A20 ModelPrimitiveType float float float Single )
            value.Instance                                  = GetObject<DOTweenComponent>(new IntPtr(p + 0x058), ReversePrism.DataModels.DOTweenComponent.FromPointer); // 0270D302D7E0 0x58 Instance                    ( 000186671E20 ModelClassType DOTweenComponent DOTweenComponent DOTweenComponent Pointer )
            value.MaxActiveTweenersReached                  = GetInt32(new IntPtr(p + 0x060)); // 0270D302D800 0x60 MaxActiveTweenersReached    ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.MaxActiveSequencesReached                 = GetInt32(new IntPtr(p + 0x064)); // 0270D302D820 0x64 MaxActiveSequencesReached   ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.SafeModeReport                            = (SafeModeReport)GetInt32(new IntPtr(p + 0x068)); // 0270D302D840 0x68 SafeModeReport              ( 0001866BA250 ModelEnumType SafeModeReport SafeModeReport SafeModeReport Int32 )
            value.GizmosDelegates                           = GetObjectList<TweenCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.TweenCallback.FromPointer); // 0270D302D860 0x78 GizmosDelegates             ( 000185D16988 ModelClassListType List`1<TweenCallback> List`1<TweenCallback> List<TweenCallback> Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x080)); // 0270D302D880 0x80 Initialized                 ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.IsQuitting                                = GetBool(new IntPtr(p + 0x081)); // 0270D302D8A0 0x81 IsQuitting                  ( 000186595E60 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
