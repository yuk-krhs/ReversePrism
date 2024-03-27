using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetConnectURLArgs       Marshaller`1<GetConnectURLArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetConnectURLReply      Marshaller`1<GetConnectURLReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_ConnectReleaseArgs      Marshaller`1<ConnectReleaseArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_ConnectReleaseReply     Marshaller`1<ConnectReleaseReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ConnectReleaseOtherArgs Marshaller`1<ConnectReleaseOtherArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ConnectReleaseOtherReply Marshaller`1<ConnectReleaseOtherReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_ExecuteConnectProviderArgs Marshaller`1<ExecuteConnectProviderArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_ExecuteConnectProviderReply Marshaller`1<ExecuteConnectProviderReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_VerifyConnectTokenArgs  Marshaller`1<VerifyConnectTokenArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_VerifyConnectTokenReply Marshaller`1<VerifyConnectTokenReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetConnectURL                   Method`2<GetConnectURLArgs, GetConnectURLReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_ConnectRelease                  Method`2<ConnectReleaseArgs, ConnectReleaseReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_ConnectReleaseOther             Method`2<ConnectReleaseOtherArgs, ConnectReleaseOtherReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_ExecuteConnectProvider          Method`2<ExecuteConnectProviderArgs, ExecuteConnectProviderReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_VerifyConnectToken              Method`2<VerifyConnectTokenArgs, VerifyConnectTokenReply> IL2CPP_TYPE_GENERICINST
    public partial class TransferService
    {

        public static TransferService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferService();


            return value;
        }
    }
}
