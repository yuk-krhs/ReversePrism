using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 RequiredParam                            0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 020 UnitParam                                0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    public partial class ParameterCondition
    {
        public IProduceParameterStatus?                 RequiredParam                           { get; set; }
        public IProduceParameterStatus?                 UnitParam                               { get; set; }

        public static ParameterCondition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterCondition();

            value.RequiredParam                             = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D4D26688 0x18 RequiredParam               ( 0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.UnitParam                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D4D266A8 0x20 UnitParam                   ( 0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
