using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  ModelClassType ProduceService ProduceService ProduceService Pointer
    // 018 <OnExecInGameResultAsync>k__BackingField Func`4<ProduceNextOrderType, IInGameResultStatus, CancellationToken, UniTask`1<ValueTuple`2<ProduceNextOrderType, IProduceBaseInfoStatus>>> IL2CPP_TYPE_GENERICINST
    // 020 <OnSelectSubSeasonIdolAsync>k__BackingField Func`4<IReadOnlyList`1<int>, int, CancellationToken, UniTask`1<ValueTuple`2<ProduceNextOrderType, IProduceBaseInfoStatus>>> IL2CPP_TYPE_GENERICINST
    // 028 <OnSelectInheritanceSkillAsync>k__BackingField Func`2<CancellationToken, UniTask`1<ValueTuple`2<ProduceNextOrderType, IProduceBaseInfoStatus>>> IL2CPP_TYPE_GENERICINST
    public partial class ProduceResumeAutoExecModel : DataModel
    {
        public ProduceService?                          Service                                 { get; set; }

        public static ProduceResumeAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResumeAutoExecModel() { Pointer= p0 };

            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceService.FromPointer); // 0x10 Service                     ( ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
