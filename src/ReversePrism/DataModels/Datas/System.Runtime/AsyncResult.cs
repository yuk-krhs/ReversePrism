using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 asyncCompletionWrapperCallback           AsyncCallback IL2CPP_TYPE_CLASS
    // 010 Callback                                 0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 018 CompletedSynchronously                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 EndCalled                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 Exception                                0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 028 IsCompleted                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 NextAsyncCompletion                      0001866CE8A0 ModelClassType AsyncCompletion AsyncCompletion AsyncCompletion Pointer
    // 038 state                                    <object> IL2CPP_TYPE_OBJECT
    // 040 BeforePrepareAsyncCompletionAction       0001866792B0 ModelClassType Action Action Action Pointer
    // 048 checkSyncValidationFunc                  Func`2<IAsyncResult, bool> IL2CPP_TYPE_GENERICINST
    // 050 ManualResetEvent                         00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 058 thisLock                                 <object> IL2CPP_TYPE_OBJECT
    // 060 <OnCompleting>k__BackingField            Action`2<AsyncResult, Exception> IL2CPP_TYPE_GENERICINST
    // 068 <VirtualCallback>k__BackingField         Action`2<AsyncCallback, IAsyncResult> IL2CPP_TYPE_GENERICINST
    public partial class AsyncResult
    {
        public AsyncCallback?                           Callback                                { get; set; }
        public bool                                     CompletedSynchronously                  { get; set; }
        public bool                                     EndCalled                               { get; set; }
        public Exception?                               Exception                               { get; set; }
        public bool                                     IsCompleted                             { get; set; }
        public AsyncCompletion?                         NextAsyncCompletion                     { get; set; }
        public Action?                                  BeforePrepareAsyncCompletionAction      { get; set; }
        public ManualResetEvent?                        ManualResetEvent                        { get; set; }

        public static AsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncResult();

            value.Callback                                  = GetObject<AsyncCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0270D7C0FBA0 0x10 Callback                    ( 0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.CompletedSynchronously                    = GetBool(new IntPtr(p + 0x018)); // 0270D7C0FBC0 0x18 CompletedSynchronously      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EndCalled                                 = GetBool(new IntPtr(p + 0x019)); // 0270D7C0FBE0 0x19 EndCalled                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x020), ReversePrism.DataModels.Exception.FromPointer); // 0270D7C0FC00 0x20 Exception                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.IsCompleted                               = GetBool(new IntPtr(p + 0x028)); // 0270D7C0FC20 0x28 IsCompleted                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NextAsyncCompletion                       = GetObject<AsyncCompletion>(new IntPtr(p + 0x030), ReversePrism.DataModels.AsyncCompletion.FromPointer); // 0270D7C0FC40 0x30 NextAsyncCompletion         ( 0001866CE8A0 ModelClassType AsyncCompletion AsyncCompletion AsyncCompletion Pointer )
            value.BeforePrepareAsyncCompletionAction        = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0270D7C0FC80 0x40 BeforePrepareAsyncCompletionAction ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.ManualResetEvent                          = GetObject<ManualResetEvent>(new IntPtr(p + 0x050), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0270D7C0FCC0 0x50 ManualResetEvent            ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )

            return value;
        }
    }
}
