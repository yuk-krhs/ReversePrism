using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_canceledSource                         CancellationTokenSource IL2CPP_TYPE_CLASS
    // 008 s_neverCanceledSource                    CancellationTokenSource IL2CPP_TYPE_CLASS
    // 010 S_nLists                                 ModelPrimitiveType int int int Int32
    // 010 KernelEvent                              ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 018 _registeredCallbacksLists                SparselyPopulatedArray`1<CancellationCallbackInfo>[] IL2CPP_TYPE_SZARRAY
    // 000 CannotBeCanceled                         int IL2CPP_TYPE_I4
    // 000 NotCanceledState                         int IL2CPP_TYPE_I4
    // 000 NotifyingState                           int IL2CPP_TYPE_I4
    // 000 NotifyingCompleteState                   int IL2CPP_TYPE_I4
    // 020 State                                    ModelPrimitiveType int int int Int32
    // 024 ThreadIDExecutingCallbacks               ModelPrimitiveType int int int Int32
    // 028 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 030 ExecutingCallback                        ModelClassType CancellationCallbackInfo CancellationCallbackInfo CancellationCallbackInfo Pointer
    // 038 Timer                                    ModelClassType Timer Timer Timer Pointer
    // 018 S_timerCallback                          ModelClassType TimerCallback TimerCallback TimerCallback Pointer
    public partial class CancellationTokenSource : DataModel
    {
        public int                                      S_nLists                                { get; set; }
        public ManualResetEvent?                        KernelEvent                             { get; set; }
        public int                                      State                                   { get; set; }
        public int                                      ThreadIDExecutingCallbacks              { get; set; }
        public bool                                     Disposed                                { get; set; }
        public CancellationCallbackInfo?                ExecutingCallback                       { get; set; }
        public Timer?                                   Timer                                   { get; set; }
        public TimerCallback?                           S_timerCallback                         { get; set; }

        public static CancellationTokenSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancellationTokenSource() { Pointer= p0 };

            value.S_nLists                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 S_nLists                    ( ModelPrimitiveType int int int Int32 )
            value.KernelEvent                               = GetObject<ManualResetEvent>(new IntPtr(p + 0x010), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0x10 KernelEvent                 ( ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.State                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 State                       ( ModelPrimitiveType int int int Int32 )
            value.ThreadIDExecutingCallbacks                = GetInt32(new IntPtr(p + 0x024)); // 0x24 ThreadIDExecutingCallbacks  ( ModelPrimitiveType int int int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.ExecutingCallback                         = GetObject<CancellationCallbackInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationCallbackInfo.FromPointer); // 0x30 ExecutingCallback           ( ModelClassType CancellationCallbackInfo CancellationCallbackInfo CancellationCallbackInfo Pointer )
            value.Timer                                     = GetObject<Timer>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timer.FromPointer); // 0x38 Timer                       ( ModelClassType Timer Timer Timer Pointer )
            value.S_timerCallback                           = GetObject<TimerCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimerCallback.FromPointer); // 0x18 S_timerCallback             ( ModelClassType TimerCallback TimerCallback TimerCallback Pointer )

            return value;
        }
    }
}
