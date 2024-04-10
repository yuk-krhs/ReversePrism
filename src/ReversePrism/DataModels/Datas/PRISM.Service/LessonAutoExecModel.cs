using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer
    // 018 <OnExecuteLesson>k__BackingField         Func`2<IStartLessonReply, IInGameResultStatus> IL2CPP_TYPE_GENERICINST
    // 020 <OnSelectProduceCard>k__BackingField     Func`5<IReadOnlyList`1<IProduceCardStatus>, int, IReadOnlyList`1<IProduceCardStatus>, IReadOnlyList`1<IInProduceIdolSkillStatus>, IReadOnlyList`1<string>> IL2CPP_TYPE_GENERICINST
    // 028 <OnExecScenarioAsync>k__BackingField     Func`4<ProduceNextOrderType, IProduceBaseInfoStatus, CancellationToken, UniTask`1<ValueTuple`2<ProduceNextOrderType, IProduceBaseInfoStatus>>> IL2CPP_TYPE_GENERICINST
    public partial class LessonAutoExecModel : DataModel
    {
        public ProduceService?                          Service                                 { get; set; }

        public static LessonAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonAutoExecModel() { Pointer= p0 };

            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceService.FromPointer); // 02466AE505E8 0x10 Service                     ( 00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
