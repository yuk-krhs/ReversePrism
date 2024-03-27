using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetChallengeTour                         Method`2<IGetChallengeTourArgs, IGetChallengeTourReply> IL2CPP_TYPE_GENERICINST
    // 018 SetChallengeTourUnit                     Method`2<ISetChallengeTourUnitArgs, ISetChallengeTourUnitReply> IL2CPP_TYPE_GENERICINST
    // 030 BuildChallengeTourProduceIdolUnit        Method`2<IBuildChallengeTourProduceIdolUnitArgs, IBuildChallengeTourProduceIdolUnitReply> IL2CPP_TYPE_GENERICINST
    // 048 TouchChallengeTour                       Method`2<ITouchChallengeTourArgs, ITouchChallengeTourReply> IL2CPP_TYPE_GENERICINST
    // 060 StartChallengeTourStage                  Method`2<IStartChallengeTourStageArgs, IStartChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    // 078 FinishChallengeTourStage                 Method`2<IFinishChallengeTourStageArgs, IFinishChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    public partial class ChallengeTourServiceMethods
    {

        public static ChallengeTourServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourServiceMethods();


            return value;
        }
    }
}
