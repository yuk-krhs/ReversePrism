using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 028 View                                     0001865417E0 ModelClassType ProduceFailureResultView ProduceFailureResultView ProduceFailureResultView Pointer
    // 030 AdvView                                  0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
    public partial class ProduceFailureResultBuilder
    {
        public ProduceFailureResultView?                View                                    { get; set; }
        public InGameResultADVView?                     AdvView                                 { get; set; }

        public static ProduceFailureResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultBuilder();

            value.View                                      = GetObject<ProduceFailureResultView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceFailureResultView.FromPointer); // 0270DB620118 0x28 View                        ( 0001865417E0 ModelClassType ProduceFailureResultView ProduceFailureResultView ProduceFailureResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x030), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 0270DB620138 0x30 AdvView                     ( 0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
