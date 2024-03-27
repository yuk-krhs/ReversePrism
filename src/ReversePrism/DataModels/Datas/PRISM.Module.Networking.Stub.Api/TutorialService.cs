using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_StartTutorialArgs       Marshaller`1<StartTutorialArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_StartTutorialReply      Marshaller`1<StartTutorialReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_SetTutorialProgressArgs Marshaller`1<SetTutorialProgressArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_SetTutorialProgressReply Marshaller`1<SetTutorialProgressReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetTutorialProduceUnitArgs Marshaller`1<GetTutorialProduceUnitArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetTutorialProduceUnitReply Marshaller`1<GetTutorialProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_StartProduceTutorialArgs Marshaller`1<StartProduceTutorialArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_StartProduceTutorialReply Marshaller`1<StartProduceTutorialReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_FinishTutorialArgs      Marshaller`1<FinishTutorialArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_FinishTutorialReply     Marshaller`1<FinishTutorialReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_ProceedTutorialArgs     Marshaller`1<ProceedTutorialArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_ProceedTutorialReply    Marshaller`1<ProceedTutorialReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_StartTutorial                   Method`2<StartTutorialArgs, StartTutorialReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_SetTutorialProgress             Method`2<SetTutorialProgressArgs, SetTutorialProgressReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_GetTutorialProduceUnit          Method`2<GetTutorialProduceUnitArgs, GetTutorialProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_StartProduceTutorial            Method`2<StartProduceTutorialArgs, StartProduceTutorialReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_FinishTutorial                  Method`2<FinishTutorialArgs, FinishTutorialReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_ProceedTutorial                 Method`2<ProceedTutorialArgs, ProceedTutorialReply> IL2CPP_TYPE_GENERICINST
    public partial class TutorialService
    {

        public static TutorialService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialService();


            return value;
        }
    }
}
