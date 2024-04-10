using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetChallengeTourArgs    Marshaller`1<GetChallengeTourArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetChallengeTourReply   Marshaller`1<GetChallengeTourReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_SetChallengeTourUnitArgs Marshaller`1<SetChallengeTourUnitArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_SetChallengeTourUnitReply Marshaller`1<SetChallengeTourUnitReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_BuildChallengeTourProduceIdolUnitArgs Marshaller`1<BuildChallengeTourProduceIdolUnitArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_BuildChallengeTourProduceIdolUnitReply Marshaller`1<BuildChallengeTourProduceIdolUnitReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_TouchChallengeTourArgs  Marshaller`1<TouchChallengeTourArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_TouchChallengeTourReply Marshaller`1<TouchChallengeTourReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_StartChallengeTourStageArgs Marshaller`1<StartChallengeTourStageArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_StartChallengeTourStageReply Marshaller`1<StartChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_FinishChallengeTourStageArgs Marshaller`1<FinishChallengeTourStageArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_FinishChallengeTourStageReply Marshaller`1<FinishChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_GetChallengeTour                Method`2<GetChallengeTourArgs, GetChallengeTourReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_SetChallengeTourUnit            Method`2<SetChallengeTourUnitArgs, SetChallengeTourUnitReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_BuildChallengeTourProduceIdolUnit Method`2<BuildChallengeTourProduceIdolUnitArgs, BuildChallengeTourProduceIdolUnitReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_TouchChallengeTour              Method`2<TouchChallengeTourArgs, TouchChallengeTourReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_StartChallengeTourStage         Method`2<StartChallengeTourStageArgs, StartChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_FinishChallengeTourStage        Method`2<FinishChallengeTourStageArgs, FinishChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    public partial class ChallengeTourService : DataModel
    {

        public static ChallengeTourService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourService() { Pointer= p0 };


            return value;
        }
    }
}
