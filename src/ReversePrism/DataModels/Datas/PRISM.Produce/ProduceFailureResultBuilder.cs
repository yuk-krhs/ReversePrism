using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ProduceFailureResultView ProduceFailureResultView ProduceFailureResultView Pointer
    // 028 AdvView                                  ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
    public partial class ProduceFailureResultBuilder : DataModel
    {
        public ProduceFailureResultView?                View                                    { get; set; }
        public InGameResultADVView?                     AdvView                                 { get; set; }

        public static ProduceFailureResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceFailureResultView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceFailureResultView.FromPointer); // 0x20 View                        ( ModelClassType ProduceFailureResultView ProduceFailureResultView ProduceFailureResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x028), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 0x28 AdvView                     ( ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
