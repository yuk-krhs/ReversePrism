using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186579160 ModelClassType ProduceResultView ProduceResultView ProduceResultView Pointer
    // 028 FUnitDetailPopupViewFactory              000186574130 ModelClassType ProduceResultFUnitDetailPopupViewFactory ProduceResultFUnitDetailPopupViewFactory ProduceResultFUnitDetailPopupViewFactory Pointer
    public partial class ProduceResultBuilder : DataModel
    {
        public ProduceResultView?                       View                                    { get; set; }
        public ProduceResultFUnitDetailPopupViewFactory? FUnitDetailPopupViewFactory             { get; set; }

        public static ProduceResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceResultView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceResultView.FromPointer); // 02466B6B3BB0 0x20 View                        ( 000186579160 ModelClassType ProduceResultView ProduceResultView ProduceResultView Pointer )
            value.FUnitDetailPopupViewFactory               = GetObject<ProduceResultFUnitDetailPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceResultFUnitDetailPopupViewFactory.FromPointer); // 02466B6B3BD0 0x28 FUnitDetailPopupViewFactory ( 000186574130 ModelClassType ProduceResultFUnitDetailPopupViewFactory ProduceResultFUnitDetailPopupViewFactory ProduceResultFUnitDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
