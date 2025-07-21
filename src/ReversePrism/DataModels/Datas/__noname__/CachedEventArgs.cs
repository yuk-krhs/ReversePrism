using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TaskAccept                               TaskSocketAsyncEventArgs`1<Socket> IL2CPP_TYPE_GENERICINST
    // 018 TaskReceive                              ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer
    // 020 TaskSend                                 ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer
    // 028 ValueTaskReceive                         ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer
    // 030 ValueTaskSend                            ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer
    public partial class CachedEventArgs : DataModel
    {
        public Int32TaskSocketAsyncEventArgs?           TaskReceive                             { get; set; }
        public Int32TaskSocketAsyncEventArgs?           TaskSend                                { get; set; }
        public AwaitableSocketAsyncEventArgs?           ValueTaskReceive                        { get; set; }
        public AwaitableSocketAsyncEventArgs?           ValueTaskSend                           { get; set; }

        public static CachedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedEventArgs() { Pointer= p0 };

            value.TaskReceive                               = GetObject<Int32TaskSocketAsyncEventArgs>(new IntPtr(p + 0x018), ReversePrism.DataModels.Int32TaskSocketAsyncEventArgs.FromPointer); // 0x18 TaskReceive                 ( ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer )
            value.TaskSend                                  = GetObject<Int32TaskSocketAsyncEventArgs>(new IntPtr(p + 0x020), ReversePrism.DataModels.Int32TaskSocketAsyncEventArgs.FromPointer); // 0x20 TaskSend                    ( ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer )
            value.ValueTaskReceive                          = GetObject<AwaitableSocketAsyncEventArgs>(new IntPtr(p + 0x028), ReversePrism.DataModels.AwaitableSocketAsyncEventArgs.FromPointer); // 0x28 ValueTaskReceive            ( ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer )
            value.ValueTaskSend                             = GetObject<AwaitableSocketAsyncEventArgs>(new IntPtr(p + 0x030), ReversePrism.DataModels.AwaitableSocketAsyncEventArgs.FromPointer); // 0x30 ValueTaskSend               ( ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer )

            return value;
        }
    }
}
