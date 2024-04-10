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
    public partial class TweenConfiguredSource : DataModel
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
            var value   = new TweenConfiguredSource() { Pointer= p0 };

            value.NextNode                                  = GetObject<TweenConfiguredSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.TweenConfiguredSource.FromPointer); // 0245A43CC3C8 0x10 NextNode                    ( 0001866ED680 ModelClassType TweenConfiguredSource TweenConfiguredSource TweenConfiguredSource Pointer )
            value.OnCompleteCallbackDelegate                = GetObject<TweenCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43CC3E8 0x18 OnCompleteCallbackDelegate  ( 0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OnUpdateDelegate                          = GetObject<TweenCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43CC408 0x20 OnUpdateDelegate            ( 0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x028), ReversePrism.DataModels.Tween.FromPointer); // 0245A43CC428 0x28 Tween                       ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )
            value.CancelBehaviour                           = (TweenCancelBehaviour)GetInt32(new IntPtr(p + 0x030)); // 0245A43CC448 0x30 CancelBehaviour             ( 0001866C11C0 ModelEnumType TweenCancelBehaviour TweenCancelBehaviour TweenCancelBehaviour Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x038)); // 0245A43CC468 0x38 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CallbackType                              = (CallbackType)GetInt32(new IntPtr(p + 0x040)); // 0245A43CC488 0x40 CallbackType                ( 00018656C410 ModelEnumType CallbackType CallbackType CallbackType Int32 )
            value.Canceled                                  = GetBool(new IntPtr(p + 0x044)); // 0245A43CC4A8 0x44 Canceled                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OriginalUpdateAction                      = GetObject<TweenCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43CC4C8 0x48 OriginalUpdateAction        ( 0001866C0320 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.OriginalCompleteAction                    = GetObject<TweenCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.TweenCallback.FromPointer); // 0245A43CC4E8 0x50 OriginalCompleteAction      ( 0001866C0320 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )

            return value;
        }
    }
}
