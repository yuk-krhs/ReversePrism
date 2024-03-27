using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetConnectURL                            Method`2<IGetConnectURLArgs, IGetConnectURLReply> IL2CPP_TYPE_GENERICINST
    // 018 ConnectRelease                           Method`2<IConnectReleaseArgs, IConnectReleaseReply> IL2CPP_TYPE_GENERICINST
    // 030 ConnectReleaseOther                      Method`2<IConnectReleaseOtherArgs, IConnectReleaseOtherReply> IL2CPP_TYPE_GENERICINST
    // 048 ExecuteConnectProvider                   Method`2<IExecuteConnectProviderArgs, IExecuteConnectProviderReply> IL2CPP_TYPE_GENERICINST
    // 060 VerifyConnectToken                       Method`2<IVerifyConnectTokenArgs, IVerifyConnectTokenReply> IL2CPP_TYPE_GENERICINST
    public partial class TransferServiceMethods
    {

        public static TransferServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferServiceMethods();


            return value;
        }
    }
}
