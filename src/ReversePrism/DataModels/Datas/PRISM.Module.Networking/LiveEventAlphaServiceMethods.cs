using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetLiveEventAlphaTopPage                 Method`2<IGetLiveEventAlphaTopPageArgs, IGetLiveEventAlphaTopPageReply> IL2CPP_TYPE_GENERICINST
    // 018 GetLiveEventAlphaRewardList              Method`2<IGetLiveEventAlphaRewardListArgs, IGetLiveEventAlphaRewardListReply> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventAlphaServiceMethods : DataModel
    {

        public static LiveEventAlphaServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAlphaServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
