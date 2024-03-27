using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    0001866C4B40 ModelEnumType OperationState OperationState OperationState Int32
    // 018 asyncState                               <object> IL2CPP_TYPE_OBJECT
    // 020 Callback                                 0001866F3DE0 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer
    // 028 Exception                                0001865CA820 ModelClassType Exception Exception Exception Pointer
    public partial class AsyncEventArgs
    {
        public OperationState                           State                                   { get; set; }
        public AsyncEventArgsCallback?                  Callback                                { get; set; }
        public Exception?                               Exception                               { get; set; }

        public static AsyncEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncEventArgs();

            value.State                                     = (OperationState)GetInt32(new IntPtr(p + 0x010)); // 0270D7C16850 0x10 State                       ( 0001866C4B40 ModelEnumType OperationState OperationState OperationState Int32 )
            value.Callback                                  = GetObject<AsyncEventArgsCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.AsyncEventArgsCallback.FromPointer); // 0270D7C16890 0x20 Callback                    ( 0001866F3DE0 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x028), ReversePrism.DataModels.Exception.FromPointer); // 0270D7C168B0 0x28 Exception                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
