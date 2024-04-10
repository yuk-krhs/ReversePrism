using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_TmpGetHomeArgs          Marshaller`1<TmpGetHomeArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_TmpGetHomeReply         Marshaller`1<TmpGetHomeReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_AccessHomeArgs          Marshaller`1<AccessHomeArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_AccessHomeReply         Marshaller`1<AccessHomeReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_SetHomeSettingArgs      Marshaller`1<SetHomeSettingArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_SetHomeSettingReply     Marshaller`1<SetHomeSettingReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetHomeNotificationListArgs Marshaller`1<GetHomeNotificationListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetHomeNotificationListReply Marshaller`1<GetHomeNotificationListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetSuspendedLiveArgs    Marshaller`1<GetSuspendedLiveArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetSuspendedLiveReply   Marshaller`1<GetSuspendedLiveReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetSuspendedPvpArgs     Marshaller`1<GetSuspendedPvpArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetSuspendedPvpReply    Marshaller`1<GetSuspendedPvpReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_TmpGetHome                      Method`2<TmpGetHomeArgs, TmpGetHomeReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_AccessHome                      Method`2<AccessHomeArgs, AccessHomeReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_SetHomeSetting                  Method`2<SetHomeSettingArgs, SetHomeSettingReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_GetHomeNotificationList         Method`2<GetHomeNotificationListArgs, GetHomeNotificationListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_GetSuspendedLive                Method`2<GetSuspendedLiveArgs, GetSuspendedLiveReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_GetSuspendedPvp                 Method`2<GetSuspendedPvpArgs, GetSuspendedPvpReply> IL2CPP_TYPE_GENERICINST
    public partial class HomeService : DataModel
    {

        public static HomeService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeService() { Pointer= p0 };


            return value;
        }
    }
}
