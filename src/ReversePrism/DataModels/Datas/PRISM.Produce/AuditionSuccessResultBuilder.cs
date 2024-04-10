using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 028 View                                     00018671E210 ModelClassType AuditionSuccessResultView AuditionSuccessResultView AuditionSuccessResultView Pointer
    // 030 AdvView                                  0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
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

            value.View                                      = GetObject<AuditionSuccessResultView>(new IntPtr(p + 0x028), ReversePrism.DataModels.AuditionSuccessResultView.FromPointer); // 02466B6B3860 0x28 View                        ( 00018671E210 ModelClassType AuditionSuccessResultView AuditionSuccessResultView AuditionSuccessResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x030), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 02466B6B3880 0x30 AdvView                     ( 0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
