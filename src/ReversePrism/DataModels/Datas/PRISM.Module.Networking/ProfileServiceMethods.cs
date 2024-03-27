using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetSelfProfile                           Method`2<IGetSelfProfileArgs, IGetSelfProfileReply> IL2CPP_TYPE_GENERICINST
    // 018 GetUserProfile                           Method`2<IGetUserProfileArgs, IGetUserProfileReply> IL2CPP_TYPE_GENERICINST
    // 030 SetSelfProfile                           Method`2<ISetSelfProfileArgs, ISetSelfProfileReply> IL2CPP_TYPE_GENERICINST
    // 048 GetProducerInfo                          Method`2<IGetProducerInfoArgs, IGetProducerInfoReply> IL2CPP_TYPE_GENERICINST
    // 060 GetUserProgressInfo                      Method`2<IGetUserProgressInfoArgs, IGetUserProgressInfoReply> IL2CPP_TYPE_GENERICINST
    // 078 GetProducerSeasonInfoList                Method`2<IGetProducerSeasonInfoListArgs, IGetProducerSeasonInfoListReply> IL2CPP_TYPE_GENERICINST
    // 090 GetProducerEventInfoList                 Method`2<IGetProducerEventInfoListArgs, IGetProducerEventInfoListReply> IL2CPP_TYPE_GENERICINST
    // 0A8 GetProducerEventInfo                     Method`2<IGetProducerEventInfoArgs, IGetProducerEventInfoReply> IL2CPP_TYPE_GENERICINST
    // 0C0 SetSelfProfileName                       Method`2<ISetSelfProfileNameArgs, ISetSelfProfileNameReply> IL2CPP_TYPE_GENERICINST
    public partial class ProfileServiceMethods
    {

        public static ProfileServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileServiceMethods();


            return value;
        }
    }
}
