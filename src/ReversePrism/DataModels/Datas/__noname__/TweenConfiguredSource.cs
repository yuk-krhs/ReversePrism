using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<TweenConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType TweenConfiguredSource TweenConfiguredSource TweenConfiguredSource Pointer
    // 018 OnCompleteCallbackDelegate               ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 020 Tween                                    ModelClassType Tween Tween Tween Pointer
    // 028 CancelBehaviour                          ModelEnumType TweenCancelBehaviour TweenCancelBehaviour TweenCancelBehaviour Int32
    // 030 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 038 CancellationRegistration                 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 050 CallbackType                             ModelEnumType CallbackType CallbackType CallbackType Int32
    // 054 Canceled                                 ModelPrimitiveType bool bool bool Bool
    // 058 OriginalCompleteAction                   ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 060 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class TweenConfiguredSource : DataModel
    {
        public TweenConfiguredSource?                   NextNode                                { get; set; }
        public TweenCallback?                           OnCompleteCallbackDelegate              { get; set; }
        public Tween?                                   Tween                                   { get; set; }
        public TweenCancelBehaviour                     CancelBehaviour                         { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            CancellationRegistration                { get; set; }
        public CallbackType                             CallbackType                            { get; set; }
        public bool                                     Canceled                                { get; set; }
        public TweenCallback?                           OriginalCompleteAction                  { get; set; }

        public static TweenConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<TweenConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.TweenConfiguredSource.FromPointer); // 0x10 NextNode                    ( ModelClassType TweenConfiguredSource TweenConfiguredSource TweenConfiguredSource Pointer )
            value.OnCompleteCallbackDelegate                = GetObject<TweenCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x18 OnCompleteCallbackDelegate  ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x020), ReversePrism.DataModels.Tween.FromPointer); // 0x20 Tween                       ( ModelClassType Tween Tween Tween Pointer )
            value.CancelBehaviour                           = (TweenCancelBehaviour)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancelBehaviour             ( ModelEnumType TweenCancelBehaviour TweenCancelBehaviour TweenCancelBehaviour Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x030)); // 0x30 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CancellationRegistration                  = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x038)); // 0x38 CancellationRegistration    ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )
            value.CallbackType                              = (CallbackType)GetInt32(new IntPtr(p + 0x050)); // 0x50 CallbackType                ( ModelEnumType CallbackType CallbackType CallbackType Int32 )
            value.Canceled                                  = GetBool(new IntPtr(p + 0x054)); // 0x54 Canceled                    ( ModelPrimitiveType bool bool bool Bool )
            value.OriginalCompleteAction                    = GetObject<TweenCallback>(new IntPtr(p + 0x058), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x58 OriginalCompleteAction      ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )

            return value;
        }
    }
}
