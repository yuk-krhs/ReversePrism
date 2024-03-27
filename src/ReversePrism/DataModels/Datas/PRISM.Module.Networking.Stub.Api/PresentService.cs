using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetPresentListArgs      Marshaller`1<GetPresentListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetPresentListReply     Marshaller`1<GetPresentListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetPresentHistoryListArgs Marshaller`1<GetPresentHistoryListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetPresentHistoryListReply Marshaller`1<GetPresentHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ReceivePresentArgs      Marshaller`1<ReceivePresentArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ReceivePresentReply     Marshaller`1<ReceivePresentReply> IL2CPP_TYPE_GENERICINST
    // 038 __Method_GetPresentList                  Method`2<GetPresentListArgs, GetPresentListReply> IL2CPP_TYPE_GENERICINST
    // 040 __Method_GetPresentHistoryList           Method`2<GetPresentHistoryListArgs, GetPresentHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_ReceivePresent                  Method`2<ReceivePresentArgs, ReceivePresentReply> IL2CPP_TYPE_GENERICINST
    public partial class PresentService
    {

        public static PresentService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentService();


            return value;
        }
    }
}
