using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 RequiredParam                            ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 020 UnitParam                                ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    public partial class ParameterCondition : DataModel
    {
        public IProduceParameterStatus?                 RequiredParam                           { get; set; }
        public IProduceParameterStatus?                 UnitParam                               { get; set; }

        public static ParameterCondition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterCondition() { Pointer= p0 };

            value.RequiredParam                             = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x18 RequiredParam               ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.UnitParam                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x20 UnitParam                   ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
