using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<TweenConfiguredSource> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 0001866ED680 ModelClassType TweenConfiguredSource TweenConfiguredSource TweenConfiguredSource Pointer
    // 018 OnCompleteCallbackDelegate               0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 020 OnUpdateDelegate                         0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 028 Tween                                    0001866BEFF0 ModelClassType Tween Tween Tween Pointer
    // 030 CancelBehaviour                          0001866C11C0 ModelEnumType TweenCancelBehaviour TweenCancelBehaviour TweenCancelBehaviour Int32
    // 038 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 040 CallbackType                             00018656C410 ModelEnumType CallbackType CallbackType CallbackType Int32
    // 044 Canceled                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 OriginalUpdateAction                     0001866C0320 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 050 OriginalCompleteAction                   0001866C0320 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 058 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class TweenConfiguredSource
    {
        public TweenConfiguredSource?                   NextNode                                { get; set; }
        public TweenCallback?                           OnCompleteCallbackDelegate              { get; set; }
        public TweenCallback?                           OnUpdateDelegate                        { get; set; }
        public Tween?                                   Tween                                   { get; set; }
        public TweenCancelBehaviour                     CancelBehaviour                         { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CallbackType                             CallbackType                            { get; set; }
        public bool                                     Canceled                                { get; set; }
        public TweenCallback?                           OriginalUpdateAction                    { get; set; }
        public TweenCallback?                           OriginalCompleteAction                  { get; set; }

        public static TweenConfiguredSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenConfiguredSource();

            value.NextNode                                  = GetObject<TweenConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.TweenConfiguredSource.FromPointer); // 02700436C180 0x10 NextNode                    ( 0001866ED680 ModelClassType TweenConfiguredSource TweenConfiguredSource TweenConfiguredSource Pointer )
            value.OnCompleteCallbackDelegate                = GetObject<TweenCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.TweenCallback.FromPointer); // 02700436C1A0 0x18 OnCompleteCallbackDelegate  ( 0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnUpdateDelegate                          = GetObject<TweenCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.TweenCallback.FromPointer); // 02700436C1C0 0x20 OnUpdateDelegate            ( 0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x028), ReversePrism.DataModels.Tween.FromPointer); // 02700436C1E0 0x28 Tween                       ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )
            value.CancelBehaviour                           = (TweenCancelBehaviour)GetInt32(new IntPtr(p + 0x030)); // 02700436C200 0x30 CancelBehaviour             ( 0001866C11C0 ModelEnumType TweenCancelBehaviour TweenCancelBehaviour TweenCancelBehaviour Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x038)); // 02700436C220 0x38 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CallbackType                              = (CallbackType)GetInt32(new IntPtr(p + 0x040)); // 02700436C240 0x40 CallbackType                ( 00018656C410 ModelEnumType CallbackType CallbackType CallbackType Int32 )
            value.Canceled                                  = GetBool(new IntPtr(p + 0x044)); // 02700436C260 0x44 Canceled                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OriginalUpdateAction                      = GetObject<TweenCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.TweenCallback.FromPointer); // 02700436C280 0x48 OriginalUpdateAction        ( 0001866C0320 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OriginalCompleteAction                    = GetObject<TweenCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.TweenCallback.FromPointer); // 02700436C2A0 0x50 OriginalCompleteAction      ( 0001866C0320 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )

            return value;
        }
    }
}
