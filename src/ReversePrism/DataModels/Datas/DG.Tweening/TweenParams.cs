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
    // 020 UpdateType                               0001867420B0 ModelEnumType UpdateType UpdateType UpdateType Int32
    // 024 IsIndependentUpdate                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 028 OnStart                                  0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 030 OnPlay                                   0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 038 OnRewind                                 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 040 OnUpdate                                 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 048 OnStepComplete                           0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 050 OnComplete                               0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 058 OnKill                                   0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 060 onWaypointChange                         TweenCallback`1<int> IL2CPP_TYPE_GENERICINST
    // 068 IsRecyclable                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 069 IsSpeedBased                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 06A AutoKill                                 000186595210 ModelPrimitiveType bool bool bool Bool
    // 06C Loops                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 070 LoopType                                 0001865C09A0 ModelEnumType LoopType LoopType LoopType Int32
    // 074 Delay                                    000186665900 ModelPrimitiveType float float float Single
    // 078 IsRelative                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 07C EaseType                                 000186716EE0 ModelEnumType Ease Ease Ease Int32
    // 080 CustomEase                               000186718C70 ModelClassType EaseFunction EaseFunction EaseFunction Pointer
    // 088 EaseOvershootOrAmplitude                 000186665900 ModelPrimitiveType float float float Single
    // 08C EasePeriod                               000186665900 ModelPrimitiveType float float float Single
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

            value.UpdateType                                = (UpdateType)GetInt32(new IntPtr(p + 0x020)); // 02466B0FD9C0 0x20 UpdateType                  ( 0001867420B0 ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.IsIndependentUpdate                       = GetBool(new IntPtr(p + 0x024)); // 02466B0FD9E0 0x24 IsIndependentUpdate         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.OnStart                                   = GetObject<TweenCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.TweenCallback.FromPointer); // 02466B0FDA00 0x28 OnStart                     ( 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnPlay                                    = GetObject<TweenCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.TweenCallback.FromPointer); // 02466B0FDA20 0x30 OnPlay                      ( 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnRewind                                  = GetObject<TweenCallback>(new IntPtr(p + 0x038), ReversePrism.DataModels.TweenCallback.FromPointer); // 02466B0FDA40 0x38 OnRewind                    ( 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnUpdate                                  = GetObject<TweenCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.TweenCallback.FromPointer); // 02466B0FDA60 0x40 OnUpdate                    ( 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnStepComplete                            = GetObject<TweenCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.TweenCallback.FromPointer); // 02466B0FDA80 0x48 OnStepComplete              ( 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnComplete                                = GetObject<TweenCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.TweenCallback.FromPointer); // 02466B0FDAA0 0x50 OnComplete                  ( 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnKill                                    = GetObject<TweenCallback>(new IntPtr(p + 0x058), ReversePrism.DataModels.TweenCallback.FromPointer); // 02466B0FDAC0 0x58 OnKill                      ( 0001866C0590 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.IsRecyclable                              = GetBool(new IntPtr(p + 0x068)); // 02466B0FDB00 0x68 IsRecyclable                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsSpeedBased                              = GetBool(new IntPtr(p + 0x069)); // 02466B0FDB20 0x69 IsSpeedBased                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.AutoKill                                  = GetBool(new IntPtr(p + 0x06A)); // 02466B0FDB40 0x6A AutoKill                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Loops                                     = GetInt32(new IntPtr(p + 0x06C)); // 02466B0FDB60 0x6C Loops                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.LoopType                                  = (LoopType)GetInt32(new IntPtr(p + 0x070)); // 02466B0FDB80 0x70 LoopType                    ( 0001865C09A0 ModelEnumType LoopType LoopType LoopType Int32 )
            value.Delay                                     = GetSingle(new IntPtr(p + 0x074)); // 02466B0FDBA0 0x74 Delay                       ( 000186665900 ModelPrimitiveType float float float Single )
            value.IsRelative                                = GetBool(new IntPtr(p + 0x078)); // 02466B0FDBC0 0x78 IsRelative                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x07C)); // 02466B0FDBE0 0x7C EaseType                    ( 000186716EE0 ModelEnumType Ease Ease Ease Int32 )
            value.CustomEase                                = GetObject<EaseFunction>(new IntPtr(p + 0x080), ReversePrism.DataModels.EaseFunction.FromPointer); // 02466B0FDC00 0x80 CustomEase                  ( 000186718C70 ModelClassType EaseFunction EaseFunction EaseFunction Pointer )
            value.EaseOvershootOrAmplitude                  = GetSingle(new IntPtr(p + 0x088)); // 02466B0FDC20 0x88 EaseOvershootOrAmplitude    ( 000186665900 ModelPrimitiveType float float float Single )
            value.EasePeriod                                = GetSingle(new IntPtr(p + 0x08C)); // 02466B0FDC40 0x8C EasePeriod                  ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
