using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TaskAccept                               TaskSocketAsyncEventArgs`1<Socket> IL2CPP_TYPE_GENERICINST
    // 018 TaskReceive                              000186544CC0 ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer
    // 020 TaskSend                                 000186544CC0 ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer
    // 028 ValueTaskReceive                         000186543FC0 ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer
    // 030 ValueTaskSend                            000186543FC0 ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer
    public partial class CachedEventArgs
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
            var value   = new CachedEventArgs();

            value.TaskReceive                               = GetObject<Int32TaskSocketAsyncEventArgs>(new IntPtr(p + 0x018), ReversePrism.DataModels.Int32TaskSocketAsyncEventArgs.FromPointer); // 0270D7AE45D0 0x18 TaskReceive                 ( 000186544CC0 ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer )
            value.TaskSend                                  = GetObject<Int32TaskSocketAsyncEventArgs>(new IntPtr(p + 0x020), ReversePrism.DataModels.Int32TaskSocketAsyncEventArgs.FromPointer); // 0270D7AE45F0 0x20 TaskSend                    ( 000186544CC0 ModelClassType Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Int32TaskSocketAsyncEventArgs Pointer )
            value.ValueTaskReceive                          = GetObject<AwaitableSocketAsyncEventArgs>(new IntPtr(p + 0x028), ReversePrism.DataModels.AwaitableSocketAsyncEventArgs.FromPointer); // 0270D7AE4610 0x28 ValueTaskReceive            ( 000186543FC0 ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer )
            value.ValueTaskSend                             = GetObject<AwaitableSocketAsyncEventArgs>(new IntPtr(p + 0x030), ReversePrism.DataModels.AwaitableSocketAsyncEventArgs.FromPointer); // 0270D7AE4630 0x30 ValueTaskSend               ( 000186543FC0 ModelClassType AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs AwaitableSocketAsyncEventArgs Pointer )

            return value;
        }
    }
}
