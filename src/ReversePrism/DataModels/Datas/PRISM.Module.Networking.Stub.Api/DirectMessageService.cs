using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetDirectMessageListArgs Marshaller`1<GetDirectMessageListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetDirectMessageListReply Marshaller`1<GetDirectMessageListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_ReadDirectMessageArgs   Marshaller`1<ReadDirectMessageArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_ReadDirectMessageReply  Marshaller`1<ReadDirectMessageReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_GetDirectMessageList            Method`2<GetDirectMessageListArgs, GetDirectMessageListReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_ReadDirectMessage               Method`2<ReadDirectMessageArgs, ReadDirectMessageReply> IL2CPP_TYPE_GENERICINST
    public partial class DirectMessageService : DataModel
    {

        public static DirectMessageService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageService() { Pointer= p0 };


            return value;
        }
    }
}
