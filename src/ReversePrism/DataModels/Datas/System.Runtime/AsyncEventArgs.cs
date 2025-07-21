using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    ModelEnumType OperationState OperationState OperationState Int32
    // 018 asyncState                               <object> IL2CPP_TYPE_OBJECT
    // 020 Callback                                 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer
    // 028 Exception                                ModelClassType Exception Exception Exception Pointer
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

            value.State                                     = (OperationState)GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelEnumType OperationState OperationState OperationState Int32 )
            value.Callback                                  = GetObject<AsyncEventArgsCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.AsyncEventArgsCallback.FromPointer); // 0x20 Callback                    ( ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x028), ReversePrism.DataModels.Exception.FromPointer); // 0x28 Exception                   ( ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
