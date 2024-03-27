using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer
    // 018 onFailure                                Subject`1<IProduceFailureResultReply> IL2CPP_TYPE_GENERICINST
    // 020 <OnExecuteAudition>k__BackingField       Func`2<IStartAuditionReply, IInGameResultStatus> IL2CPP_TYPE_GENERICINST
    // 028 <OnExecScenarioAsync>k__BackingField     Func`4<ProduceNextOrderType, IProduceBaseInfoStatus, CancellationToken, UniTask`1<ValueTuple`2<ProduceNextOrderType, IProduceBaseInfoStatus>>> IL2CPP_TYPE_GENERICINST
    public partial class AuditionAutoExecModel
    {
        public ProduceService?                          Service                                 { get; set; }

        public static AuditionAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionAutoExecModel();

            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceService.FromPointer); // 0270DADF3170 0x10 Service                     ( 00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
