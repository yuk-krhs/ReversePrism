using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetTwestaList                            Method`2<IGetTwestaListArgs, IGetTwestaListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetTwestaAll                             Method`2<IGetTwestaAllArgs, IGetTwestaAllReply> IL2CPP_TYPE_GENERICINST
    // 030 ReadAllTwestaArticle                     Method`2<IReadAllTwestaArticleArgs, IReadAllTwestaArticleReply> IL2CPP_TYPE_GENERICINST
    // 048 ToggleFavoriteTwestaArticle              Method`2<IToggleFavoriteTwestaArticleArgs, IToggleFavoriteTwestaArticleReply> IL2CPP_TYPE_GENERICINST
    // 060 GetChain                                 Method`2<IGetChainArgs, IGetChainReply> IL2CPP_TYPE_GENERICINST
    // 078 SelectChainOption                        Method`2<ISelectChainOptionArgs, ISelectChainOptionReply> IL2CPP_TYPE_GENERICINST
    // 090 ReadChainTalk                            Method`2<IReadChainTalkArgs, IReadChainTalkReply> IL2CPP_TYPE_GENERICINST
    // 0A8 GetPhoneCallList                         Method`2<IGetPhoneCallListArgs, IGetPhoneCallListReply> IL2CPP_TYPE_GENERICINST
    // 0C0 ReadPhoneCall                            Method`2<IReadPhoneCallArgs, IReadPhoneCallReply> IL2CPP_TYPE_GENERICINST
    public partial class MobileServiceMethods : DataModel
    {

        public static MobileServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
