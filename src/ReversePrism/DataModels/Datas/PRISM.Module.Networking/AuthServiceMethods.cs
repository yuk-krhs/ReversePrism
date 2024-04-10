using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Register                                 Method`2<IRegisterArgs, IRegisterReply> IL2CPP_TYPE_GENERICINST
    // 018 Login                                    Method`2<ILoginArgs, ILoginReply> IL2CPP_TYPE_GENERICINST
    // 030 GetTransferURL                           Method`2<IGetTransferURLArgs, IGetTransferURLReply> IL2CPP_TYPE_GENERICINST
    // 048 ConfirmTransfer                          Method`2<IConfirmTransferArgs, IConfirmTransferReply> IL2CPP_TYPE_GENERICINST
    // 060 ExecuteTransfer                          Method`2<IExecuteTransferArgs, IExecuteTransferReply> IL2CPP_TYPE_GENERICINST
    // 078 GetConnectURLAndToken                    Method`2<IGetConnectURLAndTokenArgs, IGetConnectURLAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 090 ExecuteConnectProviderAndToken           Method`2<IExecuteConnectProviderAndTokenArgs, IExecuteConnectProviderAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 0A8 ConnectReleaseOtherAndToken              Method`2<IConnectReleaseOtherAndTokenArgs, IConnectReleaseOtherAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 0C0 ConnectReleaseAndToken                   Method`2<IConnectReleaseAndTokenArgs, IConnectReleaseAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 0D8 GetTransferEnable                        Method`2<IGetTransferEnableArgs, IGetTransferEnableReply> IL2CPP_TYPE_GENERICINST
    // 0F0 GetServerEnable                          Method`2<IGetServerEnableArgs, IGetServerEnableReply> IL2CPP_TYPE_GENERICINST
    // 108 VerifyConnectTokenAndUser                Method`2<IVerifyConnectTokenAndUserArgs, IVerifyConnectTokenAndUserReply> IL2CPP_TYPE_GENERICINST
    // 120 VerifyTransferToken                      Method`2<IVerifyTransferTokenArgs, IVerifyTransferTokenReply> IL2CPP_TYPE_GENERICINST
    // 138 GetUserForDmmGames                       Method`2<IGetUserForDmmGamesArgs, IGetUserForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 150 UnlinkForDmmGames                        Method`2<IUnlinkForDmmGamesArgs, IUnlinkForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 168 GetTransferState                         Method`2<IGetTransferStateArgs, IGetTransferStateReply> IL2CPP_TYPE_GENERICINST
    public partial class AuthServiceMethods : DataModel
    {

        public static AuthServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
