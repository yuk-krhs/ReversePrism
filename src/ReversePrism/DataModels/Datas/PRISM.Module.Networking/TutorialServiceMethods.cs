using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 StartTutorial                            Method`2<IStartTutorialArgs, IStartTutorialReply> IL2CPP_TYPE_GENERICINST
    // 018 SetTutorialProgress                      Method`2<ISetTutorialProgressArgs, ISetTutorialProgressReply> IL2CPP_TYPE_GENERICINST
    // 030 GetTutorialProduceUnit                   Method`2<IGetTutorialProduceUnitArgs, IGetTutorialProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 048 StartProduceTutorial                     Method`2<IStartProduceTutorialArgs, IStartProduceTutorialReply> IL2CPP_TYPE_GENERICINST
    // 060 FinishTutorial                           Method`2<IFinishTutorialArgs, IFinishTutorialReply> IL2CPP_TYPE_GENERICINST
    // 078 ProceedTutorial                          Method`2<IProceedTutorialArgs, IProceedTutorialReply> IL2CPP_TYPE_GENERICINST
    public partial class TutorialServiceMethods
    {

        public static TutorialServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialServiceMethods();


            return value;
        }
    }
}
