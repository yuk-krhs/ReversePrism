using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Params                                   TweenParams IL2CPP_TYPE_CLASS
    // 010 id                                       <object> IL2CPP_TYPE_OBJECT
    // 018 target                                   <object> IL2CPP_TYPE_OBJECT
    // 020 UpdateType                               ModelEnumType UpdateType UpdateType UpdateType Int32
    // 024 IsIndependentUpdate                      ModelPrimitiveType bool bool bool Bool
    // 028 OnStart                                  ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 030 OnPlay                                   ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 038 OnRewind                                 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 040 OnUpdate                                 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 048 OnStepComplete                           ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 050 OnComplete                               ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 058 OnKill                                   ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 060 onWaypointChange                         TweenCallback`1<int> IL2CPP_TYPE_GENERICINST
    // 068 IsRecyclable                             ModelPrimitiveType bool bool bool Bool
    // 069 IsSpeedBased                             ModelPrimitiveType bool bool bool Bool
    // 06A AutoKill                                 ModelPrimitiveType bool bool bool Bool
    // 06C Loops                                    ModelPrimitiveType int int int Int32
    // 070 LoopType                                 ModelEnumType LoopType LoopType LoopType Int32
    // 074 Delay                                    ModelPrimitiveType float float float Single
    // 078 IsRelative                               ModelPrimitiveType bool bool bool Bool
    // 07C EaseType                                 ModelEnumType Ease Ease Ease Int32
    // 080 CustomEase                               ModelClassType EaseFunction EaseFunction EaseFunction Pointer
    // 088 EaseOvershootOrAmplitude                 ModelPrimitiveType float float float Single
    // 08C EasePeriod                               ModelPrimitiveType float float float Single
    public partial class TweenParams : DataModel
    {
        public UpdateType                               UpdateType                              { get; set; }
        public bool                                     IsIndependentUpdate                     { get; set; }
        public TweenCallback?                           OnStart                                 { get; set; }
        public TweenCallback?                           OnPlay                                  { get; set; }
        public TweenCallback?                           OnRewind                                { get; set; }
        public TweenCallback?                           OnUpdate                                { get; set; }
        public TweenCallback?                           OnStepComplete                          { get; set; }
        public TweenCallback?                           OnComplete                              { get; set; }
        public TweenCallback?                           OnKill                                  { get; set; }
        public bool                                     IsRecyclable                            { get; set; }
        public bool                                     IsSpeedBased                            { get; set; }
        public bool                                     AutoKill                                { get; set; }
        public int                                      Loops                                   { get; set; }
        public LoopType                                 LoopType                                { get; set; }
        public float                                    Delay                                   { get; set; }
        public bool                                     IsRelative                              { get; set; }
        public Ease                                     EaseType                                { get; set; }
        public EaseFunction?                            CustomEase                              { get; set; }
        public float                                    EaseOvershootOrAmplitude                { get; set; }
        public float                                    EasePeriod                              { get; set; }

        public static TweenParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenParams() { Pointer= p0 };

            value.UpdateType                                = (UpdateType)GetInt32(new IntPtr(p + 0x020)); // 0x20 UpdateType                  ( ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.IsIndependentUpdate                       = GetBool(new IntPtr(p + 0x024)); // 0x24 IsIndependentUpdate         ( ModelPrimitiveType bool bool bool Bool )
            value.OnStart                                   = GetObject<TweenCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x28 OnStart                     ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnPlay                                    = GetObject<TweenCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x30 OnPlay                      ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnRewind                                  = GetObject<TweenCallback>(new IntPtr(p + 0x038), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x38 OnRewind                    ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnUpdate                                  = GetObject<TweenCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x40 OnUpdate                    ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnStepComplete                            = GetObject<TweenCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x48 OnStepComplete              ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnComplete                                = GetObject<TweenCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x50 OnComplete                  ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnKill                                    = GetObject<TweenCallback>(new IntPtr(p + 0x058), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x58 OnKill                      ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.IsRecyclable                              = GetBool(new IntPtr(p + 0x068)); // 0x68 IsRecyclable                ( ModelPrimitiveType bool bool bool Bool )
            value.IsSpeedBased                              = GetBool(new IntPtr(p + 0x069)); // 0x69 IsSpeedBased                ( ModelPrimitiveType bool bool bool Bool )
            value.AutoKill                                  = GetBool(new IntPtr(p + 0x06A)); // 0x6A AutoKill                    ( ModelPrimitiveType bool bool bool Bool )
            value.Loops                                     = GetInt32(new IntPtr(p + 0x06C)); // 0x6C Loops                       ( ModelPrimitiveType int int int Int32 )
            value.LoopType                                  = (LoopType)GetInt32(new IntPtr(p + 0x070)); // 0x70 LoopType                    ( ModelEnumType LoopType LoopType LoopType Int32 )
            value.Delay                                     = GetSingle(new IntPtr(p + 0x074)); // 0x74 Delay                       ( ModelPrimitiveType float float float Single )
            value.IsRelative                                = GetBool(new IntPtr(p + 0x078)); // 0x78 IsRelative                  ( ModelPrimitiveType bool bool bool Bool )
            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x07C)); // 0x7C EaseType                    ( ModelEnumType Ease Ease Ease Int32 )
            value.CustomEase                                = GetObject<EaseFunction>(new IntPtr(p + 0x080), ReversePrism.DataModels.EaseFunction.FromPointer); // 0x80 CustomEase                  ( ModelClassType EaseFunction EaseFunction EaseFunction Pointer )
            value.EaseOvershootOrAmplitude                  = GetSingle(new IntPtr(p + 0x088)); // 0x88 EaseOvershootOrAmplitude    ( ModelPrimitiveType float float float Single )
            value.EasePeriod                                = GetSingle(new IntPtr(p + 0x08C)); // 0x8C EasePeriod                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
