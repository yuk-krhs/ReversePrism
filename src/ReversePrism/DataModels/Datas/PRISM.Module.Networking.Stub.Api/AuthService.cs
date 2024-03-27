using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_RegisterArgs            Marshaller`1<RegisterArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_RegisterReply           Marshaller`1<RegisterReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_LoginArgs               Marshaller`1<LoginArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_LoginReply              Marshaller`1<LoginReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetTransferURLArgs      Marshaller`1<GetTransferURLArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetTransferURLReply     Marshaller`1<GetTransferURLReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_ConfirmTransferArgs     Marshaller`1<ConfirmTransferArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_ConfirmTransferReply    Marshaller`1<ConfirmTransferReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_ExecuteTransferArgs     Marshaller`1<ExecuteTransferArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_ExecuteTransferReply    Marshaller`1<ExecuteTransferReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetConnectURLAndTokenArgs Marshaller`1<GetConnectURLAndTokenArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetConnectURLAndTokenReply Marshaller`1<GetConnectURLAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_ExecuteConnectProviderAndTokenArgs Marshaller`1<ExecuteConnectProviderAndTokenArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_ExecuteConnectProviderAndTokenReply Marshaller`1<ExecuteConnectProviderAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_ConnectReleaseOtherAndTokenArgs Marshaller`1<ConnectReleaseOtherAndTokenArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_ConnectReleaseOtherAndTokenReply Marshaller`1<ConnectReleaseOtherAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 088 __Marshaller_api_ConnectReleaseAndTokenArgs Marshaller`1<ConnectReleaseAndTokenArgs> IL2CPP_TYPE_GENERICINST
    // 090 __Marshaller_api_ConnectReleaseAndTokenReply Marshaller`1<ConnectReleaseAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 098 __Marshaller_api_GetTransferEnableArgs   Marshaller`1<GetTransferEnableArgs> IL2CPP_TYPE_GENERICINST
    // 0A0 __Marshaller_api_GetTransferEnableReply  Marshaller`1<GetTransferEnableReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Marshaller_api_GetServerEnableArgs     Marshaller`1<GetServerEnableArgs> IL2CPP_TYPE_GENERICINST
    // 0B0 __Marshaller_api_GetServerEnableReply    Marshaller`1<GetServerEnableReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Marshaller_api_VerifyConnectTokenAndUserArgs Marshaller`1<VerifyConnectTokenAndUserArgs> IL2CPP_TYPE_GENERICINST
    // 0C0 __Marshaller_api_VerifyConnectTokenAndUserReply Marshaller`1<VerifyConnectTokenAndUserReply> IL2CPP_TYPE_GENERICINST
    // 0C8 __Marshaller_api_VerifyTransferTokenArgs Marshaller`1<VerifyTransferTokenArgs> IL2CPP_TYPE_GENERICINST
    // 0D0 __Marshaller_api_VerifyTransferTokenReply Marshaller`1<VerifyTransferTokenReply> IL2CPP_TYPE_GENERICINST
    // 0D8 __Marshaller_api_GetUserForDmmGamesArgs  Marshaller`1<GetUserForDmmGamesArgs> IL2CPP_TYPE_GENERICINST
    // 0E0 __Marshaller_api_GetUserForDmmGamesReply Marshaller`1<GetUserForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 0E8 __Marshaller_api_UnlinkForDmmGamesArgs   Marshaller`1<UnlinkForDmmGamesArgs> IL2CPP_TYPE_GENERICINST
    // 0F0 __Marshaller_api_UnlinkForDmmGamesReply  Marshaller`1<UnlinkForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 0F8 __Marshaller_api_GetTransferStateArgs    Marshaller`1<GetTransferStateArgs> IL2CPP_TYPE_GENERICINST
    // 100 __Marshaller_api_GetTransferStateReply   Marshaller`1<GetTransferStateReply> IL2CPP_TYPE_GENERICINST
    // 108 __Method_Register                        Method`2<RegisterArgs, RegisterReply> IL2CPP_TYPE_GENERICINST
    // 110 __Method_Login                           Method`2<LoginArgs, LoginReply> IL2CPP_TYPE_GENERICINST
    // 118 __Method_GetTransferURL                  Method`2<GetTransferURLArgs, GetTransferURLReply> IL2CPP_TYPE_GENERICINST
    // 120 __Method_ConfirmTransfer                 Method`2<ConfirmTransferArgs, ConfirmTransferReply> IL2CPP_TYPE_GENERICINST
    // 128 __Method_ExecuteTransfer                 Method`2<ExecuteTransferArgs, ExecuteTransferReply> IL2CPP_TYPE_GENERICINST
    // 130 __Method_GetConnectURLAndToken           Method`2<GetConnectURLAndTokenArgs, GetConnectURLAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 138 __Method_ExecuteConnectProviderAndToken  Method`2<ExecuteConnectProviderAndTokenArgs, ExecuteConnectProviderAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 140 __Method_ConnectReleaseOtherAndToken     Method`2<ConnectReleaseOtherAndTokenArgs, ConnectReleaseOtherAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 148 __Method_ConnectReleaseAndToken          Method`2<ConnectReleaseAndTokenArgs, ConnectReleaseAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 150 __Method_GetTransferEnable               Method`2<GetTransferEnableArgs, GetTransferEnableReply> IL2CPP_TYPE_GENERICINST
    // 158 __Method_GetServerEnable                 Method`2<GetServerEnableArgs, GetServerEnableReply> IL2CPP_TYPE_GENERICINST
    // 160 __Method_VerifyConnectTokenAndUser       Method`2<VerifyConnectTokenAndUserArgs, VerifyConnectTokenAndUserReply> IL2CPP_TYPE_GENERICINST
    // 168 __Method_VerifyTransferToken             Method`2<VerifyTransferTokenArgs, VerifyTransferTokenReply> IL2CPP_TYPE_GENERICINST
    // 170 __Method_GetUserForDmmGames              Method`2<GetUserForDmmGamesArgs, GetUserForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 178 __Method_UnlinkForDmmGames               Method`2<UnlinkForDmmGamesArgs, UnlinkForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 180 __Method_GetTransferState                Method`2<GetTransferStateArgs, GetTransferStateReply> IL2CPP_TYPE_GENERICINST
    public partial class AuthService
    {

        public static AuthService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthService();


            return value;
        }
    }
}
