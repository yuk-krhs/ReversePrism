using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetLiveEventAlphaTopPageArgs Marshaller`1<GetLiveEventAlphaTopPageArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetLiveEventAlphaTopPageReply Marshaller`1<GetLiveEventAlphaTopPageReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetLiveEventAlphaRewardListArgs Marshaller`1<GetLiveEventAlphaRewardListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetLiveEventAlphaRewardListReply Marshaller`1<GetLiveEventAlphaRewardListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_GetLiveEventAlphaTopPage        Method`2<GetLiveEventAlphaTopPageArgs, GetLiveEventAlphaTopPageReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_GetLiveEventAlphaRewardList     Method`2<GetLiveEventAlphaRewardListArgs, GetLiveEventAlphaRewardListReply> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventAlphaService : DataModel
    {

        public static LiveEventAlphaService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAlphaService() { Pointer= p0 };


            return value;
        }
    }
}
