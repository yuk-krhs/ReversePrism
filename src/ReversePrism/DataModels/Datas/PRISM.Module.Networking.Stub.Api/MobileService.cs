using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetTwestaListArgs       Marshaller`1<GetTwestaListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetTwestaListReply      Marshaller`1<GetTwestaListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetTwestaAllArgs        Marshaller`1<GetTwestaAllArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetTwestaAllReply       Marshaller`1<GetTwestaAllReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ReadAllTwestaArticleArgs Marshaller`1<ReadAllTwestaArticleArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ReadAllTwestaArticleReply Marshaller`1<ReadAllTwestaArticleReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_ToggleFavoriteTwestaArticleArgs Marshaller`1<ToggleFavoriteTwestaArticleArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_ToggleFavoriteTwestaArticleReply Marshaller`1<ToggleFavoriteTwestaArticleReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetChainArgs            Marshaller`1<GetChainArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetChainReply           Marshaller`1<GetChainReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_SelectChainOptionArgs   Marshaller`1<SelectChainOptionArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_SelectChainOptionReply  Marshaller`1<SelectChainOptionReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_ReadChainTalkArgs       Marshaller`1<ReadChainTalkArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_ReadChainTalkReply      Marshaller`1<ReadChainTalkReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_GetPhoneCallListArgs    Marshaller`1<GetPhoneCallListArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_GetPhoneCallListReply   Marshaller`1<GetPhoneCallListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Marshaller_api_ReadPhoneCallArgs       Marshaller`1<ReadPhoneCallArgs> IL2CPP_TYPE_GENERICINST
    // 090 __Marshaller_api_ReadPhoneCallReply      Marshaller`1<ReadPhoneCallReply> IL2CPP_TYPE_GENERICINST
    // 098 __Method_GetTwestaList                   Method`2<GetTwestaListArgs, GetTwestaListReply> IL2CPP_TYPE_GENERICINST
    // 0A0 __Method_GetTwestaAll                    Method`2<GetTwestaAllArgs, GetTwestaAllReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Method_ReadAllTwestaArticle            Method`2<ReadAllTwestaArticleArgs, ReadAllTwestaArticleReply> IL2CPP_TYPE_GENERICINST
    // 0B0 __Method_ToggleFavoriteTwestaArticle     Method`2<ToggleFavoriteTwestaArticleArgs, ToggleFavoriteTwestaArticleReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Method_GetChain                        Method`2<GetChainArgs, GetChainReply> IL2CPP_TYPE_GENERICINST
    // 0C0 __Method_SelectChainOption               Method`2<SelectChainOptionArgs, SelectChainOptionReply> IL2CPP_TYPE_GENERICINST
    // 0C8 __Method_ReadChainTalk                   Method`2<ReadChainTalkArgs, ReadChainTalkReply> IL2CPP_TYPE_GENERICINST
    // 0D0 __Method_GetPhoneCallList                Method`2<GetPhoneCallListArgs, GetPhoneCallListReply> IL2CPP_TYPE_GENERICINST
    // 0D8 __Method_ReadPhoneCall                   Method`2<ReadPhoneCallArgs, ReadPhoneCallReply> IL2CPP_TYPE_GENERICINST
    public partial class MobileService : DataModel
    {

        public static MobileService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileService() { Pointer= p0 };


            return value;
        }
    }
}
