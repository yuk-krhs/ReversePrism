using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeCounters                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 onUpdateCounterSubject                   Subject`1<ValueTuple`2<ProduceParameterType, int>> IL2CPP_TYPE_GENERICINST
    public partial class IngameTypeCounterModel : DataModel
    {
        public List<int>?                               TypeCounters                            { get; set; }

        public static IngameTypeCounterModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameTypeCounterModel() { Pointer= p0 };

            value.TypeCounters                              = GetInt32List(new IntPtr(p + 0x010)); // 0x10 TypeCounters                ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
