using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TmpGetHome                               Method`2<ITmpGetHomeArgs, ITmpGetHomeReply> IL2CPP_TYPE_GENERICINST
    // 018 AccessHome                               Method`2<IAccessHomeArgs, IAccessHomeReply> IL2CPP_TYPE_GENERICINST
    // 030 SetHomeSetting                           Method`2<ISetHomeSettingArgs, ISetHomeSettingReply> IL2CPP_TYPE_GENERICINST
    // 048 GetHomeNotificationList                  Method`2<IGetHomeNotificationListArgs, IGetHomeNotificationListReply> IL2CPP_TYPE_GENERICINST
    // 060 GetSuspendedLive                         Method`2<IGetSuspendedLiveArgs, IGetSuspendedLiveReply> IL2CPP_TYPE_GENERICINST
    // 078 GetSuspendedPvp                          Method`2<IGetSuspendedPvpArgs, IGetSuspendedPvpReply> IL2CPP_TYPE_GENERICINST
    public partial class HomeServiceMethods : DataModel
    {

        public static HomeServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
