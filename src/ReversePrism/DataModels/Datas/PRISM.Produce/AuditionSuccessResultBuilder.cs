using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType AuditionSuccessResultView AuditionSuccessResultView AuditionSuccessResultView Pointer
    // 028 AdvView                                  ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
    public partial class AuditionSuccessResultBuilder : DataModel
    {
        public AuditionSuccessResultView?               View                                    { get; set; }
        public InGameResultADVView?                     AdvView                                 { get; set; }

        public static AuditionSuccessResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionSuccessResultBuilder() { Pointer= p0 };

            value.View                                      = GetObject<AuditionSuccessResultView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AuditionSuccessResultView.FromPointer); // 0x20 View                        ( ModelClassType AuditionSuccessResultView AuditionSuccessResultView AuditionSuccessResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x028), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 0x28 AdvView                     ( ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
