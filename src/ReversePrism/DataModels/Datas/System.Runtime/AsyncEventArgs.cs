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
    public partial class AsyncEventArgs : DataModel
    {
        public OperationState                           State                                   { get; set; }
        public AsyncEventArgsCallback?                  Callback                                { get; set; }
        public Exception?                               Exception                               { get; set; }

        public static AsyncEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncEventArgs() { Pointer= p0 };

            value.State                                     = (OperationState)GetInt32(new IntPtr(p + 0x010)); // 024667C6E850 0x10 State                       ( 0001866C4B40 ModelEnumType OperationState OperationState OperationState Int32 )
            value.Callback                                  = GetObject<AsyncEventArgsCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.AsyncEventArgsCallback.FromPointer); // 024667C6E890 0x20 Callback                    ( 0001866F3DE0 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x028), ReversePrism.DataModels.Exception.FromPointer); // 024667C6E8B0 0x28 Exception                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
