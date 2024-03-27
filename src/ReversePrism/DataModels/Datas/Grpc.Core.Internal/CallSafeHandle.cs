using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NullInstance                             CallSafeHandle IL2CPP_TYPE_CLASS
    // 008 Native                                   NativeMethods IL2CPP_TYPE_CLASS
    // 010 CompletionHandler_IUnaryResponseClientCallback 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 018 CompletionHandler_IReceivedStatusOnClientCallback 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 020 CompletionHandler_IReceivedMessageCallback 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 028 CompletionHandler_IReceivedResponseHeadersCallback 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 030 CompletionHandler_ISendCompletionCallback 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 038 CompletionHandler_ISendStatusFromServerCompletionCallback 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 040 CompletionHandler_IReceivedCloseOnServerCallback 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer
    // 000 GRPC_WRITE_BUFFER_HINT                   uint IL2CPP_TYPE_U4
    // 020 CompletionQueue                          0001865F12D0 ModelClassType CompletionQueueSafeHandle CompletionQueueSafeHandle CompletionQueueSafeHandle Pointer
    public partial class CallSafeHandle
    {
        public BatchCompletionDelegate?                 CompletionHandler_IUnaryResponseClientCallback { get; set; }
        public BatchCompletionDelegate?                 CompletionHandler_IReceivedStatusOnClientCallback { get; set; }
        public BatchCompletionDelegate?                 CompletionHandler_IReceivedMessageCallback { get; set; }
        public BatchCompletionDelegate?                 CompletionHandler_IReceivedResponseHeadersCallback { get; set; }
        public BatchCompletionDelegate?                 CompletionHandler_ISendCompletionCallback { get; set; }
        public BatchCompletionDelegate?                 CompletionHandler_ISendStatusFromServerCompletionCallback { get; set; }
        public BatchCompletionDelegate?                 CompletionHandler_IReceivedCloseOnServerCallback { get; set; }
        public CompletionQueueSafeHandle?               CompletionQueue                         { get; set; }

        public static CallSafeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallSafeHandle();

            value.CompletionHandler_IUnaryResponseClientCallback = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 0270D303E108 0x10 CompletionHandler_IUnaryResponseClientCallback ( 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )
            value.CompletionHandler_IReceivedStatusOnClientCallback = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 0270D303E128 0x18 CompletionHandler_IReceivedStatusOnClientCallback ( 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )
            value.CompletionHandler_IReceivedMessageCallback = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 0270D303E148 0x20 CompletionHandler_IReceivedMessageCallback ( 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )
            value.CompletionHandler_IReceivedResponseHeadersCallback = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 0270D303E168 0x28 CompletionHandler_IReceivedResponseHeadersCallback ( 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )
            value.CompletionHandler_ISendCompletionCallback = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 0270D303E188 0x30 CompletionHandler_ISendCompletionCallback ( 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )
            value.CompletionHandler_ISendStatusFromServerCompletionCallback = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x038), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 0270D303E1A8 0x38 CompletionHandler_ISendStatusFromServerCompletionCallback ( 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )
            value.CompletionHandler_IReceivedCloseOnServerCallback = GetObject<BatchCompletionDelegate>(new IntPtr(p + 0x040), ReversePrism.DataModels.BatchCompletionDelegate.FromPointer); // 0270D303E1C8 0x40 CompletionHandler_IReceivedCloseOnServerCallback ( 0001867480F0 ModelClassType BatchCompletionDelegate BatchCompletionDelegate BatchCompletionDelegate Pointer )
            value.CompletionQueue                           = GetObject<CompletionQueueSafeHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompletionQueueSafeHandle.FromPointer); // 0270D303E208 0x20 CompletionQueue             ( 0001865F12D0 ModelClassType CompletionQueueSafeHandle CompletionQueueSafeHandle CompletionQueueSafeHandle Pointer )

            return value;
        }
    }
}
