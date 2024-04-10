using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 onStateExit                              Subject`1<OnStateInfo> IL2CPP_TYPE_GENERICINST
    // 020 onStateEnter                             Subject`1<OnStateInfo> IL2CPP_TYPE_GENERICINST
    // 028 onStateIK                                Subject`1<OnStateInfo> IL2CPP_TYPE_GENERICINST
    // 030 onStateUpdate                            Subject`1<OnStateInfo> IL2CPP_TYPE_GENERICINST
    // 038 onStateMachineEnter                      Subject`1<OnStateMachineInfo> IL2CPP_TYPE_GENERICINST
    // 040 onStateMachineExit                       Subject`1<OnStateMachineInfo> IL2CPP_TYPE_GENERICINST
    public partial class ObservableStateMachineTrigger : DataModel
    {

        public static ObservableStateMachineTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableStateMachineTrigger() { Pointer= p0 };


            return value;
        }
    }
}
